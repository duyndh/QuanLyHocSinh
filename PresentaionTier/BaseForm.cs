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
            this.quanLyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tiepNhanHocSinhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lapDanhSachLopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhapDiemMonHocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.traCuuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.baoCaoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.troGiupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.heThongToolStripMenuItem,
            this.quanLyToolStripMenuItem,
            this.traCuuToolStripMenuItem,
            this.baoCaoToolStripMenuItem,
            this.troGiupToolStripMenuItem});
            this.menuStrip1.Name = "menuStrip1";
            // 
            // heThongToolStripMenuItem
            // 
            resources.ApplyResources(this.heThongToolStripMenuItem, "heThongToolStripMenuItem");
            this.heThongToolStripMenuItem.Name = "heThongToolStripMenuItem";
            // 
            // quanLyToolStripMenuItem
            // 
            resources.ApplyResources(this.quanLyToolStripMenuItem, "quanLyToolStripMenuItem");
            this.quanLyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tiepNhanHocSinhToolStripMenuItem,
            this.lapDanhSachLopToolStripMenuItem,
            this.nhapDiemMonHocToolStripMenuItem});
            this.quanLyToolStripMenuItem.Name = "quanLyToolStripMenuItem";
            // 
            // tiepNhanHocSinhToolStripMenuItem
            // 
            resources.ApplyResources(this.tiepNhanHocSinhToolStripMenuItem, "tiepNhanHocSinhToolStripMenuItem");
            this.tiepNhanHocSinhToolStripMenuItem.Name = "tiepNhanHocSinhToolStripMenuItem";
            this.tiepNhanHocSinhToolStripMenuItem.Click += new System.EventHandler(this.TiepNhanHocSinhToolStripMenuItem_Click);
            // 
            // lapDanhSachLopToolStripMenuItem
            // 
            resources.ApplyResources(this.lapDanhSachLopToolStripMenuItem, "lapDanhSachLopToolStripMenuItem");
            this.lapDanhSachLopToolStripMenuItem.Name = "lapDanhSachLopToolStripMenuItem";
            // 
            // nhapDiemMonHocToolStripMenuItem
            // 
            resources.ApplyResources(this.nhapDiemMonHocToolStripMenuItem, "nhapDiemMonHocToolStripMenuItem");
            this.nhapDiemMonHocToolStripMenuItem.Name = "nhapDiemMonHocToolStripMenuItem";
            // 
            // traCuuToolStripMenuItem
            // 
            resources.ApplyResources(this.traCuuToolStripMenuItem, "traCuuToolStripMenuItem");
            this.traCuuToolStripMenuItem.Name = "traCuuToolStripMenuItem";
            // 
            // baoCaoToolStripMenuItem
            // 
            resources.ApplyResources(this.baoCaoToolStripMenuItem, "baoCaoToolStripMenuItem");
            this.baoCaoToolStripMenuItem.Name = "baoCaoToolStripMenuItem";
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
    }
}
