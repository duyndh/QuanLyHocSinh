using System.Windows.Forms;

namespace QuanLyHocSinh
{
    partial class TiepNhanHocSinh
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.thongTinHocSinhPanel = new System.Windows.Forms.Panel();
            this.maHocSinhLabel = new System.Windows.Forms.Label();
            this.maHocSinhTextBox = new System.Windows.Forms.TextBox();
            this.hoTenLabel = new System.Windows.Forms.Label();
            this.hoTenTextBox = new System.Windows.Forms.TextBox();
            this.gioiTinhLabel = new System.Windows.Forms.Label();
            this.gioiTinhComboBox = new System.Windows.Forms.ComboBox();
            this.ngaySinhLabel = new System.Windows.Forms.Label();
            this.ngaySinhDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.diaChiLabel = new System.Windows.Forms.Label();
            this.diaChiTextBox = new System.Windows.Forms.TextBox();
            this.soDienThoaiLabel = new System.Windows.Forms.Label();
            this.soDienThoaiTextBox = new System.Windows.Forms.TextBox();
            this.thongTinLopHocPanel = new System.Windows.Forms.Panel();
            this.lopComboBox = new System.Windows.Forms.ComboBox();
            this.khoiComboBox = new System.Windows.Forms.ComboBox();
            this.lopLabel = new System.Windows.Forms.Label();
            this.khoiLabel = new System.Windows.Forms.Label();
            this.thongTinHocSinhLabel = new System.Windows.Forms.Label();
            this.thongTinLopHocLabel = new System.Windows.Forms.Label();
            this.nhapLaiButton = new System.Windows.Forms.Button();
            this.luuButton = new System.Windows.Forms.Button();
            this.formLabel = new System.Windows.Forms.Label();
            this.thongTinHocSinhPanel.SuspendLayout();
            this.thongTinLopHocPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // thongTinHocSinhPanel
            // 
            this.thongTinHocSinhPanel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.thongTinHocSinhPanel.Controls.Add(this.maHocSinhLabel);
            this.thongTinHocSinhPanel.Controls.Add(this.maHocSinhTextBox);
            this.thongTinHocSinhPanel.Controls.Add(this.hoTenLabel);
            this.thongTinHocSinhPanel.Controls.Add(this.hoTenTextBox);
            this.thongTinHocSinhPanel.Controls.Add(this.gioiTinhLabel);
            this.thongTinHocSinhPanel.Controls.Add(this.gioiTinhComboBox);
            this.thongTinHocSinhPanel.Controls.Add(this.ngaySinhLabel);
            this.thongTinHocSinhPanel.Controls.Add(this.ngaySinhDateTimePicker);
            this.thongTinHocSinhPanel.Controls.Add(this.diaChiLabel);
            this.thongTinHocSinhPanel.Controls.Add(this.diaChiTextBox);
            this.thongTinHocSinhPanel.Controls.Add(this.soDienThoaiLabel);
            this.thongTinHocSinhPanel.Controls.Add(this.soDienThoaiTextBox);
            this.thongTinHocSinhPanel.Location = new System.Drawing.Point(15, 105);
            this.thongTinHocSinhPanel.Margin = new System.Windows.Forms.Padding(4);
            this.thongTinHocSinhPanel.Name = "thongTinHocSinhPanel";
            this.thongTinHocSinhPanel.Size = new System.Drawing.Size(1234, 318);
            this.thongTinHocSinhPanel.TabIndex = 1;
            // 
            // maHocSinhLabel
            // 
            this.maHocSinhLabel.AutoSize = true;
            this.maHocSinhLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maHocSinhLabel.Location = new System.Drawing.Point(52, 22);
            this.maHocSinhLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.maHocSinhLabel.Name = "maHocSinhLabel";
            this.maHocSinhLabel.Size = new System.Drawing.Size(100, 20);
            this.maHocSinhLabel.TabIndex = 1;
            this.maHocSinhLabel.Text = "Mã học sinh";
            // 
            // maHocSinhTextBox
            // 
            this.maHocSinhTextBox.Enabled = false;
            this.maHocSinhTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maHocSinhTextBox.Location = new System.Drawing.Point(58, 46);
            this.maHocSinhTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.maHocSinhTextBox.Name = "maHocSinhTextBox";
            this.maHocSinhTextBox.Size = new System.Drawing.Size(124, 27);
            this.maHocSinhTextBox.TabIndex = 0;
            // 
            // hoTenLabel
            // 
            this.hoTenLabel.AutoSize = true;
            this.hoTenLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hoTenLabel.Location = new System.Drawing.Point(54, 92);
            this.hoTenLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.hoTenLabel.Name = "hoTenLabel";
            this.hoTenLabel.Size = new System.Drawing.Size(59, 20);
            this.hoTenLabel.TabIndex = 3;
            this.hoTenLabel.Text = "Họ tên";
            // 
            // hoTenTextBox
            // 
            this.hoTenTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hoTenTextBox.Location = new System.Drawing.Point(58, 116);
            this.hoTenTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.hoTenTextBox.Name = "hoTenTextBox";
            this.hoTenTextBox.Size = new System.Drawing.Size(533, 27);
            this.hoTenTextBox.TabIndex = 1;
            // 
            // gioiTinhLabel
            // 
            this.gioiTinhLabel.AutoSize = true;
            this.gioiTinhLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gioiTinhLabel.Location = new System.Drawing.Point(753, 92);
            this.gioiTinhLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gioiTinhLabel.Name = "gioiTinhLabel";
            this.gioiTinhLabel.Size = new System.Drawing.Size(71, 20);
            this.gioiTinhLabel.TabIndex = 5;
            this.gioiTinhLabel.Text = "Giới tính";
            // 
            // gioiTinhComboBox
            // 
            this.gioiTinhComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gioiTinhComboBox.FormattingEnabled = true;
            this.gioiTinhComboBox.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.gioiTinhComboBox.Location = new System.Drawing.Point(757, 115);
            this.gioiTinhComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.gioiTinhComboBox.Name = "gioiTinhComboBox";
            this.gioiTinhComboBox.Size = new System.Drawing.Size(150, 28);
            this.gioiTinhComboBox.TabIndex = 2;
            // 
            // ngaySinhLabel
            // 
            this.ngaySinhLabel.AutoSize = true;
            this.ngaySinhLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ngaySinhLabel.Location = new System.Drawing.Point(1009, 92);
            this.ngaySinhLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ngaySinhLabel.Name = "ngaySinhLabel";
            this.ngaySinhLabel.Size = new System.Drawing.Size(83, 20);
            this.ngaySinhLabel.TabIndex = 7;
            this.ngaySinhLabel.Text = "Ngày sinh";
            // 
            // ngaySinhDateTimePicker
            // 
            this.ngaySinhDateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.ngaySinhDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ngaySinhDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ngaySinhDateTimePicker.Location = new System.Drawing.Point(1013, 116);
            this.ngaySinhDateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.ngaySinhDateTimePicker.Name = "ngaySinhDateTimePicker";
            this.ngaySinhDateTimePicker.Size = new System.Drawing.Size(136, 27);
            this.ngaySinhDateTimePicker.TabIndex = 3;
            // 
            // diaChiLabel
            // 
            this.diaChiLabel.AutoSize = true;
            this.diaChiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diaChiLabel.Location = new System.Drawing.Point(52, 165);
            this.diaChiLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.diaChiLabel.Name = "diaChiLabel";
            this.diaChiLabel.Size = new System.Drawing.Size(61, 20);
            this.diaChiLabel.TabIndex = 9;
            this.diaChiLabel.Text = "Địa chỉ";
            // 
            // diaChiTextBox
            // 
            this.diaChiTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diaChiTextBox.Location = new System.Drawing.Point(58, 189);
            this.diaChiTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.diaChiTextBox.Name = "diaChiTextBox";
            this.diaChiTextBox.Size = new System.Drawing.Size(702, 27);
            this.diaChiTextBox.TabIndex = 4;
            // 
            // soDienThoaiLabel
            // 
            this.soDienThoaiLabel.AutoSize = true;
            this.soDienThoaiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soDienThoaiLabel.Location = new System.Drawing.Point(54, 242);
            this.soDienThoaiLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.soDienThoaiLabel.Name = "soDienThoaiLabel";
            this.soDienThoaiLabel.Size = new System.Drawing.Size(106, 20);
            this.soDienThoaiLabel.TabIndex = 11;
            this.soDienThoaiLabel.Text = "Số điện thoại";
            // 
            // soDienThoaiTextBox
            // 
            this.soDienThoaiTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soDienThoaiTextBox.Location = new System.Drawing.Point(58, 266);
            this.soDienThoaiTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.soDienThoaiTextBox.Name = "soDienThoaiTextBox";
            this.soDienThoaiTextBox.Size = new System.Drawing.Size(279, 27);
            this.soDienThoaiTextBox.TabIndex = 5;
            // 
            // thongTinLopHocPanel
            // 
            this.thongTinLopHocPanel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.thongTinLopHocPanel.Controls.Add(this.lopComboBox);
            this.thongTinLopHocPanel.Controls.Add(this.khoiComboBox);
            this.thongTinLopHocPanel.Controls.Add(this.lopLabel);
            this.thongTinLopHocPanel.Controls.Add(this.khoiLabel);
            this.thongTinLopHocPanel.Location = new System.Drawing.Point(15, 467);
            this.thongTinLopHocPanel.Margin = new System.Windows.Forms.Padding(4);
            this.thongTinLopHocPanel.Name = "thongTinLopHocPanel";
            this.thongTinLopHocPanel.Size = new System.Drawing.Size(1234, 93);
            this.thongTinLopHocPanel.TabIndex = 2;
            // 
            // lopComboBox
            // 
            this.lopComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lopComboBox.FormattingEnabled = true;
            this.lopComboBox.Location = new System.Drawing.Point(441, 45);
            this.lopComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.lopComboBox.Name = "lopComboBox";
            this.lopComboBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lopComboBox.Size = new System.Drawing.Size(150, 28);
            this.lopComboBox.TabIndex = 7;
            // 
            // khoiComboBox
            // 
            this.khoiComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.khoiComboBox.FormattingEnabled = true;
            this.khoiComboBox.Location = new System.Drawing.Point(58, 45);
            this.khoiComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.khoiComboBox.Name = "khoiComboBox";
            this.khoiComboBox.Size = new System.Drawing.Size(150, 28);
            this.khoiComboBox.TabIndex = 6;
            this.khoiComboBox.SelectionChangeCommitted += new System.EventHandler(this.KhoiComboBox_SelectionChangeCommitted);
            // 
            // lopLabel
            // 
            this.lopLabel.AutoSize = true;
            this.lopLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lopLabel.Location = new System.Drawing.Point(436, 21);
            this.lopLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lopLabel.Name = "lopLabel";
            this.lopLabel.Size = new System.Drawing.Size(37, 20);
            this.lopLabel.TabIndex = 17;
            this.lopLabel.Text = "Lớp";
            // 
            // khoiLabel
            // 
            this.khoiLabel.AutoSize = true;
            this.khoiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.khoiLabel.Location = new System.Drawing.Point(52, 21);
            this.khoiLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.khoiLabel.Name = "khoiLabel";
            this.khoiLabel.Size = new System.Drawing.Size(42, 20);
            this.khoiLabel.TabIndex = 15;
            this.khoiLabel.Text = "Khối";
            // 
            // thongTinHocSinhLabel
            // 
            this.thongTinHocSinhLabel.AutoSize = true;
            this.thongTinHocSinhLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thongTinHocSinhLabel.Location = new System.Drawing.Point(13, 76);
            this.thongTinHocSinhLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.thongTinHocSinhLabel.Name = "thongTinHocSinhLabel";
            this.thongTinHocSinhLabel.Size = new System.Drawing.Size(172, 25);
            this.thongTinHocSinhLabel.TabIndex = 2;
            this.thongTinHocSinhLabel.Text = "Thông tin học sinh";
            // 
            // thongTinLopHocLabel
            // 
            this.thongTinLopHocLabel.AutoSize = true;
            this.thongTinLopHocLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thongTinLopHocLabel.Location = new System.Drawing.Point(13, 438);
            this.thongTinLopHocLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.thongTinLopHocLabel.Name = "thongTinLopHocLabel";
            this.thongTinLopHocLabel.Size = new System.Drawing.Size(254, 25);
            this.thongTinLopHocLabel.TabIndex = 3;
            this.thongTinLopHocLabel.Text = "Thông tin lớp học (Optional)";
            // 
            // nhapLaiButton
            // 
            this.nhapLaiButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nhapLaiButton.Location = new System.Drawing.Point(1028, 580);
            this.nhapLaiButton.Margin = new System.Windows.Forms.Padding(4);
            this.nhapLaiButton.Name = "nhapLaiButton";
            this.nhapLaiButton.Size = new System.Drawing.Size(100, 50);
            this.nhapLaiButton.TabIndex = 8;
            this.nhapLaiButton.Text = "Nhập lại";
            this.nhapLaiButton.UseVisualStyleBackColor = true;
            this.nhapLaiButton.Click += new System.EventHandler(this.NhapLaiButton_Click);
            // 
            // luuButton
            // 
            this.luuButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.luuButton.Location = new System.Drawing.Point(1149, 580);
            this.luuButton.Margin = new System.Windows.Forms.Padding(4);
            this.luuButton.Name = "luuButton";
            this.luuButton.Size = new System.Drawing.Size(100, 50);
            this.luuButton.TabIndex = 9;
            this.luuButton.Text = "Lưu";
            this.luuButton.UseVisualStyleBackColor = true;
            this.luuButton.Click += new System.EventHandler(this.LuuButton_Click);
            // 
            // formLabel
            // 
            this.formLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.formLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formLabel.Location = new System.Drawing.Point(0, 0);
            this.formLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.formLabel.Name = "formLabel";
            this.formLabel.Size = new System.Drawing.Size(1262, 70);
            this.formLabel.TabIndex = 6;
            this.formLabel.Text = "TIẾP NHẬN HỌC SINH";
            this.formLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TiepNhanHocSinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 643);
            this.Controls.Add(this.formLabel);
            this.Controls.Add(this.luuButton);
            this.Controls.Add(this.nhapLaiButton);
            this.Controls.Add(this.thongTinLopHocLabel);
            this.Controls.Add(this.thongTinHocSinhLabel);
            this.Controls.Add(this.thongTinLopHocPanel);
            this.Controls.Add(this.thongTinHocSinhPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TiepNhanHocSinh";
            this.Text = "Quản lý học sinh";
            this.Load += new System.EventHandler(this.TiepNhanHocSinh_Load);
            this.thongTinHocSinhPanel.ResumeLayout(false);
            this.thongTinHocSinhPanel.PerformLayout();
            this.thongTinLopHocPanel.ResumeLayout(false);
            this.thongTinLopHocPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label thongTinHocSinhLabel;
        private Panel thongTinHocSinhPanel;
        private Label thongTinLopHocLabel;
        private Panel thongTinLopHocPanel;
        private TextBox maHocSinhTextBox;
        private Label maHocSinhLabel;
        private Label soDienThoaiLabel;
        private TextBox soDienThoaiTextBox;
        private Label diaChiLabel;
        private TextBox diaChiTextBox;
        private Label ngaySinhLabel;
        private Label gioiTinhLabel;
        private Label hoTenLabel;
        private TextBox hoTenTextBox;
        private DateTimePicker ngaySinhDateTimePicker;
        private ComboBox gioiTinhComboBox;
        private Label khoiLabel;
        private Label lopLabel;
        private Button nhapLaiButton;
        private Button luuButton;
        private Label formLabel;
        private ComboBox khoiComboBox;
        private ComboBox lopComboBox;
    }
}