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

        public DataTable LayDuLieuLopADO()
        {
            if (connection.State != ConnectionState.Open)
                connection.Open();

            SqlCommand command = new SqlCommand("LayDuLieuLop", connection);
            command.CommandType = CommandType.StoredProcedure;
            
            command.ExecuteNonQuery();

            SqlDataAdapter lopDataAdapter = new SqlDataAdapter(command);
            DataTable lopDataTable = new DataTable();
            lopDataAdapter.Fill(lopDataTable);

            connection.Close();
            return lopDataTable;
        }

        public int LayQuyDinhSiSoToiDaADO()
        {
            if (connection.State != ConnectionState.Open)
                connection.Open();

            SqlCommand command = new SqlCommand("LayQuyDinhSiSoToiDa", connection);
            command.CommandType = CommandType.StoredProcedure;

            SqlParameter outputParameter = command.Parameters.Add("@SiSoToiDa", SqlDbType.Int);
            outputParameter.Direction = ParameterDirection.Output;

            command.ExecuteNonQuery();
            connection.Close();
            return (int)outputParameter.Value;
        }

        public void SuaQuyDinhSiSoToiDaADO(int siSoToiDa)
        {
            if (connection.State != ConnectionState.Open)
                connection.Open();

            SqlCommand command = new SqlCommand("SuaQuyDinhSiSoToiDa", connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@SiSoToiDa", siSoToiDa);

            command.ExecuteNonQuery();
            connection.Close();            
        }

        public DataRow LayDuLieuMotLopADO(int maLop)
        {
            if (connection.State != ConnectionState.Open)
                connection.Open();

            SqlCommand command = new SqlCommand("LayDuLieuMotLop", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@MaLop", maLop);

            command.ExecuteNonQuery();

            SqlDataAdapter lopDataAdapter = new SqlDataAdapter(command);
            DataTable lopDataTable = new DataTable();
            lopDataAdapter.Fill(lopDataTable);

            DataRow lopDataRow = lopDataTable.Rows[0];
            
            connection.Close();
            return lopDataRow;
        }

        public void SuaThongTinLopADO(Lop lop)
        {
            if (connection.State != ConnectionState.Open)
                connection.Open();

            SqlCommand command = new SqlCommand("SuaThongTinLop", connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@MaLop", lop.MaLop);
            command.Parameters.AddWithValue("@TenLop", lop.TenLop);
            command.Parameters.AddWithValue("@SiSo", lop.SiSo);
            command.Parameters.AddWithValue("@MaKhoi", lop.MaKhoi);
            
            command.ExecuteNonQuery();
            connection.Close();
        }

        public DataTable LayDuLieuBaoCaoTongKetMonADO(int maMH, int maHK)
        {
            if (connection.State != ConnectionState.Open)
                connection.Open();

            SqlCommand command = new SqlCommand("LayDuLieuBaoCaoTongKetMon", connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@MaMH", maMH);
            command.Parameters.AddWithValue("@MaHK", maHK);
            
            command.ExecuteNonQuery();

            SqlDataAdapter baoCaoDataAdapter = new SqlDataAdapter(command);
            DataTable baoCaoDataTable = new DataTable();
            baoCaoDataAdapter.Fill(baoCaoDataTable);

            connection.Close();
            return baoCaoDataTable;
        }

        public DataTable LayDuLieuBaoCaoTongKetHocKyADO(int maHK)
        {
            if (connection.State != ConnectionState.Open)
                connection.Open();

            SqlCommand command = new SqlCommand("LayDuLieuBaoCaoTongKetHocKy", connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@MaHK", maHK);

            command.ExecuteNonQuery();

            SqlDataAdapter baoCaoDataAdapter = new SqlDataAdapter(command);
            DataTable baoCaoDataTable = new DataTable();
            baoCaoDataAdapter.Fill(baoCaoDataTable);

            connection.Close();
            return baoCaoDataTable;
        }
    }
}
