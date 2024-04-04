using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BTL_HSK_ver_1
{
    
    public partial class frmNhapHang : Form, iChuyenDuLieu
    {
        List<string> listSP = new List<string>();
        private string madnh;
        public frmNhapHang()
        {
            InitializeComponent();
        }

        public void XuLyMaNV(string manv)
        {
            cboMaNV.Text = manv;            
        }

        public void XuLyMaSP(string masp, string tensp, string dvt, string loaihang, int soluong)
        {

        }
        private void frmNhapHang_Load(object sender, EventArgs e)
        {
            //Tạo mã hdnh ngẫu nhiên :>>
            madnh = SinhMaNgauNhien("HDNH");
            while (true)
            {
                if (KiemTraMa("sMaHDNH", madnh, "tblDonNhapHang") == true)
                {
                    madnh = SinhMaNgauNhien("HDNH");
                }
                else break;
            }
            LoadDuLieu();
        }

        private void LoadDuLieu()
        {
            using (SqlConnection sql = ConnectData.GetSqlConnection())
            {
                sql.Open();
                string query = "SELECT * FROM tblSanPham";
                using (SqlCommand cmd = new SqlCommand(query, sql))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            cboMaSP.Items.Add(reader.GetString(0));
                        }
                    }
                }

                query = "SELECT * FROM tblNhaCungCap";
                using (SqlCommand cmd = new SqlCommand(query, sql))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            cboNCC.Items.Add(reader.GetString(1));
                        }
                    }
                }

                query = "SELECT * FROM tblNhanVien";
                using (SqlCommand cmd = new SqlCommand(query, sql))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            cboMaNV.Items.Add(reader.GetString(0));
                        }
                    }
                }

                query = "SELECT * FROM tblLoaiHang";
                using (SqlCommand cmd = new SqlCommand(query, sql))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            cboLoaiHang.Items.Add(reader.GetString(1));
                        }
                    }
                }
                sql.Close();
            }
        }
        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Bạn có chắc chắn muốn quay lại?"
                , "Xác nhận"
                , MessageBoxButtons.YesNo
                , MessageBoxIcon.Warning);
            if (res == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnNhapTiep_Click(object sender, EventArgs e)
        {
            cboMaSP.Text = "";
            txtTenSP.Text = "";
            txtGiaNhap.Text = "";
            cboLoaiHang.Text = "";
            cboLoaiHang.Items.Clear();
            cboNCC.Text = "";
            nudSoLuong.Value = 0;
            cboDVT.Items.Clear();
            cboNCC.Items.Clear();
            dtpTime.Value = DateTime.Now;
            LoadDuLieu();
        }
        private void btnDonNhapMoi_Click(object sender, EventArgs e)
        {
            madnh = SinhMaNgauNhien("HDNH");
            while (true)
            {
                if (KiemTraMa("sMaHDNH", madnh, "tblDonNhapHang") == true)
                {
                    madnh = SinhMaNgauNhien("HDNH");
                }
                else break;
            }
            cboMaNV.Enabled = true;
            cboMaSP.Text = "";
            txtTenSP.Text = "";
            txtGiaNhap.Text = "";
            cboLoaiHang.Text = "";
            cboNCC.Text = "";
            nudSoLuong.Value = 0;
            cboLoaiHang.Items.Clear();
            cboDVT.Items.Clear();
            cboNCC.Items.Clear();
            cboMaNV.Items.Clear();
            cboMaNV.Text = "";
            txtTen.Text = "";
            dtpTime.Value = DateTime.Now;
            LoadDuLieu();
        }

        private void cboMaNV_TextChanged(object sender, EventArgs e)
        {
            txtTen.Text = "";
            txtTen.ReadOnly = false;
            using (SqlConnection sql = ConnectData.GetSqlConnection())
            {
                sql.Open();
                string query = "SELECT * FROM tblNhanVien WHERE sMaNV = @manv";
                using (SqlCommand cmd = new SqlCommand(query, sql))
                {
                    cmd.Parameters.AddWithValue("@manv", cboMaNV.Text);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            txtTen.ReadOnly = true;
                            txtTen.Text = reader.GetString(1);
                        }
                    }
                }
                sql.Close();
            }
        }

        //Tạo hàm kiểm tra mã với random lỏ :>>
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

        //Xử lý lọc các mã gần giống
        private void cboMaSP_DropDown(object sender, EventArgs e)
        {
            cboMaSP.Items.Clear();
            listSP.Clear();
            string query = "SELECT * FROM tblSanPham";
            using (SqlConnection sql = ConnectData.GetSqlConnection())
            {
                sql.Open();
                using (SqlCommand cmd = new SqlCommand(query, sql))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            cboMaSP.Items.Add(reader.GetString(0));
                            listSP.Add(reader.GetString(0));
                        }
                    }
                }
                sql.Close();
            }
            if (cboMaSP.Text.Trim() != "")
            {
                string masp = cboMaSP.Text.ToLower();
                cboMaSP.Items.Clear();
                foreach (string item in listSP)
                {
                    if (item.ToLower().Contains(masp))
                    {
                        cboMaSP.Items.Add(item);
                    }
                }
            }
        }

        private void cboMaSP_TextChanged(object sender, EventArgs e)
        {
            cboDVT.Text = "";
            cboDVT.Items.Clear();
            txtTenSP.Text = "";
            txtTenSP.ReadOnly = false;
            string query = "";
            using (SqlConnection sql = ConnectData.GetSqlConnection())
            {
                sql.Open();
                query = $"SELECT * FROM tblSanPham WHERE sMaSP = '{cboMaSP.Text}'";
                using (SqlCommand cmd = new SqlCommand(query, sql))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            txtTenSP.ReadOnly = true;
                            txtTenSP.Text = reader.GetString(1);
                        }
                    }
                }

                query = $"SELECT * FROM tblDonViTinh WHERE sMaSP = '{cboMaSP.Text}'";
                using (SqlCommand cmd = new SqlCommand(query, sql))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            cboDVT.Items.Add(reader.GetString(1));
                        }
                    }
                }
                sql.Close();
            }
        }

        private void picDSNV_Click(object sender, EventArgs e)
        {
            frmDanhSachNhanVien form = new frmDanhSachNhanVien(this);
            //this.Hide();
            form.ShowDialog();
            form = null;
            
        }
        private void btnNhapHang_Click(object sender, EventArgs e)
        {
            if (cboMaSP.Text.Trim() == "") { MessageBox.Show("Chưa nhập mã sản phẩm!"); return; }
            if (txtTenSP.Text.Trim() == "") { MessageBox.Show("Chưa nhập tên mã sản phẩm!"); return; }
            if (txtGiaNhap.Text.Trim() == "") { MessageBox.Show("Chưa nhập giá tiền!"); return; }
            if (cboLoaiHang.Text.Trim() == "") { MessageBox.Show("Chưa chọn loại hàng!"); return; }
            if (cboDVT.Text.Trim() == "") { MessageBox.Show("Chưa chọn đơn vị tính"); return; }
            if (cboMaNV.Text.Trim() == "") { MessageBox.Show("Mã nhân viên không được để trống"); return; }
            if (txtTen.Text.Trim() == "") { MessageBox.Show("Tên nhân viên không được để trống"); return; }
            cboMaNV.Enabled = false;
            using (SqlConnection sql = ConnectData.GetSqlConnection())
            {
                sql.Open();
                string query = "";
                string masp = cboMaSP.Text;

                //Lấy mã loại hàng
                string malh = "";
                query = $"SELECT * FROM tblLoaiHang WHERE sTenHang = N'{cboLoaiHang.Text}'";
                using (SqlCommand cmd = new SqlCommand(query, sql))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            malh = reader.GetString(0);
                        }
                    }
                }

                //Xử lý nếu mặt hàng đã tồn tại thì cộng vào kho còn không thì tạo mới
                int i = 0;
                query = $"SELECT COUNT(*) FROM tblDonViTinh WHERE sMaSP = '{masp}' AND sTenDVT = N'{cboDVT.Text}'";
                using (SqlCommand cmd = new SqlCommand(query, sql))
                {
                    i = (int)cmd.ExecuteScalar();
                }

                if (i>0)
                {
                    string soluong = Convert.ToInt32(nudSoLuong.Value).ToString();
                    query = $"UPDATE tblDonViTinh SET iSoLuong = iSoLuong + {soluong} WHERE sMaSP = '{masp}' AND sTenDVT = N'{cboDVT.Text}'";
                    using (SqlCommand cmd = new SqlCommand(query, sql))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
                else
                {
                    query = $"SELECT COUNT(*) FROM tblSanPham WHERE sMaSP = '{masp}'";
                    using (SqlCommand cmd = new SqlCommand(query, sql))
                    {
                        int i1 = (int)cmd.ExecuteScalar();
                        if (i1==0)
                        {
                            query = $"INSERT INTO tblSanPham VALUES ('{masp}',N'{txtTenSP.Text}','{malh}')";
                            using (SqlCommand cmd_sub = new SqlCommand(query, sql))
                            {
                                cmd_sub.ExecuteNonQuery();
                            }
                        }
                    }
                    query = $"INSERT INTO tblDonViTinh " +
                            $"VALUES ('{masp}',N'{cboDVT.Text}',{Convert.ToInt32(nudSoLuong.Value).ToString()}, '{txtGiaNhap.Text}')";
                    using (SqlCommand cmd = new SqlCommand(query, sql))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }

                //Lấy mã nhà cung cấp
                string mancc = "";
                query = $"SELECT * FROM tblNhaCungCap WHERE sTenNCC = N'{cboNCC.Text}'";
                using (SqlCommand cmd = new SqlCommand(query, sql))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            mancc = reader.GetString(0);
                        }
                    }
                }

                DateTime time = dtpTime.Value;
                int ii = 0;
                query = $"SELECT COUNT(*) FROM tblDonNhapHang WHERE sMaHDNH = '{madnh}'";
                using (SqlCommand cmd = new SqlCommand(query,sql))
                {
                    ii = (int)cmd.ExecuteScalar();
                }

                if (ii==0)
                {
                    string ngayThang = time.ToString("yyyy-MM-dd");
                    query = "INSERT INTO tblDonNhapHang " +
                            $"VALUES ('{madnh}','{cboMaNV.Text}','{mancc}','{ngayThang}','0')";
                    using (SqlCommand cmd = new SqlCommand(query, sql))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
                query = "INSERT INTO tblChiTietDNH " +
                        $"VALUES ('{madnh}','{masp}',{Convert.ToInt32(nudSoLuong.Value).ToString()},N'{cboDVT.Text}',{txtGiaNhap.Text})";
                using (SqlCommand cmd = new SqlCommand(query, sql))
                {
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Nhập hàng thành công!");
                cboMaSP.Text = "";
                txtTenSP.Text = "";
                txtGiaNhap.Text = "";
                cboLoaiHang.Text = "";
                cboLoaiHang.Items.Clear();
                cboNCC.Text = "";
                nudSoLuong.Value = 0;
                cboDVT.Items.Clear();
                cboNCC.Items.Clear();
                dtpTime.Value = DateTime.Now;
                LoadDuLieu();
                sql.Close();
            }
        }

        private void nudSoLuong_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
