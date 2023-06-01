using System;
using System.Collections.Generic;

namespace Cinema.Models
{
    public partial class CumRap
    {
        public CumRap()
        {
            KeHoachChieus = new HashSet<KeHoachChieu>();
            Raps = new HashSet<Rap>();
        }

        public int MaCum { get; set; }
        public string? TenCum { get; set; }
        public string? DiaChi { get; set; }

        public virtual ICollection<KeHoachChieu> KeHoachChieus { get; set; }
        public virtual ICollection<Rap> Raps { get; set; }
    }
}
