using FrontDesk.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace FrontDesk
{
    /// <summary>
    /// Interaction logic for ReservationEditor.xaml
    /// </summary>
    public partial class ReservationEditor : Window
    {
        public PostgresContext _context { get; set; }
        public List<String> ReservationStatuses { get; } = new()
        {
            "Booked",
            "Checked In",
            "Checked out"
        };

        
        public ReservationEditor()
        {
            InitializeComponent();
            statusDropdown.ItemsSource = ReservationStatuses;
        }

        public ReservationEditor(Reservation r)
        {
            InitializeComponent();

            statusDropdown.SelectedItem = r.Status;
            statusDropdown.ItemsSource = ReservationStatuses;

            resId.Text = r.Id.ToString();
            resUsername.Text = r.Username;
            resRoomNum.Text = r.Roomnumber.ToString();
            resStartDate.Text = r.Startdate.ToShortDateString();
            resEndDate.Text = r.Enddate.ToShortDateString();

            addResBtn.IsEnabled = false;
        }
        private void addResBtn_Click(object sender, RoutedEventArgs e)
        {
            Reservation res = new()
            {
                Username = resUsername.Text,
                Roomnumber = int.Parse(resRoomNum.Text),
                Status = statusDropdown.SelectedItem.ToString(),
                Startdate = DateOnly.Parse(resStartDate.Text),
                Enddate = DateOnly.Parse(resEndDate.Text)
            };

            _context.Reservations.Add(res);
            _context.SaveChanges();

            Close();
        }

        private void updateResBtn_Click(object sender, RoutedEventArgs e)
        {
            int id = int.Parse(resId.Text);
            Reservation res = _context.Reservations.Where(r => r.Id == id).First();

            if (res != null)
            {
                if (resUsername.Text.Length > 0) res.Username = resUsername.Text;
                if (resRoomNum.Text.Length > 0) res.Roomnumber= int.Parse(resRoomNum.Text);
                if (resStartDate.Text.Length > 0) res.Startdate = DateOnly.Parse(resStartDate.Text);
                if (resEndDate.Text.Length > 0) res.Enddate= DateOnly.Parse(resEndDate.Text);
                if (statusDropdown.SelectedItem.ToString()?.Length > 0) { res.Status = statusDropdown.Text; }

                _context.SaveChanges();
            }

            Close();
        }

        private void delResBtn_Click(object sender, RoutedEventArgs e)
        {
            int id = int.Parse(resId.Text);
            Reservation res = _context.Reservations.Where(r => r.Id == id).First();

            if (res != null)
            {
                _context.Reservations.Remove(res);
                _context.SaveChanges();
            }

            Close();
        }
    }
}
