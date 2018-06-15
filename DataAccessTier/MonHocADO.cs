using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyHocSinh
{
    public class MonHocADO: DatabaseConnection
    {
        public DataTable LayDuLieuMonHocADO()
        {
            if (connection.State != ConnectionState.Open)
                connection.Open();

            SqlCommand command = new SqlCommand("LayDuLieuMonHoc", connection);
            command.CommandType = CommandType.StoredProcedure;

            command.ExecuteNonQuery();
            SqlDataAdapter monHocDataAdapter = new SqlDataAdapter(command);

            DataTable monHocDataTable = new DataTable();

            monHocDataAdapter.Fill(monHocDataTable);
            connection.Close();
            return monHocDataTable;
        }

        public DataRow LayDuLieuMotMonHocADO(int maMH)
        {
            if (connection.State != ConnectionState.Open)
                connection.Open();

            SqlCommand command = new SqlCommand("LayDuLieuMotMonHoc", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@MaMH", maMH);

            command.ExecuteNonQuery();

            SqlDataAdapter monHocDataAdapter = new SqlDataAdapter(command);
            DataTable monHocDataTable = new DataTable();
            monHocDataAdapter.Fill(monHocDataTable);

            DataRow monHocDataRow = monHocDataTable.Rows[0];

            connection.Close();
            return monHocDataRow;
        }

        public void SuaThongTinMonHoc(MonHoc monHoc)
        {
            if (connection.State != ConnectionState.Open)
                connection.Open();

            SqlCommand command = new SqlCommand("SuaThongTinMonHoc", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@MaMH", monHoc.MaMH);
            command.Parameters.AddWithValue("@TenMH", monHoc.TenMH);

            command.ExecuteNonQuery();
            connection.Close();
        }

        //public DataTable LayDuLieuBaoCaoTongKetMon()
        //{
        //}
    }
}
