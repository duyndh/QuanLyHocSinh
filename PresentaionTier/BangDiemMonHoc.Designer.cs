namespace QuanLyHocSinh
{
    partial class BangDiemMonHoc
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lopLabel = new System.Windows.Forms.Label();
            this.lopComboBox = new System.Windows.Forms.ComboBox();
            this.hocKyLabel = new System.Windows.Forms.Label();
            this.hocKyComboBox = new System.Windows.Forms.ComboBox();
            this.taoBaoCaoButton = new System.Windows.Forms.Button();
            this.monHocLabel = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.monHocComboBox = new System.Windows.Forms.ComboBox();
            this.formLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.lopLabel);
            this.panel1.Controls.Add(this.lopComboBox);
            this.panel1.Controls.Add(this.hocKyLabel);
            this.panel1.Controls.Add(this.hocKyComboBox);
            this.panel1.Controls.Add(this.taoBaoCaoButton);
            this.panel1.Controls.Add(this.monHocLabel);
            this.panel1.Controls.Add(this.dataGridView);
            this.panel1.Controls.Add(this.monHocComboBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 88);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1262, 555);
            this.panel1.TabIndex = 17;
            // 
            // lopLabel
            // 
            this.lopLabel.AutoSize = true;
            this.lopLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lopLabel.Location = new System.Drawing.Point(385, 24);
            this.lopLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lopLabel.Name = "lopLabel";
            this.lopLabel.Size = new System.Drawing.Size(45, 25);
            this.lopLabel.TabIndex = 19;
            this.lopLabel.Text = "Lớp";
            // 
            // lopComboBox
            // 
            this.lopComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lopComboBox.FormattingEnabled = true;
            this.lopComboBox.Location = new System.Drawing.Point(390, 53);
            this.lopComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.lopComboBox.Name = "lopComboBox";
            this.lopComboBox.Size = new System.Drawing.Size(200, 33);
            this.lopComboBox.TabIndex = 18;
            // 
            // hocKyLabel
            // 
            this.hocKyLabel.AutoSize = true;
            this.hocKyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hocKyLabel.Location = new System.Drawing.Point(716, 24);
            this.hocKyLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.hocKyLabel.Name = "hocKyLabel";
            this.hocKyLabel.Size = new System.Drawing.Size(72, 25);
            this.hocKyLabel.TabIndex = 17;
            this.hocKyLabel.Text = "Học kỳ";
            // 
            // hocKyComboBox
            // 
            this.hocKyComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hocKyComboBox.FormattingEnabled = true;
            this.hocKyComboBox.Location = new System.Drawing.Point(722, 53);
            this.hocKyComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.hocKyComboBox.Name = "hocKyComboBox";
            this.hocKyComboBox.Size = new System.Drawing.Size(200, 33);
            this.hocKyComboBox.TabIndex = 2;
            // 
            // taoBaoCaoButton
            // 
            this.taoBaoCaoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taoBaoCaoButton.Location = new System.Drawing.Point(1099, 24);
            this.taoBaoCaoButton.Margin = new System.Windows.Forms.Padding(4);
            this.taoBaoCaoButton.Name = "taoBaoCaoButton";
            this.taoBaoCaoButton.Size = new System.Drawing.Size(150, 60);
            this.taoBaoCaoButton.TabIndex = 3;
            this.taoBaoCaoButton.Text = "Tạo báo cáo";
            this.taoBaoCaoButton.UseVisualStyleBackColor = true;
            this.taoBaoCaoButton.Click += new System.EventHandler(this.TaoBaoCaoButton_Click);
            // 
            // monHocLabel
            // 
            this.monHocLabel.AutoSize = true;
            this.monHocLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monHocLabel.Location = new System.Drawing.Point(50, 24);
            this.monHocLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.monHocLabel.Name = "monHocLabel";
            this.monHocLabel.Size = new System.Drawing.Size(88, 25);
            this.monHocLabel.TabIndex = 13;
            this.monHocLabel.Text = "Môn học";
            // 
            // dataGridView
            // 
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(8, 95);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(1241, 456);
            this.dataGridView.TabIndex = 4;
            // 
            // monHocComboBox
            // 
            this.monHocComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monHocComboBox.FormattingEnabled = true;
            this.monHocComboBox.Location = new System.Drawing.Point(55, 53);
            this.monHocComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.monHocComboBox.Name = "monHocComboBox";
            this.monHocComboBox.Size = new System.Drawing.Size(200, 33);
            this.monHocComboBox.TabIndex = 1;
            // 
            // formLabel
            // 
            this.formLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.formLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formLabel.Location = new System.Drawing.Point(0, 0);
            this.formLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.formLabel.Name = "formLabel";
            this.formLabel.Size = new System.Drawing.Size(1262, 88);
            this.formLabel.TabIndex = 16;
            this.formLabel.Text = "BẢNG ĐIỂM MÔN HỌC";
            this.formLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BangDiemMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 643);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.formLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BangDiemMonHoc";
            this.Text = "Bảng điểm môn học";
            this.Load += new System.EventHandler(this.BangDiemMonHoc_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label hocKyLabel;
        private System.Windows.Forms.ComboBox hocKyComboBox;
        private System.Windows.Forms.Button taoBaoCaoButton;
        private System.Windows.Forms.Label monHocLabel;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.ComboBox monHocComboBox;
        private System.Windows.Forms.Label formLabel;
        private System.Windows.Forms.Label lopLabel;
        private System.Windows.Forms.ComboBox lopComboBox;
    }
}