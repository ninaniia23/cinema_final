
//using Cinema.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Windows.Threading;

namespace Cinema.Views.Admin
{
    /// <summary>
    /// Interaction logic for MainAdminWindow.xaml
    /// </summary>
    public partial class MainAdminWindow : Window
    {
        DispatcherTimer timer;
        double panelWidth;
        bool hidden;


        public MainAdminWindow()
        {
            InitializeComponent();
            timer = new DispatcherTimer();
            timer.Interval = new TimeSpan(0, 0, 0, 10);
            timer.Tick += Timer_Tick;
            panelWidth = sidePanel.Width;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (hidden)
            {
                sidePanel.Width -= 1;
                if(sidePanel.Width <=30)
                {
                    timer.Stop();
                    hidden =true;
                }
            }
        }
       
        public void load() {

           //cinemaContext db = new cinemaContext(); //LINQ
            //var list = (from phim in db.Phims
            //            join theloai in db.TheLoais on phim.MaTheLoaiChinh equals theloai.MaTheLoai
            //            select phim
            //            ).ToList();
            

        }
    

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            timer.Start();
            //menu.IsEnabled = false;
        }

        //private void hideButton_Click(object sender, RoutedEventArgs e)
        //{
        //    hideButton.IsEnabled = false;
        //}

        private void panelHeader_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if(e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        private void ListViewItem_Selected(object sender, RoutedEventArgs e)
        {

        }
    }
}
