using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyHocSinh
{
    public class HocPhanADO: DatabaseConnection
    {
        public float LayQuyDinhDiemDatMonADO()
        {
            if (connection.State != ConnectionState.Open)
                connection.Open();

            SqlCommand command = new SqlCommand("LayQuyDinhDiemDatMon", connection);
            command.CommandType = CommandType.StoredProcedure;

            SqlParameter outputParameter = command.Parameters.Add("@DiemDatMon", SqlDbType.Int);
            outputParameter.Direction = ParameterDirection.Output;

            command.ExecuteNonQuery();
            connection.Close();
            return (int)outputParameter.Value;
        }

        public void SuaQuyDinhDiemDatMonADO(float diemDatMon)
        {
            if (connection.State != ConnectionState.Open)
                connection.Open();

            SqlCommand command = new SqlCommand("SuaQuyDinhDiemDatMon", connection);
            command.CommandType = CommandType.StoredProcedure;

            SqlParameter outputParameter = command.Parameters.AddWithValue("@DiemDatMon", diemDatMon);
            
            command.ExecuteNonQuery();
            connection.Close();            
        }
    }
}
