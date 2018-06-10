using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHocSinh
{
    public class HocSinhBUS
    {
        private HocSinhADO hocSinhObject = new HocSinhADO();
        private LopADO lopObject = new LopADO();
        public void ThemHocSinhBUS(HocSinh hocSinh)
        {
            if (hocSinh.GioiTinh != "Nam" && hocSinh.GioiTinh != "Nữ")
                throw new Exception("Giới tính không hợp lệ");
            if (hocSinh.SoDT != "" && !Int32.TryParse(hocSinh.SoDT, out int check))
                throw new Exception("Số điện thoại không hợp lệ");
            if (hocSinh.MaLop != "0" && !lopObject.KiemTraLopHopLeADO(hocSinh.MaLop))
                throw new Exception("Lớp không hợp lệ");
            hocSinhObject.ThemHocSinhADO(hocSinh);
        }

        public int LayMaHocSinhMoiBUS()
        {
            return hocSinhObject.LayMaHocSinhMoiDAO();
        }
    }
}
