namespace BTL_HSK_ver_1
{
    partial class frmTrangChu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTrangChu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.HeThong = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDoiMatKhau = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.QuanLy = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHoaDon = new System.Windows.Forms.ToolStripMenuItem();
            this.nhậpHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýSảnPhẩmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BaoCao = new System.Windows.Forms.ToolStripMenuItem();
            this.doanhThuNhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doanhThuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HeThong,
            this.QuanLy,
            this.BaoCao});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(914, 42);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // HeThong
            // 
            this.HeThong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinTàiKhoảnToolStripMenuItem,
            this.mnuDoiMatKhau,
            this.mnuDangXuat,
            this.toolStripSeparator1,
            this.mnuThoat});
            this.HeThong.Image = ((System.Drawing.Image)(resources.GetObject("HeThong.Image")));
            this.HeThong.Name = "HeThong";
            this.HeThong.Size = new System.Drawing.Size(105, 38);
            this.HeThong.Text = "Hệ thống";
            // 
            // thôngTinTàiKhoảnToolStripMenuItem
            // 
            this.thôngTinTàiKhoảnToolStripMenuItem.Name = "thôngTinTàiKhoảnToolStripMenuItem";
            this.thôngTinTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(220, 26);
            this.thôngTinTàiKhoảnToolStripMenuItem.Text = "Thông tin tài khoản";
            this.thôngTinTàiKhoảnToolStripMenuItem.Click += new System.EventHandler(this.thôngTinTàiKhoảnToolStripMenuItem_Click);
            // 
            // mnuDoiMatKhau
            // 
            this.mnuDoiMatKhau.AutoSize = false;
            this.mnuDoiMatKhau.Name = "mnuDoiMatKhau";
            this.mnuDoiMatKhau.Size = new System.Drawing.Size(240, 26);
            this.mnuDoiMatKhau.Text = "Đổi mật khẩu";
            this.mnuDoiMatKhau.Click += new System.EventHandler(this.mnuDoiMatKhau_Click);
            // 
            // mnuDangXuat
            // 
            this.mnuDangXuat.Name = "mnuDangXuat";
            this.mnuDangXuat.Size = new System.Drawing.Size(220, 26);
            this.mnuDangXuat.Text = "Đăng xuất";
            this.mnuDangXuat.Click += new System.EventHandler(this.mnuDangXuat_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(217, 6);
            // 
            // mnuThoat
            // 
            this.mnuThoat.Name = "mnuThoat";
            this.mnuThoat.Size = new System.Drawing.Size(220, 26);
            this.mnuThoat.Text = "Thoát";
            this.mnuThoat.Click += new System.EventHandler(this.mnuThoat_Click);
            // 
            // QuanLy
            // 
            this.QuanLy.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHoaDon,
            this.nhậpHàngToolStripMenuItem,
            this.quảnLýSảnPhẩmToolStripMenuItem});
            this.QuanLy.Image = ((System.Drawing.Image)(resources.GetObject("QuanLy.Image")));
            this.QuanLy.Name = "QuanLy";
            this.QuanLy.Size = new System.Drawing.Size(110, 38);
            this.QuanLy.Text = "Danh mục";
            this.QuanLy.Click += new System.EventHandler(this.QuanLy_Click);
            // 
            // mnuHoaDon
            // 
            this.mnuHoaDon.Image = ((System.Drawing.Image)(resources.GetObject("mnuHoaDon.Image")));
            this.mnuHoaDon.Name = "mnuHoaDon";
            this.mnuHoaDon.Size = new System.Drawing.Size(224, 26);
            this.mnuHoaDon.Text = "Thêm hoá đơn";
            this.mnuHoaDon.Click += new System.EventHandler(this.mnuHoaDon_Click);
            // 
            // nhậpHàngToolStripMenuItem
            // 
            this.nhậpHàngToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("nhậpHàngToolStripMenuItem.Image")));
            this.nhậpHàngToolStripMenuItem.Name = "nhậpHàngToolStripMenuItem";
            this.nhậpHàngToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.nhậpHàngToolStripMenuItem.Text = "Nhập hàng";
            this.nhậpHàngToolStripMenuItem.Click += new System.EventHandler(this.nhậpHàngToolStripMenuItem_Click);
            // 
            // quảnLýSảnPhẩmToolStripMenuItem
            // 
            this.quảnLýSảnPhẩmToolStripMenuItem.Name = "quảnLýSảnPhẩmToolStripMenuItem";
            this.quảnLýSảnPhẩmToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.quảnLýSảnPhẩmToolStripMenuItem.Text = "Quản lý sản phẩm";
            this.quảnLýSảnPhẩmToolStripMenuItem.Click += new System.EventHandler(this.quảnLýSảnPhẩmToolStripMenuItem_Click);
            // 
            // BaoCao
            // 
            this.BaoCao.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.doanhThuNhânViênToolStripMenuItem,
            this.doanhThuToolStripMenuItem});
            this.BaoCao.Image = ((System.Drawing.Image)(resources.GetObject("BaoCao.Image")));
            this.BaoCao.Name = "BaoCao";
            this.BaoCao.Size = new System.Drawing.Size(97, 38);
            this.BaoCao.Text = "Báo cáo";
            // 
            // doanhThuNhânViênToolStripMenuItem
            // 
            this.doanhThuNhânViênToolStripMenuItem.Name = "doanhThuNhânViênToolStripMenuItem";
            this.doanhThuNhânViênToolStripMenuItem.Size = new System.Drawing.Size(231, 26);
            this.doanhThuNhânViênToolStripMenuItem.Text = "Danh sách nhân viên";
            this.doanhThuNhânViênToolStripMenuItem.Click += new System.EventHandler(this.doanhThuNhânViênToolStripMenuItem_Click);
            // 
            // doanhThuToolStripMenuItem
            // 
            this.doanhThuToolStripMenuItem.Name = "doanhThuToolStripMenuItem";
            this.doanhThuToolStripMenuItem.Size = new System.Drawing.Size(231, 26);
            this.doanhThuToolStripMenuItem.Text = "Doanh thu theo ngày";
            this.doanhThuToolStripMenuItem.Click += new System.EventHandler(this.doanhThuToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Brown;
            this.label1.Location = new System.Drawing.Point(345, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quản lý bán hàng";
            // 
            // frmTrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(914, 508);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmTrangChu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trang chủ";
            this.Load += new System.EventHandler(this.frmTrangChu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem HeThong;
        private System.Windows.Forms.ToolStripMenuItem mnuDoiMatKhau;
        private System.Windows.Forms.ToolStripMenuItem mnuDangXuat;
        private System.Windows.Forms.ToolStripMenuItem mnuThoat;
        private System.Windows.Forms.ToolStripMenuItem QuanLy;
        private System.Windows.Forms.ToolStripMenuItem BaoCao;
        private System.Windows.Forms.ToolStripMenuItem mnuHoaDon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem nhậpHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinTàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem quảnLýSảnPhẩmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doanhThuNhânViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doanhThuToolStripMenuItem;
    }
}