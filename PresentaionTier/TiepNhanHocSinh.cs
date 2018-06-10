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

        private KhoiBUS khoiObject = new KhoiBUS();
        private DataTable khoiTable;

        private LopBUS lopObject = new LopBUS();
        private DataTable lopTable;

        public TiepNhanHocSinh()
        {
            InitializeComponent();
        }

        private void TiepNhanHocSinh_Load(object sender, EventArgs e)
        {
            // Khoi
            khoiTable = khoiObject.LayDuLieuKhoiBUS();
            khoiComboBox.DataSource = khoiTable;
            khoiComboBox.ValueMember = "MaKhoi";
            khoiComboBox.DisplayMember = "TenKhoi";

            // Lop
            KhoiComboBox_SelectionChangeCommitted(sender, e);

            maHocSinhTextBox.Text = hocSinhObject.LayMaHocSinhMoiBUS().ToString();
            hoTenTextBox.ResetText();
            gioiTinhComboBox.Text = "Nam";
            ngaySinhDateTimePicker.ResetText();
            diaChiTextBox.ResetText();
            soDienThoaiTextBox.ResetText();

            khoiComboBox.Text = "";
            lopComboBox.Text = "";
        }
        
        private void KhoiComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int maKhoi = Convert.ToInt32(khoiComboBox.SelectedValue);
            lopTable = lopObject.LayDuLieuLopTuKhoiBUS(maKhoi);

            lopComboBox.DataSource = lopTable;
            lopComboBox.ValueMember = "MaLop";
            lopComboBox.DisplayMember = "TenLop";
        }

        private void NhapLaiButton_Click(object sender, EventArgs e)
        {
            TiepNhanHocSinh_Load(sender, e);
        }

        private void LuuButton_Click(object sender, EventArgs e)
        {
            try
            {
                
                HocSinh hocSinh = new HocSinh(  maHocSinhTextBox.Text,
                                                hoTenTextBox.Text,
                                                gioiTinhComboBox.Text,
                                                ngaySinhDateTimePicker.Text,
                                                diaChiTextBox.Text,
                                                soDienThoaiTextBox.Text,
                                                lopComboBox.Text == "" ? "0" : lopComboBox.SelectedValue.ToString());

                hocSinhObject.ThemHocSinhBUS(hocSinh);
                MessageBox.Show("Thêm học sinh thành công");

                TiepNhanHocSinh_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
