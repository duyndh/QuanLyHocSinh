using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyHocSinh
{
    public class KhoiADO: DatabaseConnection
    {
        public DataTable LayDuLieuKhoiADO()
        {
            if (connection.State != ConnectionState.Open)
                connection.Open();

            SqlCommand command = new SqlCommand("LayDuLieuKhoi", connection);
            command.CommandType = CommandType.StoredProcedure;

            command.ExecuteNonQuery();
            SqlDataAdapter khoiDataAdapter = new SqlDataAdapter(command);

            DataTable khoiDataTable = new DataTable();

            khoiDataAdapter.Fill(khoiDataTable);
            connection.Close();
            return khoiDataTable;
        }
    }
}
