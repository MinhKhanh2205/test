using System;
using System.Collections.Generic;

namespace B1_I_3.Models
{
    public partial class Nhasanxuat
    {
        public Nhasanxuat()
        {
            Hanghoa = new HashSet<Hanghoa>();
        }

        public string Mansx { get; set; }
        public string Tennsx { get; set; }
        public string Diachi { get; set; }

        public ICollection<Hanghoa> Hanghoa { get; set; }
    }
}
