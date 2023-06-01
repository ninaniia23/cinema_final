using System;
using System.Collections.Generic;

namespace Cinema.Models
{
    public partial class LichChieu
    {
        public int MaPhim { get; set; }
        public int MaRap { get; set; }
        public DateTime NgayChieu { get; set; }

        public virtual Phim MaPhimNavigation { get; set; } = null!;
        public virtual Rap MaRapNavigation { get; set; } = null!;
    }
}
