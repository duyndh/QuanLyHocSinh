using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyHocSinh
{
    class ChiTietDiem
    {
        private string MaCTD { get; set; }
        private string Diem { get; set; }
        private string MaLKT { get; set; }
        private string MaHP { get; set; }

        public ChiTietDiem( string maCTD = "",
                            string diem = "",
                            string maLKT = "",
                            string maHP = "")
        {
            MaCTD = maCTD;
            Diem = diem;
            MaLKT = maLKT;
            MaHP = maHP;
        }
    }
}
