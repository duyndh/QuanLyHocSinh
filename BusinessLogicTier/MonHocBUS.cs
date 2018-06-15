using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLyHocSinh
{
    public class MonHocBUS
    {
        private MonHocADO monHocObject = new MonHocADO();
        public DataTable LayDuLieuMonHocBUS()
        {
            return monHocObject.LayDuLieuMonHocADO();
        }

        public DataRow LayDuLieuMotMonHocBUS(int maMH)
        {
            return monHocObject.LayDuLieuMotMonHocADO(maMH);
        }

        public void SuaThongTinMonHoc(MonHoc monHoc)
        {
            monHocObject.SuaThongTinMonHoc(monHoc);
        }
    }
}
