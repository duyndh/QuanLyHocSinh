using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyHocSinh
{
    class ChiTietDiem
    {
        private int MaCTD { get; set; }
        private float Diem { get; set; }
        private string MaLKT { get; set; }
        private int MaHP { get; set; }

        public ChiTietDiem( int maCTD = 0,
                            float diem = 0,
                            string maLKT = "",
                            int maHP = 0)
        {
            MaCTD = maCTD;
            Diem = diem;
            MaLKT = maLKT;
            MaHP = maHP;
        }
    }
}
