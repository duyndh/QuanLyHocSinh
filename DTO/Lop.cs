using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyHocSinh
{
    class Lop
    {
        private string MaLop { get; set; }
        private string TenLop { get; set; }
        private string SiSo { get; set; }
        private string MaKhoi { get; set; }

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
