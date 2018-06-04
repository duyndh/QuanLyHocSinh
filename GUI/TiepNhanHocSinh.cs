using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp
{
    public partial class TiepNhanHocSinh : Form
    {
        private string connectionString = "Data Source=DESKTOP-PEPBE5U;Initial Catalog=QuanLyHocSinh;Integrated Security=True";
        private SqlConnection connection;
        
        public void ConnectDatabase()
        {
            connection = new SqlConnection(connectionString);
            connection.Open();
        }
       
        public void DisconnectDatabase()
        {
            
        }

        public TiepNhanHocSinh()
        {
            InitializeComponent();
        }

        private void TiepNhanHocSinh_Load(object sender, EventArgs e)
        {
            ConnectDatabase();

            //SqlCommand command = new SqlCommand("select * from HOCSINH", connection);
            //command.CommandType = CommandType.Text;
            //SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            //DataTable dataTable = new DataTable();
            //dataAdapter.Fill(dataTable);


        }

        private void luuButton_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("ThemHS", connection);
            command.CommandType = CommandType.StoredProcedure;

            SqlParameter parameter;
            parameter = new SqlParameter("@MaHS", maHocSinhTextBox.Text);
            command.Parameters.Add(parameter);
            parameter = new SqlParameter("@HoTen", hoTenTextBox.Text);
            command.Parameters.Add(parameter);
            parameter = new SqlParameter("@GioiTinh", gioiTinhComboBox.Text);
            command.Parameters.Add(parameter);
            parameter = new SqlParameter("@NgaySinh", ngaySinhDateTimePicker.Text);
            command.Parameters.Add(parameter);
            parameter = new SqlParameter("@DiaChi", diaChiTextBox.Text);
            command.Parameters.Add(parameter);
            parameter = new SqlParameter("@SoDT", soDienThoaiTextBox.Text);
            command.Parameters.Add(parameter);

            parameter = new SqlParameter("@MaLop", lopComboBox.Text);
            command.Parameters.Add(parameter);

            if (command.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Thêm học sinh thành công");
            }
        }
    }
}
