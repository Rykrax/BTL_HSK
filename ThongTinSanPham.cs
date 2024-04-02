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
                            //lblSoLuong.Text = reader.GetInt32(2).ToString();
                        }
                    }
                }
                sql.Close();
            }
        }

        private void cboDVT_TextChanged(object sender, EventArgs e)
        {
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
                            txtGiaBan.Text = reader.GetDouble(0).ToString();
                            lblGiaBan.Text = reader.GetDouble(0).ToString();
                            lblGiaNhap.Text = reader.GetDouble(0).ToString();
                        }
                    }
                }
                sql.Close();
            }
        }
    }
}
