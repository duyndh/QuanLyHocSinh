using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace QuanLyHocSinh
{
    public class DatabaseConnection
    {
        protected SqlConnection connection;

        public DatabaseConnection()
        {
            string connectionString = "Data Source=DESKTOP-PEPBE5U;Initial Catalog=QuanLyHocSinh;Integrated Security=True";
            connection = new SqlConnection(connectionString);
            //connection.Open();

            //SqlCommand command = new SqlCommand("select * from HOCSINH", connection);
            //command.CommandType = CommandType.Text;
            //SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            //DataTable dataTable = new DataTable();
            //dataAdapter.Fill(dataTable);

        }
    }
}
