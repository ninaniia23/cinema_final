using System;
using System.Collections.Generic;

namespace Cinema.Models
{
    public partial class TheLoai
    {
        public TheLoai()
        {
            Phims = new HashSet<Phim>();
            MaPhims = new HashSet<Phim>();
        }

        public int MaTheLoai { get; set; }
        public string? TenTheLoai { get; set; }

        public virtual ICollection<Phim> Phims { get; set; }

        public virtual ICollection<Phim> MaPhims { get; set; }
    }
}
