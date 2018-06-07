using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHocSinh
{
    public class HocSinhBUS
    {
        private HocSinhDAO hocSinhObject = new HocSinhDAO();
        public HocSinhBUS() { }
        public void ThemHocSinhBUS(HocSinh hocSinh)
        {
            hocSinhObject.ThemHocSinhDAO(hocSinh);
        }

        public int LayMaHocSinhMoiBUS()
        {
            return hocSinhObject.LayMaHocSinhMoiDAO();
        }
    }
}
