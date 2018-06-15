using System;
using System.Collections;
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
    public partial class ThayDoiQuyDinh : Form
    {
        private HocSinhBUS hocSinhObject = new HocSinhBUS();

        private HocPhanBUS hocPhanObject = new HocPhanBUS();

        private LopBUS lopObject = new LopBUS();
        private DataTable lopTable;

        private KhoiBUS khoiObject = new KhoiBUS();
        private DataTable khoiTable;

        private MonHocBUS monHocObject = new MonHocBUS();
        private DataTable monHocTable;

        public ThayDoiQuyDinh()
        {
            InitializeComponent();
        }

        private void ThayDoiQuyDinh_Load(object sender, EventArgs e)
        {
            Tuple<int, int> quyDinhTuoi = hocSinhObject.LayQuyDinhTuoiBUS();
            tuoiToiThieuTextBox.Text = quyDinhTuoi.Item1.ToString();
            tuoiToiDaTextBox.Text = quyDinhTuoi.Item2.ToString();

            siSoToiDaTextBox.Text = lopObject.LayQuyDinhSiSoToiDaBUS().ToString();

            diemDatMonTextBox.Text = hocPhanObject.LayQuyDinhDiemDatMonBUS().ToString();

            lopTable = lopObject.LayDuLieuLopBUS();
            maLopComboBox.DataSource = lopTable;
            maLopComboBox.ValueMember = "MaLop";
            maLopComboBox.DisplayMember = "MaLop";

            khoiTable = khoiObject.LayDuLieuKhoiBUS();
            maKhoiComboBox.DataSource = khoiTable;
            maKhoiComboBox.ValueMember = "MaKhoi";
            maKhoiComboBox.DisplayMember = "MaKhoi";

            monHocTable = monHocObject.LayDuLieuMonHocBUS();
            maMonHocComboBox.DataSource = monHocTable;
            maMonHocComboBox.ValueMember = "MaMH";
            maMonHocComboBox.DisplayMember = "MaMH";

            maLopComboBox.Text = "";
            tenLopTextBox.Text = "";
            siSoTextBox.Text = "";
            maKhoiComboBox.Text = "";
            maMonHocComboBox.Text = "";
            tenMonHocLabel.Text = "";
        }

        private void LuuButton_Click(object sender, EventArgs e)
        {
            try
            {
                Tuple<int, int> quyDinhTuoi = Tuple.Create( Convert.ToInt32(tuoiToiThieuTextBox.Text),
                                                            Convert.ToInt32(tuoiToiDaTextBox.Text));
                hocSinhObject.SuaQuyDinhTuoiBUS(quyDinhTuoi);

                lopObject.SuaQuyDinhSiSoToiDaBUS(Convert.ToInt32(siSoToiDaTextBox.Text));

                Lop lop = new Lop(  maLopComboBox.Text,
                                    tenLopTextBox.Text,
                                    siSoTextBox.Text,
                                    maKhoiComboBox.Text);
                lopObject.SuaThongTinLopBUS(lop);

                MonHoc monHoc = new MonHoc( maMonHocComboBox.Text,
                                            tenMonHocTextBox.Text);
                monHocObject.SuaThongTinMonHoc(monHoc);

                hocPhanObject.SuaQuyDinhDiemDatMonBUS(Convert.ToInt32(diemDatMonTextBox.Text));

                MessageBox.Show("Cập nhật quy định thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void MaLopComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int maLop = Convert.ToInt32(maLopComboBox.SelectedValue);
            DataRow lopDataRow = lopObject.LayDuLieuMotLopBUS(maLop);

            tenLopTextBox.Text = lopDataRow["TenLop"].ToString();
            siSoTextBox.Text = lopDataRow["SiSo"].ToString();
            maKhoiComboBox.Text = lopDataRow["MaKhoi"].ToString();
        }

        private void MaMonHocComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int maMH = Convert.ToInt32(maMonHocComboBox.SelectedValue);
            DataRow monHocDataRow = monHocObject.LayDuLieuMotMonHocBUS(maMH);

            tenMonHocTextBox.Text = monHocDataRow["TenMH"].ToString();            
        }

        private void NhapLaiButton_Click(object sender, EventArgs e)
        {
            ThayDoiQuyDinh_Load(sender, e);
        }
    }
}
