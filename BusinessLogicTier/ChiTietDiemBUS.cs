using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLyHocSinh
{
    public class ChiTietDiemBUS
    {
        private ChiTietDiemADO chiTietDiemObject = new ChiTietDiemADO();
        public DataTable LayDuLieuBangDiemMonHocBUS(int maMH, int maLop, int maHK)
        {
            return chiTietDiemObject.LayDuLieuBangDiemMonHocADO(maMH, maLop, maHK);
        }
    }
}
