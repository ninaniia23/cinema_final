using System;
using System.Collections.Generic;

namespace Cinema.Models
{
    public partial class Rap
    {
        public Rap()
        {
            LichChieus = new HashSet<LichChieu>();
        }

        public int MaRap { get; set; }
        public int? TongGhe { get; set; }
        public int? MaCum { get; set; }
        public int? MaPhongChieu { get; set; }

        public virtual CumRap? MaCumNavigation { get; set; }
        public virtual PhongChieu? MaPhongChieuNavigation { get; set; }
        public virtual ICollection<LichChieu> LichChieus { get; set; }
    }
}
