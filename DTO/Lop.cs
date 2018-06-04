using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    class Lop
    {
        private string MaLop { get; set; }
        private string TenLop { get; set; }
        private int SiSo { get; set; }
        private string MaKhoi { get; set; }

        public Lop( string maLop = "",
                    string tenLop = "",
                    int siSo = 0,
                    string maKhoi = "")
        {
            MaLop = maLop;
            TenLop = tenLop;
            SiSo = siSo;
            MaKhoi = maKhoi;
        }
    }
}
