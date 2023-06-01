using System;
using System.Collections.Generic;

namespace Cinema.Models
{
    public partial class SuatChieu
    {
        public SuatChieu()
        {
            Phims = new HashSet<Phim>();
        }

        public int MaSuat { get; set; }
        public int? GiaVe { get; set; }
        public int? GioBatDau { get; set; }
        public int? PhutBatDau { get; set; }
        public int? MaPhim { get; set; }

        public virtual Phim? MaPhimNavigation { get; set; }
        public virtual ICollection<Phim> Phims { get; set; }
    }
}
