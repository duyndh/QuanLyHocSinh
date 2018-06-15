using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyHocSinh
{
    public class HocSinhADO: DatabaseConnection
    {
        public void ThemHocSinhADO(HocSinh hocSinh)
        {   
            if (connection.State != ConnectionState.Open)
                connection.Open();

            SqlCommand command = new SqlCommand("ThemHocSinh", connection);
            command.CommandType = CommandType.StoredProcedure;
            
            //command.Parameters.Add(new SqlParameter("@MaHS", hocSinh.MaHS));
            command.Parameters.AddWithValue("@HoTen", hocSinh.HoTen);
            command.Parameters.AddWithValue("@GioiTinh", hocSinh.GioiTinh);
            command.Parameters.AddWithValue("@NgaySinh", hocSinh.NgaySinh);
            command.Parameters.AddWithValue("@DiaChi", hocSinh.DiaChi);
            command.Parameters.AddWithValue("@SoDT", hocSinh.SoDT);
            if (hocSinh.MaLop == "")
                command.Parameters.AddWithValue("@MaLop", DBNull.Value);
            else
                command.Parameters.AddWithValue("@MaLop", hocSinh.MaLop);          

            command.ExecuteNonQuery();
            connection.Close();
        }

        public int LayMaHocSinhMoiADO()
        {
            if (connection.State != ConnectionState.Open)
                connection.Open();

            SqlCommand command = new SqlCommand("LayMaHocSinhMoi", connection);
            command.CommandType = CommandType.StoredProcedure;
            
            SqlParameter outputParameter = command.Parameters.Add("@MaHS", SqlDbType.Int);
            outputParameter.Direction = ParameterDirection.Output;

            command.ExecuteNonQuery();
            connection.Close();
            return (int)outputParameter.Value + 1;
        }

        public Tuple<int, int> LayQuyDinhTuoiADO()
        {
            if (connection.State != ConnectionState.Open)
                connection.Open();

            SqlCommand command = new SqlCommand("LayQuyDinhTuoi", connection);
            command.CommandType = CommandType.StoredProcedure;

            SqlParameter outputParameter1 = command.Parameters.Add("@TuoiMin", SqlDbType.Int);
            outputParameter1.Direction = ParameterDirection.Output;
            SqlParameter outputParameter2 = command.Parameters.Add("@TuoiMax", SqlDbType.Int);
            outputParameter2.Direction = ParameterDirection.Output;

            command.ExecuteNonQuery();
            connection.Close();
            return Tuple.Create((int)outputParameter1.Value, (int)outputParameter2.Value);
        }

        public void SuaQuyDinhTuoiADO(Tuple<int, int> quyDinhTuoi)
        {
            if (connection.State != ConnectionState.Open)
                connection.Open();

            SqlCommand command = new SqlCommand("SuaQuyDinhTuoi", connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@TuoiMin", quyDinhTuoi.Item1);
            command.Parameters.AddWithValue("@TuoiMax", quyDinhTuoi.Item2);

            command.ExecuteNonQuery();
            connection.Close();            
        }
    }
}
