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

namespace Demo_QLHS
{
    public partial class frmThaydoiQuiDinh : Form
    {
        public frmThaydoiQuiDinh()
        {
            InitializeComponent();
        }

        private void frmThaydoiQuiDinh_Load(object sender, EventArgs e)
        {

        }

        private void btnSiSo_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("UPDATE QUYDINH SET SiSoCanDuoi = @siSoCanDuoi, SiSoCanTren = @siSoCanTren");
            cmd.Parameters.Add("siSoCanDuoi", SqlDbType.Int).Value = siSoCanDuoi;
            cmd.Parameters.Add("siSoCanTren", SqlDbType.Int).Value = siSoCanTren;

            m_QuyDinhData.Load(cmd);
        }

        private void btnTuoi_Click(object sender, EventArgs e)
        {

        }
    }
}
