using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLyHocSinh
{
    public class HocKyBUS
    {
        private HocKyADO hocKyObject = new HocKyADO();
        public DataTable LayDuLieuHocKyBUS()
        {
            return hocKyObject.LayDuLieuHocKyADO();
        }
    }
}
