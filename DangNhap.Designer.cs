namespace BTL_HSK_ver_1
{
    partial class frmDangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDangNhap));
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.llbDangKy = new System.Windows.Forms.LinkLabel();
            this.llbQuenMK = new System.Windows.Forms.LinkLabel();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.txtTaiKhoan = new System.Windows.Forms.TextBox();
            this.lblMatKhau = new System.Windows.Forms.Label();
            this.lblTaiKhoan = new System.Windows.Forms.Label();
            this.picVisible = new System.Windows.Forms.PictureBox();
            this.picInvisible = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picVisible)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picInvisible)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDangNhap.Location = new System.Drawing.Point(191, 175);
            this.btnDangNhap.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(128, 45);
            this.btnDangNhap.TabIndex = 11;
            this.btnDangNhap.Text = "Đăng nhập";
            this.btnDangNhap.UseVisualStyleBackColor = true;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // llbDangKy
            // 
            this.llbDangKy.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.llbDangKy.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.llbDangKy.Location = new System.Drawing.Point(296, 127);
            this.llbDangKy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.llbDangKy.Name = "llbDangKy";
            this.llbDangKy.Size = new System.Drawing.Size(146, 45);
            this.llbDangKy.TabIndex = 13;
            this.llbDangKy.TabStop = true;
            this.llbDangKy.Text = "Đăng ký";
            this.llbDangKy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.llbDangKy.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbDangKy_LinkClicked);
            // 
            // llbQuenMK
            // 
            this.llbQuenMK.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.llbQuenMK.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.llbQuenMK.Location = new System.Drawing.Point(88, 127);
            this.llbQuenMK.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.llbQuenMK.Name = "llbQuenMK";
            this.llbQuenMK.Size = new System.Drawing.Size(146, 45);
            this.llbQuenMK.TabIndex = 12;
            this.llbQuenMK.TabStop = true;
            this.llbQuenMK.Text = "Quên mật khẩu";
            this.llbQuenMK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.llbQuenMK.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbQuenMK_LinkClicked);
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMatKhau.Location = new System.Drawing.Point(176, 83);
            this.txtMatKhau.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.PasswordChar = '*';
            this.txtMatKhau.Size = new System.Drawing.Size(256, 28);
            this.txtMatKhau.TabIndex = 10;
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTaiKhoan.Location = new System.Drawing.Point(176, 32);
            this.txtTaiKhoan.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.Size = new System.Drawing.Size(256, 28);
            this.txtTaiKhoan.TabIndex = 9;
            // 
            // lblMatKhau
            // 
            this.lblMatKhau.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMatKhau.Location = new System.Drawing.Point(58, 82);
            this.lblMatKhau.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMatKhau.Name = "lblMatKhau";
            this.lblMatKhau.Size = new System.Drawing.Size(90, 28);
            this.lblMatKhau.TabIndex = 8;
            this.lblMatKhau.Text = "Mật khẩu:";
            this.lblMatKhau.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTaiKhoan
            // 
            this.lblTaiKhoan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTaiKhoan.Location = new System.Drawing.Point(58, 31);
            this.lblTaiKhoan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTaiKhoan.Name = "lblTaiKhoan";
            this.lblTaiKhoan.Size = new System.Drawing.Size(90, 28);
            this.lblTaiKhoan.TabIndex = 7;
            this.lblTaiKhoan.Text = "Tài khoản:";
            this.lblTaiKhoan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // picVisible
            // 
            this.picVisible.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picVisible.Image = ((System.Drawing.Image)(resources.GetObject("picVisible.Image")));
            this.picVisible.Location = new System.Drawing.Point(440, 85);
            this.picVisible.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.picVisible.Name = "picVisible";
            this.picVisible.Size = new System.Drawing.Size(45, 27);
            this.picVisible.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picVisible.TabIndex = 14;
            this.picVisible.TabStop = false;
            this.picVisible.Click += new System.EventHandler(this.picVisible_Click);
            // 
            // picInvisible
            // 
            this.picInvisible.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picInvisible.Image = ((System.Drawing.Image)(resources.GetObject("picInvisible.Image")));
            this.picInvisible.Location = new System.Drawing.Point(440, 85);
            this.picInvisible.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.picInvisible.Name = "picInvisible";
            this.picInvisible.Size = new System.Drawing.Size(45, 27);
            this.picInvisible.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picInvisible.TabIndex = 15;
            this.picInvisible.TabStop = false;
            this.picInvisible.Click += new System.EventHandler(this.picInvisible_Click);
            // 
            // frmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 252);
            this.Controls.Add(this.picInvisible);
            this.Controls.Add(this.picVisible);
            this.Controls.Add(this.btnDangNhap);
            this.Controls.Add(this.llbDangKy);
            this.Controls.Add(this.llbQuenMK);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.txtTaiKhoan);
            this.Controls.Add(this.lblMatKhau);
            this.Controls.Add(this.lblTaiKhoan);
            this.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmDangNhap_FormClosed);
            this.Load += new System.EventHandler(this.frmDangNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picVisible)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picInvisible)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.LinkLabel llbDangKy;
        private System.Windows.Forms.LinkLabel llbQuenMK;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.TextBox txtTaiKhoan;
        private System.Windows.Forms.Label lblMatKhau;
        private System.Windows.Forms.Label lblTaiKhoan;
        private System.Windows.Forms.PictureBox picVisible;
        private System.Windows.Forms.PictureBox picInvisible;
    }
}