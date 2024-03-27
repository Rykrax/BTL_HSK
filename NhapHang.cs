using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_HSK_ver_1
{
    
    public partial class frmNhapHang : Form
    {
        public frmNhapHang()
        {
            InitializeComponent();
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
            txtTenHang.Text = "";
            cboDVT.Items.Clear();
            txtGiaNhap.Text = "";
            nudSoLuong.Value = 0;
            dtpTime.Value = DateTime.Now;
        }

        private void frmNhapHang_Load(object sender, EventArgs e)
        {
            using (SqlConnection sql = ConnectData.GetSqlConnection())
            {
                sql.Open();
                string query = "SELECT * FROM tblLoaiHang";
                using (SqlCommand cmd = new SqlCommand(query,sql))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while(reader.Read())
                        {
                            cboLoaiHang.Items.Add(reader.GetString(1));
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
                sql.Close();
            }
        }

        private void txtTenHang_TextChanged(object sender, EventArgs e)
        {
            ResetForm();
            using (SqlConnection sql = ConnectData.GetSqlConnection())
            {
                sql.Open();
                string query = "SELECT * FROM tblSanPham WHERE sTenSP = @tensp";
                using (SqlCommand cmd = new SqlCommand(query,sql))
                {
                    cmd.Parameters.AddWithValue("@tensp", txtTenHang.Text);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while( reader.Read())
                        {
                            cboDVT.Items.Add(reader.GetString(3));
                        }
                    }
                }
                sql.Close();
            }
        }

        private void frmNhapHang_TextChanged(object sender, EventArgs e)
        {

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

        private void ResetForm()
        {
            cboDVT.Text = "";
            cboDVT.Items.Clear();
            txtTen.Text = "";
        }

        private void btnNhapHang_Click(object sender, EventArgs e)
        {
            using (SqlConnection sql = ConnectData.GetSqlConnection())
            {
                sql.Open();        
                string query = $"SELECT * FROM tblSanPham WHERE sTenSP = N'{txtTenHang.Text}' AND sDonViTinh = N'{cboDVT.Text}'";
                bool i = false;
                //Lấy mã sản phẩm
                string masp = "";
                using (SqlCommand cmd = new SqlCommand(query,sql))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            masp = reader.GetString(0);
                            i = true;
                        }
                    }
                }

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
                if (i==true)
                {
                    string soluong = Convert.ToInt32(nudSoLuong.Value).ToString();
                    query = $"UPDATE tblSanPham SET iSoLuong = iSoLuong + {soluong} WHERE sMaSP = '{masp}'";
                    using (SqlCommand cmd = new SqlCommand(query,sql))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
                else
                {
                    masp = SinhMaNgauNhien("SP");
                    while(true)
                    {
                        if (KiemTraMa("sMaSP", masp, "tblSanPham") == true)
                        {
                            masp = SinhMaNgauNhien("SP");
                        }
                        else break;
                    }
                    query = "INSERT INTO tblSanPham " +
                           $"VALUES ('{masp}',N'{txtTenHang.Text}','{malh}', N'{cboDVT.Text}', {Convert.ToInt32(nudSoLuong.Value).ToString()}, {txtGiaNhap.Text})";
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
                            i = true;
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
                using (SqlCommand cmd = new SqlCommand(query,sql))
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
        }
    }
}
