using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyHocSinh
{
    class HocKy
    {
        private string MaHK { get; set; }
        private string TenHK { get; set; }
        
        public HocKy(   string maHK = "",
                        string tenHK = "")
        {
            MaHK = maHK;
            TenHK = tenHK;
        }
    }
}
