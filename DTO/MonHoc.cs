using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyHocSinh
{
    public class MonHoc
    {
        public string MaMH { get; set; }
        public string TenMH { get; set; }
        
        public MonHoc(  string maMH = "",
                        string tenMH = "")
        {
            MaMH = maMH;
            TenMH = tenMH;
        }
    }
}
