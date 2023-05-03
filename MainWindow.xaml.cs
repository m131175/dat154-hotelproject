using FrontDesk.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FrontDesk
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private readonly PostgresContext _context = new();
        private readonly LocalView<Room> Rooms;
        private readonly LocalView<Reservation> Reservations;
        private readonly LocalView<Models.Task> Tasks;

        public MainWindow()
        {
            InitializeComponent();

            Rooms = _context.Rooms.Local;
            Reservations = _context.Reservations.Local;
            Tasks = _context.Tasks.Local;

            _context.Rooms.Load();
            _context.Reservations.Load();
            _context.Tasks.Load();

            roomList.DataContext = Rooms.OrderBy(r => r.Roomnumber);
            reservationList.DataContext = Reservations.OrderBy(r => r.Startdate);   
        }

        private void searchRoomButton_Click(object sender, RoutedEventArgs e)
        {
            roomList.DataContext = Rooms.Where(r => r.Roomtype.ToLower().Contains(searcRoomField.Text.ToLower()))
                .OrderBy(r => r.Roomnumber);
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ReservationEditor resEd = new()
            {
                _context = _context
            };

            resEd.Show();
        }

        private void searchReservationButton_Click(object sender, RoutedEventArgs e)
        {
            reservationList.DataContext = Reservations.Where(r => r.Username.ToLower().Contains(searchReservationField.Text.ToLower()))
                .OrderBy(r => r.Startdate);
        }

        private void reservationList_MouseDoubleClick(object sender, RoutedEventArgs e)
        {
            Reservation r = reservationList.SelectedItem as Reservation;

            if (r != null)
            {
                ReservationEditor resEd = new(r)
                {
                    _context = _context
                };

                resEd.Show();
            }

        }

        private void roomList_MouseDoubleClick(object sender, RoutedEventArgs e)
        {
            Room room = roomList.SelectedItem as Room;

            if (room != null)
            {
                RoomInfo r = new(room, Tasks) 
                { 
                    _context = _context 
                };

                r.Show();
            }
        }

        private void reservationList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}

