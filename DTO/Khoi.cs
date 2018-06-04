using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    class Khoi
    {
        private string MaKhoi { get; set; }
        private string TenKhoi { get; set; }
        private int SoLop { get; set; }

        public Khoi(string maKhoi = "",
                    string tenKhoi = "",
                    int soLop = 0)
        {
            MaKhoi = maKhoi;
            TenKhoi = tenKhoi;
            SoLop = soLop;
        }
    }
}
