using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_HSK_ver_1
{
    public partial class frmHoaDon : Form, iChuyenDuLieu
    {
        private bool check = false;
        private bool save = false;
        private string manv;
        private string masp;
        private string tensp;
        private string dvt;
        private string loaihang;
        private int soluong;
        private string maddh;
        List<SanPham> list = new List<SanPham>();
        public frmHoaDon()
        {
            InitializeComponent();
        }

        public void XuLyMaNV(string manv)
        {
            this.manv = manv;
            txtMaNV.Text = manv;

        }

        public void XuLyMaSP(string masp, string tensp, string dvt, string loaihang, int soluong)
        {
            this.masp = masp;
            this.tensp = tensp;
            this.dvt = dvt;
            this.loaihang = loaihang;
            this.soluong = soluong;
        }

        private void txtSDT_TextChanged(object sender, EventArgs e)
        {
            txtTenKH.ReadOnly = false;
            using (SqlConnection sql = ConnectData.GetSqlConnection())
            {
                sql.Open();
                string query = "SELECT * FROM tblKhachHang WHERE sDienThoai = @sdt";
                using (SqlCommand cmd = new SqlCommand(query, sql))
                {
                    cmd.Parameters.AddWithValue("@sdt", txtSDT.Text);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            txtTenKH.ReadOnly = true;
                            txtTenKH.Text = reader.GetString(1);
                        }
                    }
                }
                sql.Close();
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            if (save == false)
            {
                DialogResult res = MessageBox.Show("Bạn chưa lưu hoá đơn. Thoát và không lưu?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (res == DialogResult.Yes)
                {
                    this.Close();
                }
            }
           
        }

        private void picDSNV_Click(object sender, EventArgs e)
        {
            frmDanhSachNhanVien form = new frmDanhSachNhanVien(this);
            form.ShowDialog();
            form = null;
        }

        private void txtMaNV_TextChanged(object sender, EventArgs e)
        {
            txtTenNV.Text = "";
            txtTenNV.ReadOnly = false;
            using (SqlConnection sql = ConnectData.GetSqlConnection())
            {
                sql.Open();
                string query = "SELECT * FROM tblNhanVien WHERE sMaNV = @manv";
                using (SqlCommand cmd = new SqlCommand(query, sql))
                {
                    cmd.Parameters.AddWithValue("@manv", txtMaNV.Text);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            txtTenNV.ReadOnly = true;
                            txtTenNV.Text = reader.GetString(1);
                        }
                    }
                }
                sql.Close();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvDanhSach.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvDanhSach.SelectedRows[0];
                string masp = row.Cells["Column1"].Value.ToString();
                string dvt = row.Cells["Column3"].Value.ToString();
                List<SanPham> tmp = new List<SanPham>();
                SanPham removeItem = null;
                foreach (SanPham item in list)
                {
                    if (item.MaSP == masp && item.DVT == dvt)
                    {
                        lblTongTien.Text = (double.Parse(lblTongTien.Text) - double.Parse(lblDonGia.Text)*item.SoLuong).ToString();
                        removeItem = item;
                    }
                    else
                    {
                        tmp.Add(item);
                    }
                }
                dgvDanhSach.DataSource = tmp;
                list.Remove(removeItem);
            }
            lblDonGia.Text = "";
            lblThanhTien.Text = "";
            dgvDanhSach.ClearSelection();
        }

        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnLuu.Enabled = false;
            maddh = SinhMaNgauNhien("HDDH");
            while (true)
            {
                if (KiemTraMa("sMaHDDH", maddh, "tblDonDatHang") == true)
                {
                    maddh = SinhMaNgauNhien("HDDH");
                }
                else break;
            }
        }

        public string SinhMaNgauNhien(string kihieu)
        {
            Random random = new Random();
            int randomNumber = random.Next(1000, 10000);

            string randomCode = kihieu + randomNumber.ToString();
            return randomCode;
        }

        public bool KiemTraMa(string tenMaKiemTra, string maKiemTra, string bangKiemTra)
        {
            bool i;
            using (SqlConnection sql = ConnectData.GetSqlConnection())
            {
                sql.Open();
                string query = $"SELECT * FROM {bangKiemTra} WHERE {tenMaKiemTra} = '{maKiemTra}'";
                using (SqlCommand cmd = new SqlCommand(query, sql))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read()) i = true;
                        else i = false;
                    }
                }
                sql.Close();
            }
            return i;
        }
        private void btnThemSP_Click(object sender, EventArgs e)
        {
            frmDanhSachSanPham form = new frmDanhSachSanPham(this);
            this.Hide();
            form.ShowDialog();
            form = null;
            this.Show();
            SanPham sp;
            check = false;
            sp = new SanPham() { MaSP = masp, TenSP = tensp, DVT = dvt, LoaiHang = loaihang, SoLuong = 0 };
            Console.WriteLine(soluong);
            foreach (SanPham item in list)
            {
                if (sp.TenSP == item.TenSP && sp.DVT == item.DVT)
                {
                    check = true;
                }
            }
            if (check == false)
            {
                list.Add(sp);
            }
            List<SanPham> tmp = new List<SanPham>();
            foreach (SanPham item in list)
            {
                tmp.Add(item);
            }
            dgvDanhSach.DataSource = tmp;
            dgvDanhSach.ClearSelection();
        }


        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvDanhSach.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvDanhSach.SelectedRows[0];
                try
                {
                    int soLuong = int.Parse(txtSoLuong.Text);
                    if (soLuong < 0) { MessageBox.Show("Số lượng không phù hợp"); return; }
                    if (soLuong > soluong) { MessageBox.Show("Số lượng trong kho không đủ"); return; }
                    using (SqlConnection sql = ConnectData.GetSqlConnection())
                    {
                        sql.Open();
                        string query = "SELECT * FROM tblDonViTinh WHERE sMaSP = @masp AND sTenDVT = @dvt";
                        using (SqlCommand cmd = new SqlCommand(query, sql))
                        {
                            string masp = row.Cells["Column1"].Value.ToString();
                            string dvt = row.Cells["Column3"].Value.ToString();
                            cmd.Parameters.AddWithValue("@masp", masp);
                            cmd.Parameters.AddWithValue("@dvt", dvt);
                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    double giatien = reader.GetDouble(3);
                                    lblDonGia.Text = giatien.ToString();
                                    lblThanhTien.Text = (giatien * int.Parse(txtSoLuong.Text)).ToString();
                                    foreach (SanPham item in list)
                                    {
                                        if (item.MaSP == masp && item.DVT == dvt)
                                        {
                                            int diff = int.Parse(txtSoLuong.Text) - item.SoLuong;
                                            if (diff >= 0)
                                            {
                                                lblTongTien.Text = (double.Parse(lblTongTien.Text) + (giatien * diff)).ToString();
                                            }
                                            else
                                            {
                                                diff *= -1;
                                                lblTongTien.Text = (double.Parse(lblTongTien.Text) - (giatien * diff)).ToString();
                                            }
                                            item.SoLuong = int.Parse(txtSoLuong.Text);
                                        }
                                    }
                                    row.Cells["Column5"].Value = txtSoLuong.Text;
                                }
                            }
                        }
                        sql.Close();
                    }
                }
                catch
                {
                    MessageBox.Show("Số lượng không phù hợp");
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtTenKH.Text == "") { MessageBox.Show("Bạn chưa nhập tên khách hàng"); return; }
            if (txtSDT.Text == "") { MessageBox.Show("Bạn chưa nhập số điện thoại"); return; }
            if (txtTenNV.Text == "") { MessageBox.Show("Tên nhân viên không được để trống"); return; }
            if (txtMaNV.Text == "") { MessageBox.Show("Chưa nhập mã nhân viên"); return; }
            using (SqlConnection sql = ConnectData.GetSqlConnection())
            {
                sql.Open();
                try
                {
                    int? gioitinh = null;
                    if (radNam.Checked == true || radNu.Checked == true)
                    {
                        gioitinh = (radNam.Checked ? 1 : 0);
                    } 

                    using (SqlCommand cmd = new SqlCommand("Tạo hoá đơn", sql))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@mahd", maddh);
                        cmd.Parameters.AddWithValue("@manv", txtMaNV.Text.ToUpper());
                        cmd.Parameters.AddWithValue("@sdt", txtSDT.Text);
                        cmd.Parameters.AddWithValue("@hoten", txtTenKH.Text);
                        cmd.Parameters.AddWithValue("@gioitinh", (object)gioitinh ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@diachi", txtDiaChi.Text);

                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
                foreach(DataGridViewRow row in dgvDanhSach.Rows)
                {
                    string masp = row.Cells["Column1"].Value.ToString();
                    string dvt = row.Cells["Column3"].Value.ToString();
                    double giatien = 0.0;

                    using (SqlCommand cmd = new SqlCommand("Giá tiền", sql))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@masp", masp);
                        cmd.Parameters.AddWithValue("@dvt", dvt);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                giatien = reader.GetDouble(3);
                            }
                        }
                    }

                    using (SqlCommand cmd = new SqlCommand("Thêm hoá đơn", sql))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@mahd", maddh);
                        cmd.Parameters.AddWithValue("@masp",masp);
                        cmd.Parameters.AddWithValue("@soluong",txtSoLuong.Text);
                        cmd.Parameters.AddWithValue("@dvt", dvt);
                        cmd.Parameters.AddWithValue("@giatien", giatien);

                        cmd.ExecuteNonQuery();
                    }
                }
                sql.Close();
                MessageBox.Show("Thêm hoá đơn thành công");
            }
            txtTenKH.Text = "";
            txtSDT.Text = "";
            txtDiaChi.Text = "";
            txtTenNV.Text = "";
            txtMaNV.Text = "";
            radNam.Checked = false;
            radNu.Checked = false;
            lblDonGia.Text = "";
            lblThanhTien.Text = "";
            lblTongTien.Text = "";
            list.Clear();
            dgvDanhSach.DataSource = list;
        }
        
        private void btnHoaDonMoi_Click(object sender, EventArgs e)
        {
            txtSoLuong.Text = "1";
            txtTenKH.Text = "";
            txtSDT.Text = "";
            txtDiaChi.Text = "";
            txtTenNV.Text = "";
            txtMaNV.Text = "";
            radNam.Checked = false;
            radNu.Checked = false;
            lblDonGia.Text = "";
            lblThanhTien.Text = "";
            lblTongTien.Text = "";
            list.Clear();
            dgvDanhSach.DataSource = list;
        }

        private void dgvDanhSach_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvDanhSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Enabled = true;
            using (SqlConnection sql = ConnectData.GetSqlConnection())
            {
                sql.Open();
                string query = "SELECT * FROM tblDonViTinh WHERE sMaSP = @masp AND sTenDVT = @dvt";
                using (SqlCommand cmd = new SqlCommand(query, sql))
                {
                    DataGridViewRow row = dgvDanhSach.SelectedRows[0];
                    string masp = row.Cells["Column1"].Value.ToString();
                    string dvt = row.Cells["Column3"].Value.ToString();
                    cmd.Parameters.AddWithValue("@masp", masp);
                    cmd.Parameters.AddWithValue("@dvt", dvt);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            double giatien = reader.GetDouble(3);
                            lblDonGia.Text = giatien.ToString();
                            lblThanhTien.Text = (giatien * int.Parse(txtSoLuong.Text)).ToString();
                            /*lblTongTien.Text = (double.Parse(lblTongTien.Text) + (giatien * int.Parse(txtSoLuong.Text))).ToString();*/
                            foreach (SanPham item in list)
                            {
                                if (item.MaSP == masp && item.DVT == dvt)
                                {
                                    int diff = int.Parse(txtSoLuong.Text) - item.SoLuong;
                                    if (diff >= 0)
                                    {
                                        lblTongTien.Text = (double.Parse(lblTongTien.Text) + (giatien * diff)).ToString();
                                    }
                                    else
                                    {
                                        diff *= -1;
                                        lblTongTien.Text = (double.Parse(lblTongTien.Text) - (giatien * diff)).ToString();
                                    }
                                    item.SoLuong = int.Parse(txtSoLuong.Text);
                                }
                            }
                            row.Cells["Column5"].Value = txtSoLuong.Text;
                        }
                    }
                }
                sql.Close();
            }
        }

/*        private void dgvDanhSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }*/
    }
}
