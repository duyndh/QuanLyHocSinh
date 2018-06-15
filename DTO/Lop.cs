using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyHocSinh
{
    public class Lop
    {
        public string MaLop { get; set; }
        public string TenLop { get; set; }
        public string SiSo { get; set; }
        public string MaKhoi { get; set; }

        public Lop( string maLop = "",
                    string tenLop = "",
                    string siSo = "",
                    string maKhoi = "")
        {
            MaLop = maLop;
            TenLop = tenLop;
            SiSo = siSo;
            MaKhoi = maKhoi;
        }
    }
}
