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

namespace BTL_HSK_ver_1
{
    
    public partial class frmNhapHang : Form
    {
        List<string> listSP = new List<string>();  
        public frmNhapHang()
        {
            InitializeComponent();
        }

        private void frmNhapHang_Load(object sender, EventArgs e)
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

        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            cboMaSP.Text = "";
            txtTenSP.Text = "";
            txtGiaNhap.Text = "";
            cboLoaiHang.Text = "";
            cboLoaiHang.Items.Clear();
            cboNCC.Text = "";
            nudSoLuong.Value = 0;
            cboDVT.Items.Clear();
            cboMaNV.Text = "";
            txtTen.Text = "";
            dtpTime.Value = DateTime.Now;
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

        //Tạo hàm kiểm tra mã với random vjp lỏ :>>
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            /*if (KiemTraMa("sMaSP", "SP001", "tblSanPham"))
            {
                MessageBox.Show("Đã tồn tại");
            }
            else MessageBox.Show("Chưa tồn tại");*/
            /* string madnh = SinhMaNgauNhien("HDNH");
             while (true)
             {
                 if (KiemTraMa("sMaHDNH", madnh, "tblDonNhapHang") == true)
                 {
                     madnh = SinhMaNgauNhien("HDNH");
                 }
                 else break;

             }
            */
            //MessageBox.Show(cboDVT.Text);
            frmDanhSachNhanVien form = new frmDanhSachNhanVien();
            //this.Hide();
            form.ShowDialog();
            form = null;
        }
        private void btnNhapHang_Click(object sender, EventArgs e)
        {
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

                //Tạo mã hdnh ngẫu nhiên :>>
                string madnh = SinhMaNgauNhien("HDNH");
                while (true)
                {
                    if (KiemTraMa("sMaHDNH", madnh, "tblDonNhapHang") == true)
                    {
                        madnh = SinhMaNgauNhien("HDNH");
                    }
                    else break;

                }
                DateTime time = dtpTime.Value;
                string ngayThang = time.ToString("yyyy-MM-dd");
                query = "INSERT INTO tblDonNhapHang " +
                        $"VALUES ('{madnh}','{cboMaNV.Text}','{mancc}','{ngayThang}','0')";
                using (SqlCommand cmd = new SqlCommand(query, sql))
                {
                    cmd.ExecuteNonQuery();
                }
                query = "INSERT INTO tblChiTietDNH " +
                        $"VALUES ('{madnh}','{masp}',{Convert.ToInt32(nudSoLuong.Value).ToString()},N'{cboDVT.Text}',{txtGiaNhap.Text})";
                using (SqlCommand cmd = new SqlCommand(query, sql))
                {
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Nhập hàng thành công!");
                sql.Close();
            }
        }
    }
}
