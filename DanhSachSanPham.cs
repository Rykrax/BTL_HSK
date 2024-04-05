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
    public partial class frmDanhSachSanPham : Form
    {
        iChuyenDuLieu _ichuyendulieu;
        public frmDanhSachSanPham(iChuyenDuLieu iChuyenDuLieu)
        {
            InitializeComponent();
            this._ichuyendulieu = iChuyenDuLieu;
        }

        private void frmDanhSachSanPham_Load(object sender, EventArgs e)
        {
            using (SqlConnection sql = ConnectData.GetSqlConnection())
            {
                sql.Open();
                string query = "SELECT sp.sMaSP, sp.sTenSP, dvt.sTenDVT, lh.sTenHang\n" +
                               "FROM tblSanPham AS sp\n" +
                               "JOIN tblLoaiHang AS lh ON sp.sLoaiHang = lh.sLoaiHang\n" +
                               "JOIN tblDonViTinh AS dvt ON sp.sMaSP = dvt.sMaSP\n";
                using (SqlCommand cmd = new SqlCommand(query, sql))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            adapter.Fill(dt);
                            dt.Columns["sMaSP"].ColumnName = "Mã sản phẩm";
                            dt.Columns["sTenSP"].ColumnName = "Tên sản phẩm";
                            dt.Columns["sTenDVT"].ColumnName = "Đơn vị tính";
                            dt.Columns["sTenHang"].ColumnName = "Loại hàng";
                            dgvDanhSach.DataSource = dt;
                            dgvDanhSach.Columns["Mã sản phẩm"].Width = 150;
                            dgvDanhSach.Columns["Tên sản phẩm"].Width = 300;
                            dgvDanhSach.Columns["Đơn vị tính"].Width = 200;
                            dgvDanhSach.Columns["Loại hàng"].Width = 200;
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
            dgvDanhSach.ClearSelection();
        }

        private void btnBoLoc_Click(object sender, EventArgs e)
        {
            cboLoaiHang.Text = "";
            txtTenSP.Text = "";
            using (SqlConnection sql = ConnectData.GetSqlConnection())
            {
                sql.Open();
                string query = "SELECT sp.sMaSP, sp.sTenSP, dvt.sTenDVT, lh.sTenHang\n" +
                               "FROM tblSanPham AS sp\n" +
                               "JOIN tblLoaiHang AS lh ON sp.sLoaiHang = lh.sLoaiHang\n" +
                               "JOIN tblDonViTinh AS dvt ON sp.sMaSP = dvt.sMaSP\n";
                using (SqlCommand cmd = new SqlCommand(query, sql))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            adapter.Fill(dt);
                            dt.Columns["sMaSP"].ColumnName = "Mã sản phẩm";
                            dt.Columns["sTenSP"].ColumnName = "Tên sản phẩm";
                            dt.Columns["sTenDVT"].ColumnName = "Đơn vị tính";
                            dt.Columns["sTenHang"].ColumnName = "Loại hàng";

                            dgvDanhSach.DataSource = dt;
                            dgvDanhSach.Columns["Mã sản phẩm"].Width = 150;
                            dgvDanhSach.Columns["Tên sản phẩm"].Width = 300;
                            dgvDanhSach.Columns["Đơn vị tính"].Width = 200;
                            dgvDanhSach.Columns["Loại hàng"].Width = 200;
                        }
                    }
                }
                sql.Close();
            }
            dgvDanhSach.SelectedRows.Clear();
        }

        private void dgvDanhSach_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDanhSach.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvDanhSach.SelectedRows[0];
                if (!selectedRow.IsNewRow)
                {
                    string masp = selectedRow.Cells["Mã sản phẩm"].Value.ToString();
                    string tensp = selectedRow.Cells["Tên sản phẩm"].Value.ToString();
                    string dvt = selectedRow.Cells["Đơn vị tính"].Value.ToString();
                    string loaihang = selectedRow.Cells["Loại hàng"].Value.ToString();
                    int soluong = 0;
                    using (SqlConnection sql = ConnectData.GetSqlConnection())
                    {
                        sql.Open();
                        string query = $"SELECT * FROM tblDonViTinh WHERE sMaSP = '{masp}' AND sTenDVT = N'{dvt}'";
                        using (SqlCommand cmd = new SqlCommand(query, sql))
                        {
                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {
                                if (reader.Read()) soluong = reader.GetInt32(2);
                            }
                        }
                        sql.Close();
                    }
                    _ichuyendulieu.XuLyMaSP(masp, tensp, dvt, loaihang, soluong);
                    this.Close();
                }
            }
        }

        private void dgvDanhSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cboLoaiHang_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
