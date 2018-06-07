using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyHocSinh
{
    class HocPhan
    {
        private int MaHP { get; set; }
        private float DiemTB { get; set; }
        private int MaHS { get; set; }
        private string MaMH { get; set; }
        private string MaHK { get; set; }

        public HocPhan( int maHP = 0,
                        float diemTB = 0,
                        int maHS = 0,
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
