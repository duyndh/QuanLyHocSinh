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
    public partial class BangDiemMonHoc : Form
    {
        private MonHocBUS monHocObject = new MonHocBUS();
        private DataTable monHocTable;

        private HocKyBUS hocKyObject = new HocKyBUS();
        private DataTable hocKyTable;

        private LopBUS lopObject = new LopBUS();
        private DataTable lopTable;

        private ChiTietDiemBUS chiTietDiemObject = new ChiTietDiemBUS();
        
        public BangDiemMonHoc()
        {
            InitializeComponent();
        }

        private void BangDiemMonHoc_Load(object sender, EventArgs e)
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

            // Lớp
            lopTable = lopObject.LayDuLieuLopBUS();
            lopComboBox.DataSource = lopTable;
            lopComboBox.ValueMember = "MaLop";
            lopComboBox.DisplayMember = "TenLop";
        }

        private void TaoBaoCaoButton_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable bangDiemDataTable = chiTietDiemObject.LayDuLieuBangDiemMonHocBUS(
                                                Convert.ToInt32(monHocComboBox.SelectedValue),
                                                Convert.ToInt32(lopComboBox.SelectedValue),
                                                Convert.ToInt32(hocKyComboBox.SelectedValue));

                dataGridView.DataSource = bangDiemDataTable;     
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
