using System;
using System.Collections.Generic;

namespace Cinema.Models
{
    public partial class PhongChieu
    {
        public PhongChieu()
        {
            Raps = new HashSet<Rap>();
        }

        public int MaPhongChieu { get; set; }
        public string? TenPhongChieu { get; set; }
        public int? SoLuongCho { get; set; }

        public virtual ICollection<Rap> Raps { get; set; }
    }
}
