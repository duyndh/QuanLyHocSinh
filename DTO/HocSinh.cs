using System;

namespace DTO
{
    public class HocSinh
    {
        private int MaHS { get; set; }
        private string HoTen { get; set; }
        private string GioiTinh { get; set; }
        private string NgaySinh { get; set; }
        private string DiaChi { get; set; }
        private string SoDT { get; set; }
        private string MaLop { get; set; }

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
