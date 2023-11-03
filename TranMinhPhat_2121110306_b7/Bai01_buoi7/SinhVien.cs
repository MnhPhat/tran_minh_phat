using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai01_buoi7
{
    internal class SinhVien
    {
        public string MaSV { get; set; }

        public string HoTen { get; set; }

        public int MaKhoa { get; set; }

 
        public object DiemTB { get; internal set; }

        public SinhVien() { }

        public SinhVien(string masv, string hoten, int makhoa, double diemtb)
        {
            this.MaSV = masv;
            this.HoTen = hoten;
            this.MaKhoa = makhoa;
            this.DiemTB = diemtb;

        }
    }
}
