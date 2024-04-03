using System;
using System.Collections;
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
    public partial class frmThongTinSanPham : Form
    {
        string masp;
        bool allow;
        public frmThongTinSanPham(string masp, bool allow)
        {
            InitializeComponent();
            this.masp = masp;
            this.allow = allow;
        }

        private void frmThongTinSanPham_Load(object sender, EventArgs e)
        {
            txtGiaBan.Enabled = false;
            btnLuu.Enabled = false;
            if (allow == true)
            {
                txtGiaBan.BringToFront();
            }
            else
            {
                lblGiaBan.BringToFront();
            }
            using (SqlConnection sql = ConnectData.GetSqlConnection())
            {
                sql.Open();
                string query = "SELECT sMaSP, sTenSP, sTenHang\n" +
                               "FROM tblSanPham AS sp\n" +
                               "JOIN tblLoaiHang AS lh ON sp.sLoaiHang = lh.sLoaiHang\n" +
                               $"WHERE sp.sMaSP = '{masp}'";
                using (SqlCommand cmd = new SqlCommand(query, sql))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            lblMaSP.Text = reader.GetString(0);
                            lblTenSP.Text = reader.GetString(1);
                            lblLoaiHang.Text = reader.GetString(2);
                        }   
                    }
                }
                query = "SELECT * FROM tblDonViTinh WHERE sMaSP = @masp";
                using (SqlCommand cmd = new SqlCommand(@query, sql))
                {
                    cmd.Parameters.AddWithValue("@masp", masp);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            cboDVT.Items.Add(reader.GetString(1));
                        }
                    }
                }

                /*query = "SELECT * FROM tblTiLeChuyenDoi WHERE sMaSP = @masp";
                using (SqlCommand cmd = new SqlCommand(query, sql))
                {
                    cmd.Parameters.AddWithValue("@masp", masp);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        int stt = 1;
                        while (reader.Read())
                        {
                            ListViewItem item = lvwDanhSach.Items.Add(stt.ToString());
                            item.SubItems.Add(reader.GetInt32(3).ToString());
                            string s = $"1 {reader.GetString(1).ToString()} = {(reader.GetInt32(3).ToString())} {reader.GetString(2)}";
                            item.SubItems.Add(s);
                            stt++;
                        }
                    }
                }*/
                sql.Close();
            }
        }

        private void cboDVT_TextChanged(object sender, EventArgs e)
        {
            btnLuu.Enabled = true;
            txtGiaBan.Enabled = true;
            using (SqlConnection sql = ConnectData.GetSqlConnection())
            {
                sql.Open();
                string query = "SELECT * FROM tblDonViTinh WHERE sMaSP = @masp AND sTenDVT = @dvt";
                using (SqlCommand cmd = new SqlCommand(query, sql))
                {
                    cmd.Parameters.AddWithValue("@masp", masp);
                    cmd.Parameters.AddWithValue("@dvt", cboDVT.Text);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            lblSoLuong.Text = reader.GetInt32(2).ToString();
                            txtGiaBan.Text = reader.GetDouble(3).ToString();
                            lblGiaBan.Text = reader.GetDouble(3).ToString();
                        }
                    }
                }

                query = "SELECT TOP 1 c.fGiaTien\n" +
                    "FROM tblChiTietDNH c\n" +
                    "JOIN tblDonNhapHang d ON c.sMaHDNH = d.sMaHDNH\n" +
                    $"WHERE c.sMaSP = @masp\n" +
                    $"AND c.sDonViTinh = @dvt\n" +
                    "ORDER BY d.dNgayNhapHang DESC";
                using (SqlCommand cmd = new SqlCommand(query, sql))
                {
                    cmd.Parameters.AddWithValue("@masp", masp);
                    cmd.Parameters.AddWithValue("@dvt", cboDVT.Text);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            lblGiaNhap.Text = reader.GetDouble(0).ToString();
                        }
                    }
                }
                sql.Close();
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                double giaTien = double.Parse(txtGiaBan.Text);
                using (SqlConnection sql = ConnectData.GetSqlConnection())
                {
                    sql.Open();
                    string query = "UPDATE tblDonViTinh\n" +
                                   "SET fGiaTien = @giatien\n" +
                                   "WHERE sMaSP = @masp AND sTenDVT = @dvt";
                    using (SqlCommand cmd = new SqlCommand(@query, sql))
                    {
                        cmd.Parameters.AddWithValue("giatien", giaTien);
                        cmd.Parameters.AddWithValue("@masp", masp);
                        cmd.Parameters.AddWithValue("@dvt", cboDVT.Text);
                        cmd.ExecuteNonQuery();
                    }
                    sql.Close();
                }
                MessageBox.Show("Cập nhật thành công");
            }
            catch
            {
                MessageBox.Show("Giá bán không phù hợp");
                return;
            }
            
        }
    }
}
