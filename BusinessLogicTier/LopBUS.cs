using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLyHocSinh
{
    public class LopBUS
    {
        private LopADO lopObject = new LopADO();
        public DataTable LayDuLieuLopTuKhoiBUS(int maKhoi)
        {
            return lopObject.LayDuLieuLopTuKhoiADO(maKhoi);
        }

        public DataTable LayDuLieuLopBUS()
        {
            return lopObject.LayDuLieuLopADO();
        }

        public int LayQuyDinhSiSoToiDaBUS()
        {
            return lopObject.LayQuyDinhSiSoToiDaADO();
        }

        public void SuaQuyDinhSiSoToiDaBUS(int siSoToiDa)
        {
            lopObject.SuaQuyDinhSiSoToiDaADO(siSoToiDa);
        }

        public DataRow LayDuLieuMotLopBUS(int maLop)
        {
            return lopObject.LayDuLieuMotLopADO(maLop);
        }

        public void SuaThongTinLopBUS(Lop lop)
        {
            lopObject.SuaThongTinLopADO(lop);
        }

        public DataTable LayDuLieuBaoCaoTongKetMonBUS(int maMH, int maHK)
        {
            return lopObject.LayDuLieuBaoCaoTongKetMonADO(maMH, maHK);
        }

        public DataTable LayDuLieuBaoCaoTongKetHocKyBUS(int maHK)
        {
            return lopObject.LayDuLieuBaoCaoTongKetHocKyADO(maHK);
        }
    }
}
