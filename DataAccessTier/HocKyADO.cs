using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyHocSinh
{
    public class HocKyADO: DatabaseConnection
    {
        public DataTable LayDuLieuHocKyADO()
        {
            if (connection.State != ConnectionState.Open)
                connection.Open();

            SqlCommand command = new SqlCommand("LayDuLieuHocKy", connection);
            command.CommandType = CommandType.StoredProcedure;

            command.ExecuteNonQuery();
            SqlDataAdapter hocKyDataAdapter = new SqlDataAdapter(command);

            DataTable hocKyDataTable = new DataTable();

            hocKyDataAdapter.Fill(hocKyDataTable);
            connection.Close();
            return hocKyDataTable;
        }
    }
}
