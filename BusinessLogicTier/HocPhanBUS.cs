using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLyHocSinh
{
    public class HocPhanBUS
    {
        HocPhanADO hocPhanObject = new HocPhanADO();
        public float LayQuyDinhDiemDatMonBUS()
        {
            return hocPhanObject.LayQuyDinhDiemDatMonADO();
        }

        public void SuaQuyDinhDiemDatMonBUS(float diemDatMon)
        {
            hocPhanObject.SuaQuyDinhDiemDatMonADO(diemDatMon);
        }
    }
}
