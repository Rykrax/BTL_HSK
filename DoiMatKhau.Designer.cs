namespace BTL_HSK_ver_1
{
    partial class frmDoiMatKhau
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
            this.lblMatKhauHienTai = new System.Windows.Forms.Label();
            this.lblMatKhauMoi = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnThayDoi = new System.Windows.Forms.Button();
            this.txtMatKhauHienTai = new System.Windows.Forms.TextBox();
            this.txtMatKhauMoi = new System.Windows.Forms.TextBox();
            this.txtXacNhan = new System.Windows.Forms.TextBox();
            this.chkHienMatKhau = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblMatKhauHienTai
            // 
            this.lblMatKhauHienTai.Location = new System.Drawing.Point(34, 31);
            this.lblMatKhauHienTai.Name = "lblMatKhauHienTai";
            this.lblMatKhauHienTai.Size = new System.Drawing.Size(169, 36);
            this.lblMatKhauHienTai.TabIndex = 0;
            this.lblMatKhauHienTai.Text = "Mật khẩu hiện tại:";
            this.lblMatKhauHienTai.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMatKhauMoi
            // 
            this.lblMatKhauMoi.Location = new System.Drawing.Point(34, 79);
            this.lblMatKhauMoi.Name = "lblMatKhauMoi";
            this.lblMatKhauMoi.Size = new System.Drawing.Size(169, 36);
            this.lblMatKhauMoi.TabIndex = 1;
            this.lblMatKhauMoi.Text = "Mật khẩu mới:";
            this.lblMatKhauMoi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(34, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 36);
            this.label3.TabIndex = 2;
            this.label3.Text = "Xác nhận mật khẩu:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnThayDoi
            // 
            this.btnThayDoi.Location = new System.Drawing.Point(164, 218);
            this.btnThayDoi.Name = "btnThayDoi";
            this.btnThayDoi.Size = new System.Drawing.Size(182, 48);
            this.btnThayDoi.TabIndex = 3;
            this.btnThayDoi.Text = "Thay đổi mật khẩu";
            this.btnThayDoi.UseVisualStyleBackColor = true;
            this.btnThayDoi.Click += new System.EventHandler(this.btnThayDoi_Click);
            // 
            // txtMatKhauHienTai
            // 
            this.txtMatKhauHienTai.Location = new System.Drawing.Point(222, 36);
            this.txtMatKhauHienTai.Name = "txtMatKhauHienTai";
            this.txtMatKhauHienTai.Size = new System.Drawing.Size(242, 28);
            this.txtMatKhauHienTai.TabIndex = 4;
            // 
            // txtMatKhauMoi
            // 
            this.txtMatKhauMoi.Location = new System.Drawing.Point(222, 84);
            this.txtMatKhauMoi.Name = "txtMatKhauMoi";
            this.txtMatKhauMoi.Size = new System.Drawing.Size(242, 28);
            this.txtMatKhauMoi.TabIndex = 5;
            // 
            // txtXacNhan
            // 
            this.txtXacNhan.Location = new System.Drawing.Point(222, 134);
            this.txtXacNhan.Name = "txtXacNhan";
            this.txtXacNhan.Size = new System.Drawing.Size(242, 28);
            this.txtXacNhan.TabIndex = 6;
            // 
            // chkHienMatKhau
            // 
            this.chkHienMatKhau.Location = new System.Drawing.Point(222, 168);
            this.chkHienMatKhau.Name = "chkHienMatKhau";
            this.chkHienMatKhau.Size = new System.Drawing.Size(147, 34);
            this.chkHienMatKhau.TabIndex = 7;
            this.chkHienMatKhau.Text = "Hiện mật khẩu";
            this.chkHienMatKhau.UseVisualStyleBackColor = true;
            this.chkHienMatKhau.CheckedChanged += new System.EventHandler(this.chkHienMatKhau_CheckedChanged);
            // 
            // frmDoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 311);
            this.Controls.Add(this.chkHienMatKhau);
            this.Controls.Add(this.txtXacNhan);
            this.Controls.Add(this.txtMatKhauMoi);
            this.Controls.Add(this.txtMatKhauHienTai);
            this.Controls.Add(this.btnThayDoi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblMatKhauMoi);
            this.Controls.Add(this.lblMatKhauHienTai);
            this.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmDoiMatKhau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đổi mật khẩu";
            this.Load += new System.EventHandler(this.frmDoiMatKhau_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMatKhauHienTai;
        private System.Windows.Forms.Label lblMatKhauMoi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnThayDoi;
        private System.Windows.Forms.TextBox txtMatKhauHienTai;
        private System.Windows.Forms.TextBox txtMatKhauMoi;
        private System.Windows.Forms.TextBox txtXacNhan;
        private System.Windows.Forms.CheckBox chkHienMatKhau;
    }
}