using Cinema.DTOs;
using Cinema.Models;
using Cinema.Views.Admin.ShowtimeManagementVM;
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
    /// Interaction logic for MovieManagement.xaml
    /// </summary>
    public partial class MovieManagement : Window
    {
        public MovieManagement()
        {
            InitializeComponent();
            load();
        }

        void load()
        {
            cinemaContext db = new cinemaContext();
            var list = (from p in db.Phims
                        join tl in db.TheLoais on p.MaTheLoaiChinh equals tl.MaTheLoai
                        select new 
                        {
                            MaPhim = p.MaPhim,
                            TenTheLoaiChinh = tl.TenTheLoai,
                            TenPhim = p.TenPhim,
                            ThoiLuong = p.ThoiLuong,
                            QuocGia = p.QuocGia,
                            TacGia =p.TacGia,
                            MoTa = p.MoTa
                        }).ToList();

            List<PhimDTO> listDTO = new List<PhimDTO>();
            foreach(var i in list)
            {
                listDTO.Add(new PhimDTO(i.MaPhim, i.TenTheLoaiChinh, i.TenPhim, i.ThoiLuong, i.QuocGia, i.MoTa,i.TacGia));
            }
            listView.ItemsSource = listDTO;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            cinemaContext db = new cinemaContext();
            string key = keySearch.Text;
            var list = (from p in db.Phims
                        join tl in db.TheLoais on p.MaTheLoaiChinh equals tl.MaTheLoai
                        where p.TenPhim.Contains(key)
                        select new
                        {
                            MaPhim = p.MaPhim,
                            TenTheLoaiChinh = tl.TenTheLoai,
                            TenPhim = p.TenPhim,
                            ThoiLuong = p.ThoiLuong,
                            QuocGia = p.QuocGia,
                            MoTa = p.MoTa,
                            TacGia =p.TacGia
                        }).ToList();

            List<PhimDTO> listDTO = new List<PhimDTO>();
            foreach (var i in list)
            {
                listDTO.Add(new PhimDTO(i.MaPhim, i.TenTheLoaiChinh, i.TenPhim, i.ThoiLuong, i.QuocGia, i.MoTa,i.TacGia));
            }
            listView.ItemsSource = listDTO;
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void search_Click(object sender, RoutedEventArgs e)
        {
            cinemaContext db = new cinemaContext();
            string key = keySearch.Text;
            var list = (from p in db.Phims
                        join tl in db.TheLoais on p.MaTheLoaiChinh equals tl.MaTheLoai
                        where p.TenPhim.Contains(key)
                        select new
                        {
                            MaPhim = p.MaPhim,
                            TenTheLoaiChinh = tl.TenTheLoai,
                            TenPhim = p.TenPhim,
                            ThoiLuong = p.ThoiLuong,
                            QuocGia = p.QuocGia,
                            MoTa = p.MoTa,
                            TacGia =p.TacGia
                        }).ToList();

            List<PhimDTO> listDTO = new List<PhimDTO>();
            foreach (var i in list)
            {
                listDTO.Add(new PhimDTO(i.MaPhim, i.TenTheLoaiChinh, i.TenPhim, i.ThoiLuong, i.QuocGia, i.MoTa,i.TacGia));
            }
            listView.ItemsSource = listDTO;
        }

        private void add_Click(object sender, RoutedEventArgs e)
        {
            AddMovie am = new AddMovie();
            am.Show();
        }

        private void listView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            PhimDTO phim = (PhimDTO)listView.SelectedItem;
            if(phim != null && phim is PhimDTO)
            {
                InforMovie lich = new InforMovie(phim);
                lich.Show();
            }
        }
    }
}
