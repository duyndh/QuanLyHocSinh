namespace Demo_QLHS
{
    partial class frmThaydoiQuiDinh
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
            this.btnSiSo = new System.Windows.Forms.Button();
            this.btnTuoi = new System.Windows.Forms.Button();
            this.btnThangdiem = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSiSo
            // 
            this.btnSiSo.Location = new System.Drawing.Point(65, 154);
            this.btnSiSo.Name = "btnSiSo";
            this.btnSiSo.Size = new System.Drawing.Size(93, 44);
            this.btnSiSo.TabIndex = 0;
            this.btnSiSo.Text = "SĨ SỐ";
            this.btnSiSo.UseVisualStyleBackColor = true;
            this.btnSiSo.Click += new System.EventHandler(this.btnSiSo_Click);
            // 
            // btnTuoi
            // 
            this.btnTuoi.Location = new System.Drawing.Point(289, 154);
            this.btnTuoi.Name = "btnTuoi";
            this.btnTuoi.Size = new System.Drawing.Size(90, 43);
            this.btnTuoi.TabIndex = 1;
            this.btnTuoi.Text = "TUỔI";
            this.btnTuoi.UseVisualStyleBackColor = true;
            this.btnTuoi.Click += new System.EventHandler(this.btnTuoi_Click);
            // 
            // btnThangdiem
            // 
            this.btnThangdiem.Location = new System.Drawing.Point(516, 154);
            this.btnThangdiem.Name = "btnThangdiem";
            this.btnThangdiem.Size = new System.Drawing.Size(100, 44);
            this.btnThangdiem.TabIndex = 1;
            this.btnThangdiem.Text = "THANG ĐIỂM";
            this.btnThangdiem.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnExit.Location = new System.Drawing.Point(564, 305);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(90, 43);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "THOÁT";
            this.btnExit.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(166, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(348, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "THAY ĐỔI QUI ĐỊNH NHÀ TRƯỜNG";
            // 
            // frmThaydoiQuiDinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(715, 384);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnThangdiem);
            this.Controls.Add(this.btnTuoi);
            this.Controls.Add(this.btnSiSo);
            this.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmThaydoiQuiDinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thay đổi qui định";
            this.Load += new System.EventHandler(this.frmThaydoiQuiDinh_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSiSo;
        private System.Windows.Forms.Button btnTuoi;
        private System.Windows.Forms.Button btnThangdiem;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
    }
}