using FrontDesk.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
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
using System.Windows.Shapes;

namespace FrontDesk
{
    /// <summary>
    /// Interaction logic for RoomInfo.xaml
    /// </summary>
    public partial class RoomInfo : Window
    {

        public PostgresContext _context { get; set; }
        private readonly LocalView<Models.Task> Tasks;

        public RoomInfo()
        {
            InitializeComponent();
        }

        public RoomInfo(Room r, LocalView<Models.Task> tasks)
        {
            InitializeComponent();

            rNr.Text = r.Roomnumber.ToString();
            rBedsNr.Text = r.Numberofbeds.ToString();
            rType.Text = r.Roomtype;
            rRes.Text = r.Reserved.ToString();

            Tasks = tasks;
            tasksList.DataContext = Tasks.Where(t => t.Roomnumber == r.Roomnumber)
                .OrderBy(t => t.Id);

        }
    }
}
