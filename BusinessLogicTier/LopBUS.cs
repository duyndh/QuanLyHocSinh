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
    }
}
