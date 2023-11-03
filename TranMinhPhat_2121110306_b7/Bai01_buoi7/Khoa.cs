using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai01_buoi7
{
    internal class Khoa
    {
        public String Makhoa
        {
            get; set;
        }
        public String Tenkhoa { get; set; }

        public String Ghichu{ get; set; }
        public Khoa()
        { }
        public Khoa(string makhoa, string tenkhoa, string ghichu)
        {
            this.Makhoa = makhoa;
            this.Tenkhoa = tenkhoa;
            this.Ghichu = ghichu;
        }
    }
}
