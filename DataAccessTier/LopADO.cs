using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyHocSinh
{
    public class LopADO: DatabaseConnection
    {
        public DataTable LayDuLieuLopTuKhoiADO(int maKhoi)
        {
            if (connection.State != ConnectionState.Open)
                connection.Open();

            SqlCommand command = new SqlCommand("LayDuLieuLopTuKhoi", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@MaKhoi", maKhoi);

            command.ExecuteNonQuery();

            SqlDataAdapter lopDataAdapter = new SqlDataAdapter(command);
            DataTable lopDataTable = new DataTable();
            lopDataAdapter.Fill(lopDataTable);

            connection.Close();
            return lopDataTable;
        }

        public bool KiemTraLopHopLeADO(string maLop)
        {
            if (connection.State != ConnectionState.Open)
                connection.Open();

            SqlCommand command = new SqlCommand("KiemTraLopHopLe", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@MaLop", maLop);

            command.ExecuteNonQuery();

            SqlDataAdapter lopDataAdapter = new SqlDataAdapter(command);
            DataTable lopDataTable = new DataTable();
            lopDataAdapter.Fill(lopDataTable);

            connection.Close();

            if (lopDataTable.Rows.Count != 1)
                return false;
            return true;
        }
    }
}
