using System;

namespace QuanLyHocSinh
{
    public class HocSinh
    {
        public int MaHS { get; set; }
        public string HoTen { get; set; }
        public string GioiTinh { get; set; }
        public string NgaySinh { get; set; }
        public string DiaChi { get; set; }
        public string SoDT { get; set; }
        public string MaLop { get; set; }

        public HocSinh( int maHS = 0, 
                        string hoTen = "", 
                        string gioiTinh = "", 
                        string ngaySinh = "", 
                        string diaChi = "", 
                        string soDT = "", 
                        string maLop = "")
        {
            MaHS = maHS;
            HoTen = hoTen;
            GioiTinh = gioiTinh;
            NgaySinh = ngaySinh;
            DiaChi = diaChi;
            SoDT = soDT;
            MaLop = maLop;
        }
     }
}
