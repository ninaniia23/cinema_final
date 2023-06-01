using Cinema.Models;
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

namespace Cinema.Views.Admin.ShowtimeManagementVM
{
    /// <summary>
    /// Interaction logic for AddShowtimeWindow.xaml
    /// </summary>
    public partial class AddShowtimeWindow : Window
    {
        public AddShowtimeWindow()
        {
            InitializeComponent();
            cinemaContext db = new cinemaContext();
            var list = db.Phims.ToList();
            nameFilm.ItemsSource = list;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void _movieRoom_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void room_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            cinemaContext db = new cinemaContext();
            var list = db.PhongChieus.ToList();
            room.ItemsSource = list;
        }
    }
}
