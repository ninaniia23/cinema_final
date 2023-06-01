using System;
using System.Collections.Generic;

namespace Cinema.Models
{
    public partial class KeHoachChieu
    {
        public int MaPhim { get; set; }
        public int MaCum { get; set; }
        public DateTime NgayKhoiChieu { get; set; }
        public DateTime NgayKetThuc { get; set; }
        public string? GhiChu { get; set; }

        public virtual CumRap MaCumNavigation { get; set; } = null!;
        public virtual Phim MaPhimNavigation { get; set; } = null!;
    }
}
