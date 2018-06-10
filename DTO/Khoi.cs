using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyHocSinh
{
    class Khoi
    {
        private string MaKhoi { get; set; }
        private string TenKhoi { get; set; }
        private string SoLop { get; set; }

        public Khoi(string maKhoi = "",
                    string tenKhoi = "",
                    string soLop = "")
        {
            MaKhoi = maKhoi;
            TenKhoi = tenKhoi;
            SoLop = soLop;
        }
    }
}
