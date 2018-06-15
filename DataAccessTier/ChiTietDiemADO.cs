using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyHocSinh
{
    public class ChiTietDiemADO: DatabaseConnection
    {
        public DataTable LayDuLieuBangDiemMonHocADO(int maMH, int maLop, int maHK)
        {
            if (connection.State != ConnectionState.Open)
                connection.Open();

            SqlCommand command = new SqlCommand("LayDuLieuBangDiemMonHoc", connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@MaMH", maMH);
            command.Parameters.AddWithValue("@MaLop", maLop);
            command.Parameters.AddWithValue("@MaHK", maHK);

            command.ExecuteNonQuery();

            SqlDataAdapter bangDiemDataAdapter = new SqlDataAdapter(command);
            DataTable bangDiemDataTable = new DataTable();
            bangDiemDataAdapter.Fill(bangDiemDataTable);

            connection.Close();
            return bangDiemDataTable;
        }
    }
}
