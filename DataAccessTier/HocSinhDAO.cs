using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyHocSinh
{
    public class HocSinhDAO: DatabaseConnection
    {
        public HocSinhDAO() : base() { }
        public void ThemHocSinhDAO(HocSinh hocSinh)
        {   
            if (connection.State != ConnectionState.Open)
                connection.Open();

            SqlCommand command = new SqlCommand("ThemHS", connection);
            command.CommandType = CommandType.StoredProcedure;
            
            //command.Parameters.Add(new SqlParameter("@MaHS", hocSinh.MaHS));
            command.Parameters.AddWithValue("@HoTen", hocSinh.HoTen);
            command.Parameters.AddWithValue("@GioiTinh", hocSinh.GioiTinh);
            command.Parameters.AddWithValue("@NgaySinh", hocSinh.NgaySinh);
            command.Parameters.AddWithValue("@DiaChi", hocSinh.DiaChi);
            command.Parameters.AddWithValue("@SoDT", hocSinh.SoDT);
            //command.Parameters.Add(new SqlParameter("@MaLop", hocSinh.MaLop));

            command.ExecuteNonQuery();
        }

        public int LayMaHocSinhMoiDAO()
        {
            if (connection.State != ConnectionState.Open)
                connection.Open();

            SqlCommand command = new SqlCommand("LayMaHocSinhMoi", connection);
            command.CommandType = CommandType.StoredProcedure;
            
            SqlParameter returnParameter = command.Parameters.Add("@ReturnValue", SqlDbType.Int);
            returnParameter.Direction = ParameterDirection.ReturnValue;

            command.ExecuteNonQuery();

            return (int)returnParameter.Value + 1;
        }
    }
}
