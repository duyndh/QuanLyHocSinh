using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLyHocSinh
{
    public class KhoiBUS
    {
        private KhoiADO khoiObject = new KhoiADO();
        public DataTable LayDuLieuKhoiBUS()
        {
            return khoiObject.LayDuLieuKhoiADO();
        }
    }
}
