using System;
using System.Collections.Generic;

namespace Cinema.Models
{
    public partial class Phim
    {
        public Phim()
        {
            KeHoachChieus = new HashSet<KeHoachChieu>();
            LichChieus = new HashSet<LichChieu>();
            SuatChieus = new HashSet<SuatChieu>();
            MaTheLoais = new HashSet<TheLoai>();
        }

        public int MaPhim { get; set; }
        public int? MaTheLoaiChinh { get; set; }
        public string? TenPhim { get; set; }
        public int? ThoiLuong { get; set; }
        public string? MoTa { get; set; }
        public string? TacGia { get; set; }
        public string? QuocGia { get; set; }
        public int? MaSuat { get; set; }

        public virtual SuatChieu? MaSuatNavigation { get; set; }
        public virtual TheLoai? MaTheLoaiChinhNavigation { get; set; }
        public virtual ICollection<KeHoachChieu> KeHoachChieus { get; set; }
        public virtual ICollection<LichChieu> LichChieus { get; set; }
        public virtual ICollection<SuatChieu> SuatChieus { get; set; }

        public virtual ICollection<TheLoai> MaTheLoais { get; set; }
    }
}
