using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyHocSinh
{
    class LoaiKiemTra
    {
        private string MaLKT { get; set; }
        private string TenLKT { get; set; }

        public LoaiKiemTra( string maLKT = "",
                            string tenLKT = "")
        {
            MaLKT = maLKT;
            TenLKT = tenLKT;
        }
    }
}
