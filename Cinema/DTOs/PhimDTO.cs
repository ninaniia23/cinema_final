using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.DTOs
{
    public class PhimDTO
    {
        public PhimDTO(int maPhim, string? tenTheLoaiChinh, string? tenPhim, int? thoiLuong, string? gioBatDau, int? phutBatDau)
        {
            MaPhim = maPhim;
            TenTheLoaiChinh = tenTheLoaiChinh;
            TenPhim = tenPhim;
            ThoiLuong = thoiLuong;
            GioBatDau = gioBatDau;
            PhutBatDau = phutBatDau;
        }

        public PhimDTO(int maPhim, string? tenTheLoaiChinh, string? tenPhim, int? thoiLuong, string? quocGia, string moTa,string tacGia)
        {
            MaPhim = maPhim;
            TenTheLoaiChinh = tenTheLoaiChinh;
            TenPhim = tenPhim;
            ThoiLuong = thoiLuong;
            QuocGia = quocGia;
            MoTa = moTa;
            TacGia = tacGia;
        }

        public PhimDTO(int maPhim,string tenPhim, string tacGia, string quocGia,int thoiLuong,string moTa)
        {
            MaPhim = maPhim;
            TacGia = tacGia;
            QuocGia = quocGia;
            MoTa = moTa;
            TenPhim= tenPhim;
            ThoiLuong= thoiLuong;
        }
        public int MaPhim { get; set; }
        public string? TenTheLoaiChinh { get; set; }
        public string? TenPhim { get; set; }
        public int? ThoiLuong { get; set; }
        public string? GioBatDau { get; set; }
        public int? PhutBatDau { get; set; }

        public string? MoTa { get; set; }
        public string? TacGia { get; set; }
        public string? QuocGia { get; set; }
        public int? MaSuat { get; set; }

    }
}
