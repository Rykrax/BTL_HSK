namespace BTL_HSK_ver_1
{
    partial class frmHoaDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHoaDon));
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.grbThongTin = new System.Windows.Forms.GroupBox();
            this.picDSNV = new System.Windows.Forms.PictureBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.radNu = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.radNam = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grbThongTinSP = new System.Windows.Forms.GroupBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnHoaDonMoi = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThemSP = new System.Windows.Forms.Button();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.lblThanhTien = new System.Windows.Forms.Label();
            this.lblDonGia = new System.Windows.Forms.Label();
            this.lblMaSP = new System.Windows.Forms.Label();
            this.lblTenSP = new System.Windows.Forms.Label();
            this.dgvDanhSach = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.grbThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDSNV)).BeginInit();
            this.grbThongTinSP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieuDe.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblTieuDe.Location = new System.Drawing.Point(451, 9);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(252, 35);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "Hoá đơn bán hàng";
            // 
            // grbThongTin
            // 
            this.grbThongTin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbThongTin.Controls.Add(this.picDSNV);
            this.grbThongTin.Controls.Add(this.txtMaNV);
            this.grbThongTin.Controls.Add(this.txtDiaChi);
            this.grbThongTin.Controls.Add(this.txtSDT);
            this.grbThongTin.Controls.Add(this.txtTenKH);
            this.grbThongTin.Controls.Add(this.radNu);
            this.grbThongTin.Controls.Add(this.label7);
            this.grbThongTin.Controls.Add(this.radNam);
            this.grbThongTin.Controls.Add(this.label5);
            this.grbThongTin.Controls.Add(this.label4);
            this.grbThongTin.Controls.Add(this.label3);
            this.grbThongTin.Controls.Add(this.txtTenNV);
            this.grbThongTin.Controls.Add(this.label2);
            this.grbThongTin.Controls.Add(this.label1);
            this.grbThongTin.ForeColor = System.Drawing.SystemColors.MenuText;
            this.grbThongTin.Location = new System.Drawing.Point(123, 70);
            this.grbThongTin.Name = "grbThongTin";
            this.grbThongTin.Size = new System.Drawing.Size(939, 228);
            this.grbThongTin.TabIndex = 1;
            this.grbThongTin.TabStop = false;
            this.grbThongTin.Text = "Thông tin chung";
            // 
            // picDSNV
            // 
            this.picDSNV.BackColor = System.Drawing.Color.Transparent;
            this.picDSNV.Image = ((System.Drawing.Image)(resources.GetObject("picDSNV.Image")));
            this.picDSNV.Location = new System.Drawing.Point(868, 87);
            this.picDSNV.Name = "picDSNV";
            this.picDSNV.Size = new System.Drawing.Size(32, 30);
            this.picDSNV.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picDSNV.TabIndex = 22;
            this.picDSNV.TabStop = false;
            this.picDSNV.Click += new System.EventHandler(this.picDSNV_Click);
            // 
            // txtMaNV
            // 
            this.txtMaNV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaNV.Location = new System.Drawing.Point(641, 87);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(221, 30);
            this.txtMaNV.TabIndex = 12;
            this.txtMaNV.TextChanged += new System.EventHandler(this.txtMaNV_TextChanged);
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDiaChi.Location = new System.Drawing.Point(207, 134);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(221, 30);
            this.txtDiaChi.TabIndex = 8;
            // 
            // txtSDT
            // 
            this.txtSDT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSDT.Location = new System.Drawing.Point(207, 86);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(221, 30);
            this.txtSDT.TabIndex = 7;
            this.txtSDT.TextChanged += new System.EventHandler(this.txtSDT_TextChanged);
            // 
            // txtTenKH
            // 
            this.txtTenKH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTenKH.Location = new System.Drawing.Point(207, 44);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(221, 30);
            this.txtTenKH.TabIndex = 6;
            // 
            // radNu
            // 
            this.radNu.AutoSize = true;
            this.radNu.Location = new System.Drawing.Point(299, 175);
            this.radNu.Name = "radNu";
            this.radNu.Size = new System.Drawing.Size(56, 26);
            this.radNu.TabIndex = 10;
            this.radNu.TabStop = true;
            this.radNu.Text = "Nữ";
            this.radNu.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 177);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 22);
            this.label7.TabIndex = 3;
            this.label7.Text = "Giới tính";
            // 
            // radNam
            // 
            this.radNam.AutoSize = true;
            this.radNam.Location = new System.Drawing.Point(207, 175);
            this.radNam.Name = "radNam";
            this.radNam.Size = new System.Drawing.Size(68, 26);
            this.radNam.TabIndex = 9;
            this.radNam.TabStop = true;
            this.radNam.Text = "Nam";
            this.radNam.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 22);
            this.label5.TabIndex = 2;
            this.label5.Text = "Địa chỉ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 22);
            this.label4.TabIndex = 1;
            this.label4.Text = "Số điện thoại";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tên khách hàng";
            // 
            // txtTenNV
            // 
            this.txtTenNV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTenNV.Location = new System.Drawing.Point(641, 44);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(221, 30);
            this.txtTenNV.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(482, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mã nhân viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(482, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tên nhân viên";
            // 
            // grbThongTinSP
            // 
            this.grbThongTinSP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbThongTinSP.Controls.Add(this.btnLuu);
            this.grbThongTinSP.Controls.Add(this.btnDong);
            this.grbThongTinSP.Controls.Add(this.btnHoaDonMoi);
            this.grbThongTinSP.Controls.Add(this.btnSua);
            this.grbThongTinSP.Controls.Add(this.btnXoa);
            this.grbThongTinSP.Controls.Add(this.btnThemSP);
            this.grbThongTinSP.Controls.Add(this.lblTongTien);
            this.grbThongTinSP.Controls.Add(this.txtSoLuong);
            this.grbThongTinSP.Controls.Add(this.label13);
            this.grbThongTinSP.Controls.Add(this.lblThanhTien);
            this.grbThongTinSP.Controls.Add(this.lblDonGia);
            this.grbThongTinSP.Controls.Add(this.lblMaSP);
            this.grbThongTinSP.Controls.Add(this.lblTenSP);
            this.grbThongTinSP.Controls.Add(this.dgvDanhSach);
            this.grbThongTinSP.Controls.Add(this.label12);
            this.grbThongTinSP.Controls.Add(this.label10);
            this.grbThongTinSP.Controls.Add(this.label9);
            this.grbThongTinSP.Controls.Add(this.label8);
            this.grbThongTinSP.Controls.Add(this.label6);
            this.grbThongTinSP.Location = new System.Drawing.Point(44, 329);
            this.grbThongTinSP.Name = "grbThongTinSP";
            this.grbThongTinSP.Size = new System.Drawing.Size(1098, 496);
            this.grbThongTinSP.TabIndex = 2;
            this.grbThongTinSP.TabStop = false;
            this.grbThongTinSP.Text = "Thông tin sản phẩm";
            // 
            // btnLuu
            // 
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(558, 421);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(133, 51);
            this.btnLuu.TabIndex = 17;
            this.btnLuu.Text = "    Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnDong
            // 
            this.btnDong.Image = ((System.Drawing.Image)(resources.GetObject("btnDong.Image")));
            this.btnDong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDong.Location = new System.Drawing.Point(922, 421);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(133, 51);
            this.btnDong.TabIndex = 19;
            this.btnDong.Text = "    Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnHoaDonMoi
            // 
            this.btnHoaDonMoi.Image = ((System.Drawing.Image)(resources.GetObject("btnHoaDonMoi.Image")));
            this.btnHoaDonMoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHoaDonMoi.Location = new System.Drawing.Point(714, 421);
            this.btnHoaDonMoi.Name = "btnHoaDonMoi";
            this.btnHoaDonMoi.Size = new System.Drawing.Size(182, 51);
            this.btnHoaDonMoi.TabIndex = 18;
            this.btnHoaDonMoi.Text = "      Hoá đơn mới";
            this.btnHoaDonMoi.UseVisualStyleBackColor = true;
            this.btnHoaDonMoi.Click += new System.EventHandler(this.btnHoaDonMoi_Click);
            // 
            // btnSua
            // 
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(401, 421);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(134, 51);
            this.btnSua.TabIndex = 16;
            this.btnSua.Text = "  Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(246, 421);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(133, 51);
            this.btnXoa.TabIndex = 15;
            this.btnXoa.Text = "   Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThemSP
            // 
            this.btnThemSP.Image = ((System.Drawing.Image)(resources.GetObject("btnThemSP.Image")));
            this.btnThemSP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemSP.Location = new System.Drawing.Point(41, 421);
            this.btnThemSP.Name = "btnThemSP";
            this.btnThemSP.Size = new System.Drawing.Size(182, 51);
            this.btnThemSP.TabIndex = 14;
            this.btnThemSP.Text = "       Thêm sản phẩm";
            this.btnThemSP.UseVisualStyleBackColor = true;
            this.btnThemSP.Click += new System.EventHandler(this.btnThemSP_Click);
            // 
            // lblTongTien
            // 
            this.lblTongTien.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTongTien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTongTien.Location = new System.Drawing.Point(869, 354);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(186, 30);
            this.lblTongTien.TabIndex = 13;
            this.lblTongTien.Text = "0";
            this.lblTongTien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtSoLuong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSoLuong.Location = new System.Drawing.Point(869, 45);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(186, 30);
            this.txtSoLuong.TabIndex = 10;
            this.txtSoLuong.Text = "1";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(750, 358);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(84, 22);
            this.label13.TabIndex = 6;
            this.label13.Text = "Tổng tiền";
            // 
            // lblThanhTien
            // 
            this.lblThanhTien.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblThanhTien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblThanhTien.Location = new System.Drawing.Point(507, 86);
            this.lblThanhTien.Name = "lblThanhTien";
            this.lblThanhTien.Size = new System.Drawing.Size(186, 30);
            this.lblThanhTien.TabIndex = 12;
            this.lblThanhTien.Text = "0";
            this.lblThanhTien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDonGia
            // 
            this.lblDonGia.BackColor = System.Drawing.SystemColors.Control;
            this.lblDonGia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDonGia.Location = new System.Drawing.Point(150, 86);
            this.lblDonGia.Name = "lblDonGia";
            this.lblDonGia.Size = new System.Drawing.Size(186, 30);
            this.lblDonGia.TabIndex = 9;
            this.lblDonGia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMaSP
            // 
            this.lblMaSP.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblMaSP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMaSP.Location = new System.Drawing.Point(507, 43);
            this.lblMaSP.Name = "lblMaSP";
            this.lblMaSP.Size = new System.Drawing.Size(186, 30);
            this.lblMaSP.TabIndex = 8;
            this.lblMaSP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTenSP
            // 
            this.lblTenSP.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTenSP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTenSP.Location = new System.Drawing.Point(150, 43);
            this.lblTenSP.Name = "lblTenSP";
            this.lblTenSP.Size = new System.Drawing.Size(186, 30);
            this.lblTenSP.TabIndex = 7;
            this.lblTenSP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvDanhSach
            // 
            this.dgvDanhSach.AllowUserToAddRows = false;
            this.dgvDanhSach.AllowUserToDeleteRows = false;
            this.dgvDanhSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvDanhSach.Location = new System.Drawing.Point(41, 135);
            this.dgvDanhSach.Name = "dgvDanhSach";
            this.dgvDanhSach.RowHeadersWidth = 51;
            this.dgvDanhSach.RowTemplate.Height = 24;
            this.dgvDanhSach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDanhSach.Size = new System.Drawing.Size(1014, 199);
            this.dgvDanhSach.TabIndex = 0;
            this.dgvDanhSach.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSach_CellContentClick);
            this.dgvDanhSach.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSach_CellContentDoubleClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaSP";
            this.Column1.HeaderText = "Mã sản phẩm";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TenSP";
            this.Column2.HeaderText = "Tên sản phẩm";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 270;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "DVT";
            this.Column3.HeaderText = "Đơn vị tính";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 160;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "LoaiHang";
            this.Column4.HeaderText = "Loại hàng";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 200;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "SoLuong";
            this.Column5.HeaderText = "Số lượng";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 180;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(397, 90);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(92, 22);
            this.label12.TabIndex = 5;
            this.label12.Text = "Thành tiền";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(752, 47);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 22);
            this.label10.TabIndex = 1;
            this.label10.Text = "Số lượng";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(37, 90);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 22);
            this.label9.TabIndex = 4;
            this.label9.Text = "Đơn giá";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(397, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 22);
            this.label8.TabIndex = 2;
            this.label8.Text = "Mã hàng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 22);
            this.label6.TabIndex = 0;
            this.label6.Text = "Tên hàng";
            // 
            // frmHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 856);
            this.Controls.Add(this.grbThongTinSP);
            this.Controls.Add(this.grbThongTin);
            this.Controls.Add(this.lblTieuDe);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hoá đơn";
            this.Load += new System.EventHandler(this.frmHoaDon_Load);
            this.grbThongTin.ResumeLayout(false);
            this.grbThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDSNV)).EndInit();
            this.grbThongTinSP.ResumeLayout(false);
            this.grbThongTinSP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.GroupBox grbThongTin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radNu;
        private System.Windows.Forms.RadioButton radNam;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.GroupBox grbThongTinSP;
        private System.Windows.Forms.DataGridView dgvDanhSach;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblThanhTien;
        private System.Windows.Forms.Label lblDonGia;
        private System.Windows.Forms.Label lblMaSP;
        private System.Windows.Forms.Label lblTenSP;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnThemSP;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnHoaDonMoi;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.PictureBox picDSNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}