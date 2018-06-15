using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLyHocSinh
{
    public class HocSinhBUS
    {
        private HocSinhADO hocSinhObject = new HocSinhADO();
        private LopADO lopObject = new LopADO();

        public void ThemHocSinhBUS(HocSinh hocSinh)
        {
            // Kiểm tra dữ liệu hợp lệ
            if (hocSinh.GioiTinh != "Nam" && hocSinh.GioiTinh != "Nữ")
                throw new Exception("Giới tính không hợp lệ");
            if (hocSinh.SoDT != "" && !Int32.TryParse(hocSinh.SoDT, out int check))
                throw new Exception("Số điện thoại không hợp lệ");
            if (hocSinh.MaLop != "" && !lopObject.KiemTraLopHopLeADO(hocSinh.MaLop))
                throw new Exception("Lớp không hợp lệ");

            // Quy định tuổi
            Tuple<int, int> quyDinhTuoi = hocSinhObject.LayQuyDinhTuoiADO();
            DateTime ngaySinh = DateTime.ParseExact(hocSinh.NgaySinh, "dd/MM/yyyy",
                                       System.Globalization.CultureInfo.InvariantCulture);
            hocSinh.NgaySinh = ngaySinh.ToString();
            int tuoi = DateTime.Today.Year - ngaySinh.Year;

            if (tuoi < quyDinhTuoi.Item1 || tuoi > quyDinhTuoi.Item2)
                throw new Exception("Tuổi sai quy định");

            // Quy định sĩ số tối đa
            if (hocSinh.MaLop != "")
            {
                int siSoLop = Convert.ToInt32(lopObject.LayDuLieuMotLopADO(Convert.ToInt32(hocSinh.MaLop))["SiSo"]);
                int siSoToiDa = lopObject.LayQuyDinhSiSoToiDaADO();
                if (siSoLop >= siSoToiDa)
                    throw new Exception("Lớp này đã đầy");
            }

            hocSinhObject.ThemHocSinhADO(hocSinh);
        }

        public int LayMaHocSinhMoiBUS()
        {
            return hocSinhObject.LayMaHocSinhMoiADO();
        }

        public Tuple<int, int> LayQuyDinhTuoiBUS()
        {
            return hocSinhObject.LayQuyDinhTuoiADO();
        }

        public void SuaQuyDinhTuoiBUS(Tuple<int, int> quyDinhTuoi)
        {
            hocSinhObject.SuaQuyDinhTuoiADO(quyDinhTuoi);
        }
    }
}
