using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyHocSinh
{
    public partial class TiepNhanHocSinh : Form
    {
        private HocSinhBUS hocSinhObject = new HocSinhBUS();
        //private DataTable hocSinhTable;
        public TiepNhanHocSinh()
        {
            InitializeComponent();
        }

        private void TiepNhanHocSinh_Load(object sender, EventArgs e)
        {
            maHocSinhTextBox.Text = hocSinhObject.LayMaHocSinhMoiBUS().ToString();
            hoTenTextBox.ResetText();
            gioiTinhComboBox.ResetText();
            ngaySinhDateTimePicker.ResetText();
            diaChiTextBox.ResetText();
            soDienThoaiTextBox.ResetText();
        }

        private void LuuButton_Click(object sender, EventArgs e)
        {
            try
            {
                HocSinh hocsinh = new HocSinh(Convert.ToInt32(maHocSinhTextBox.Text),
                                hoTenTextBox.Text,
                                gioiTinhComboBox.Text,
                                ngaySinhDateTimePicker.Text,
                                diaChiTextBox.Text,
                                soDienThoaiTextBox.Text,
                                lopComboBox.Text);

                hocSinhObject.ThemHocSinhBUS(hocsinh);
                MessageBox.Show("Thêm học sinh thành công");

                TiepNhanHocSinh_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //if (command.ExecuteNonQuery() > 0)
            //{
            //    MessageBox.Show("Thêm học sinh thành công");
            //}
        }

        private void nhapLaiButton_Click(object sender, EventArgs e)
        {
            TiepNhanHocSinh_Load(sender, e);
            khoiComboBox.ResetText();
            khoiComboBox.ResetText();
            lopComboBox.ResetText();
        }
    }
}
