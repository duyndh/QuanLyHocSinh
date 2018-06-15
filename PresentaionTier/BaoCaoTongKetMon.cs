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
    public partial class BaoCaoTongKetMon : Form
    {
        private MonHocBUS monHocObject = new MonHocBUS();
        private DataTable monHocTable;

        private HocKyBUS hocKyObject = new HocKyBUS();
        private DataTable hocKyTable;

        private LopBUS lopObject = new LopBUS();
        private DataTable lopTable;
        
        public BaoCaoTongKetMon()
        {
            InitializeComponent();
        }

        private void BaoCaoTongKetMon_Load(object sender, EventArgs e)
        {
            // Môn học
            monHocTable = monHocObject.LayDuLieuMonHocBUS();
            monHocComboBox.DataSource = monHocTable;
            monHocComboBox.ValueMember = "MaMH";
            monHocComboBox.DisplayMember = "TenMH";

            // Học kỳ
            hocKyTable = hocKyObject.LayDuLieuHocKyBUS();
            hocKyComboBox.DataSource = hocKyTable;
            hocKyComboBox.ValueMember = "MaHK";
            hocKyComboBox.DisplayMember = "TenHK";

            lopTable = lopObject.LayDuLieuLopBUS();            

            //monHocComboBox.Text = "";
            //hocKyComboBox.Text = "";
        }
        
        private void TaoButton_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable baoCaoDataTable = lopObject.LayDuLieuBaoCaoTongKetMonBUS( Convert.ToInt32(monHocComboBox.SelectedValue),
                                                        Convert.ToInt32(hocKyComboBox.SelectedValue));
                dataGridView.DataSource = baoCaoDataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
