
using Cinema.DTOs;
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

namespace Cinema.Views.Admin.MovieManagementVM
{
    /// <summary>
    /// Interaction logic for InforMovie.xaml
    /// </summary>
    public partial class InforMovie : Window
    {
        public InforMovie(PhimDTO phim)
        {
            InitializeComponent();
            film.Text = phim.TenPhim;
            tacgia.Text = phim.TacGia;

            nuoc.Text = phim.QuocGia;
            category.Text = phim.TenTheLoaiChinh;
            thoiluong.Text = phim.ThoiLuong.ToString();
            description.Text = phim.MoTa;
        }

        public InforMovie()
        {
            InitializeComponent();
        }

        private void description_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void nuoc_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
