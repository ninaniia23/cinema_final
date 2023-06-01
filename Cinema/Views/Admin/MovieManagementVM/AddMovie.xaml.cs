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
    /// Interaction logic for AddMovie.xaml
    /// </summary>
    public partial class AddMovie : Window
    {
        public AddMovie()
        {
            InitializeComponent();
            //cinemaContext db = new cinemaContext();
            //var list = db.TheLoais.ToList();
            //cate.ItemsSource = list;
            cinemaContext db = new cinemaContext();
            var list = db.TheLoais.ToList();
            cate.ItemsSource = list;
        }

        private void _movieCountry_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void _movieDuration_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, object e)
        {

        }

        private void save_Click(object sender, RoutedEventArgs e)
        {
            TheLoai selectedCategory = (TheLoai)cate.SelectedItem;
            string name = filmName.Text;
            string desc = description.Text;
            int cateX = selectedCategory.MaTheLoai;
            String author = director.Text;
            String nuoc = country.Text;
            cinemaContext db = new cinemaContext();
            db.Phims.Add(new Phim
            {
                
                TenPhim = filmName.Text,
                MaTheLoaiChinh = cateX,
                ThoiLuong = Convert.ToInt32(minutes.Text),
                TacGia = director.Text,
                QuocGia = country.Text,
                MoTa = description.Text

            }); ;

            db.SaveChanges();
            MessageBox.Show("Thêm thành công");
            this.Close();


        }

        private void cate_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void filmName_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
