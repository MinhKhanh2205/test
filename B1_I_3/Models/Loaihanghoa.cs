using System;
using System.Collections.Generic;

namespace B1_I_3.Models
{
    public partial class Loaihanghoa
    {
        public Loaihanghoa()
        {
            Hanghoa = new HashSet<Hanghoa>();
        }

        public string Maloai { get; set; }
        public string Tenloai { get; set; }

        public ICollection<Hanghoa> Hanghoa { get; set; }
    }
}
