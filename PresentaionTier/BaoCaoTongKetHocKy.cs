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
    public partial class BaoCaoTongKetHocKy : Form
    {
        private HocKyBUS hocKyObject = new HocKyBUS();
        private DataTable hocKyTable;

        private LopBUS lopObject = new LopBUS();
        private DataTable lopTable;

        public BaoCaoTongKetHocKy()
        {
            InitializeComponent();
        }

        private void BaoCaoTongKetHocKy_Load(object sender, EventArgs e)
        {          
            // Học kỳ
            hocKyTable = hocKyObject.LayDuLieuHocKyBUS();
            hocKyComboBox.DataSource = hocKyTable;
            hocKyComboBox.ValueMember = "MaHK";
            hocKyComboBox.DisplayMember = "TenHK";

            lopTable = lopObject.LayDuLieuLopBUS();

            //hocKyComboBox.Text = "";
        }

        private void TaoBaoCaoButton_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable baoCaoDataTable = lopObject.LayDuLieuBaoCaoTongKetHocKyBUS(Convert.ToInt32(hocKyComboBox.SelectedValue));
                dataGridView.DataSource = baoCaoDataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
