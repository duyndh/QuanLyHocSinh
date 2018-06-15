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
    public partial class BaseForm : Form
    {
        public BaseForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.heThongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thayDoiQuyDinhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.taiKhoanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quanLyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tiepNhanHocSinhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lapDanhSachLopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bangDiemMonHocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.traCuuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.baoCaoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.baoCaoTongKetMonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.baoCaoTongKetHocKyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.troGiupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.heThongToolStripMenuItem,
            this.quanLyToolStripMenuItem,
            this.traCuuToolStripMenuItem,
            this.baoCaoToolStripMenuItem,
            this.troGiupToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // heThongToolStripMenuItem
            // 
            this.heThongToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thayDoiQuyDinhToolStripMenuItem,
            this.taiKhoanToolStripMenuItem,
            this.thoatToolStripMenuItem});
            resources.ApplyResources(this.heThongToolStripMenuItem, "heThongToolStripMenuItem");
            this.heThongToolStripMenuItem.Name = "heThongToolStripMenuItem";
            // 
            // thayDoiQuyDinhToolStripMenuItem
            // 
            this.thayDoiQuyDinhToolStripMenuItem.Name = "thayDoiQuyDinhToolStripMenuItem";
            resources.ApplyResources(this.thayDoiQuyDinhToolStripMenuItem, "thayDoiQuyDinhToolStripMenuItem");
            this.thayDoiQuyDinhToolStripMenuItem.Click += new System.EventHandler(this.ThayDoiQuyDinhToolStripMenuItem_Click);
            // 
            // taiKhoanToolStripMenuItem
            // 
            this.taiKhoanToolStripMenuItem.Name = "taiKhoanToolStripMenuItem";
            resources.ApplyResources(this.taiKhoanToolStripMenuItem, "taiKhoanToolStripMenuItem");
            // 
            // thoatToolStripMenuItem
            // 
            this.thoatToolStripMenuItem.Name = "thoatToolStripMenuItem";
            resources.ApplyResources(this.thoatToolStripMenuItem, "thoatToolStripMenuItem");
            // 
            // quanLyToolStripMenuItem
            // 
            this.quanLyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tiepNhanHocSinhToolStripMenuItem,
            this.lapDanhSachLopToolStripMenuItem,
            this.bangDiemMonHocToolStripMenuItem});
            resources.ApplyResources(this.quanLyToolStripMenuItem, "quanLyToolStripMenuItem");
            this.quanLyToolStripMenuItem.Name = "quanLyToolStripMenuItem";
            // 
            // tiepNhanHocSinhToolStripMenuItem
            // 
            this.tiepNhanHocSinhToolStripMenuItem.Name = "tiepNhanHocSinhToolStripMenuItem";
            resources.ApplyResources(this.tiepNhanHocSinhToolStripMenuItem, "tiepNhanHocSinhToolStripMenuItem");
            this.tiepNhanHocSinhToolStripMenuItem.Click += new System.EventHandler(this.TiepNhanHocSinhToolStripMenuItem_Click);
            // 
            // lapDanhSachLopToolStripMenuItem
            // 
            this.lapDanhSachLopToolStripMenuItem.Name = "lapDanhSachLopToolStripMenuItem";
            resources.ApplyResources(this.lapDanhSachLopToolStripMenuItem, "lapDanhSachLopToolStripMenuItem");
            // 
            // bangDiemMonHocToolStripMenuItem
            // 
            this.bangDiemMonHocToolStripMenuItem.Name = "bangDiemMonHocToolStripMenuItem";
            resources.ApplyResources(this.bangDiemMonHocToolStripMenuItem, "bangDiemMonHocToolStripMenuItem");
            this.bangDiemMonHocToolStripMenuItem.Click += new System.EventHandler(this.NhapDiemMonHocToolStripMenuItem_Click);
            // 
            // traCuuToolStripMenuItem
            // 
            resources.ApplyResources(this.traCuuToolStripMenuItem, "traCuuToolStripMenuItem");
            this.traCuuToolStripMenuItem.Name = "traCuuToolStripMenuItem";
            // 
            // baoCaoToolStripMenuItem
            // 
            this.baoCaoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.baoCaoTongKetMonToolStripMenuItem,
            this.baoCaoTongKetHocKyToolStripMenuItem});
            resources.ApplyResources(this.baoCaoToolStripMenuItem, "baoCaoToolStripMenuItem");
            this.baoCaoToolStripMenuItem.Name = "baoCaoToolStripMenuItem";
            // 
            // baoCaoTongKetMonToolStripMenuItem
            // 
            this.baoCaoTongKetMonToolStripMenuItem.Name = "baoCaoTongKetMonToolStripMenuItem";
            resources.ApplyResources(this.baoCaoTongKetMonToolStripMenuItem, "baoCaoTongKetMonToolStripMenuItem");
            this.baoCaoTongKetMonToolStripMenuItem.Click += new System.EventHandler(this.BaoCaoTongKetMonToolStripMenuItem_Click);
            // 
            // baoCaoTongKetHocKyToolStripMenuItem
            // 
            this.baoCaoTongKetHocKyToolStripMenuItem.Name = "baoCaoTongKetHocKyToolStripMenuItem";
            resources.ApplyResources(this.baoCaoTongKetHocKyToolStripMenuItem, "baoCaoTongKetHocKyToolStripMenuItem");
            this.baoCaoTongKetHocKyToolStripMenuItem.Click += new System.EventHandler(this.BaoCaoTongKetHocKyToolStripMenuItem_Click);
            // 
            // troGiupToolStripMenuItem
            // 
            resources.ApplyResources(this.troGiupToolStripMenuItem, "troGiupToolStripMenuItem");
            this.troGiupToolStripMenuItem.Name = "troGiupToolStripMenuItem";
            // 
            // BaseForm
            // 
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "BaseForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void TiepNhanHocSinhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            TiepNhanHocSinh tiepNhanHocSinhForm = new TiepNhanHocSinh();
            tiepNhanHocSinhForm.MdiParent = this;
            tiepNhanHocSinhForm.WindowState = FormWindowState.Maximized;
            tiepNhanHocSinhForm.Show();
        }

        private void BaoCaoTongKetMonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            BaoCaoTongKetMon baoCaTongKetMonForm = new BaoCaoTongKetMon();
            baoCaTongKetMonForm.MdiParent = this;
            baoCaTongKetMonForm.WindowState = FormWindowState.Maximized;
            baoCaTongKetMonForm.Show();
        }

        private void BaoCaoTongKetHocKyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            BaoCaoTongKetHocKy baoCaoTongKetMonForm = new BaoCaoTongKetHocKy();
            baoCaoTongKetMonForm.MdiParent = this;
            baoCaoTongKetMonForm.WindowState = FormWindowState.Maximized;
            baoCaoTongKetMonForm.Show();
        }

        private void ThayDoiQuyDinhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            ThayDoiQuyDinh baoCaoTongKetMonForm = new ThayDoiQuyDinh();
            baoCaoTongKetMonForm.MdiParent = this;
            baoCaoTongKetMonForm.WindowState = FormWindowState.Maximized;
            baoCaoTongKetMonForm.Show();
        }

        private void NhapDiemMonHocToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            BangDiemMonHoc bangDiemMonHocForm = new BangDiemMonHoc();
            bangDiemMonHocForm.MdiParent = this;
            bangDiemMonHocForm.WindowState = FormWindowState.Maximized;
            bangDiemMonHocForm.Show();
        }
    }
}
