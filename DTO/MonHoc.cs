using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyHocSinh
{
    class MonHoc
    {
        private string MaMH { get; set; }
        private string TenMH { get; set; }
        
        public MonHoc(  string maMH = "",
                        string tenMH = "")
        {
            MaMH = maMH;
            TenMH = tenMH;
        }
    }
}
