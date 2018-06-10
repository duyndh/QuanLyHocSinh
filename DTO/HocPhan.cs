using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyHocSinh
{
    class HocPhan
    {
        private string MaHP { get; set; }
        private string DiemTB { get; set; }
        private string MaHS { get; set; }
        private string MaMH { get; set; }
        private string MaHK { get; set; }

        public HocPhan( string maHP = "",
                        string diemTB = "",
                        string maHS = "",
                        string maMH = "",
                        string maHK = "")
        {
            MaHP = maHP;
            DiemTB = diemTB;
            MaHS = maHS;
            MaMH = maMH;
            MaHK = MaHK;
        }
    }
}
