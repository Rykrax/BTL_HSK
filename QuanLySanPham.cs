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
    public partial class frmQuanLySanPham : Form
    {
        public frmQuanLySanPham()
        {
            InitializeComponent();
        }

        private void frmQuanLySanPham_Load(object sender, EventArgs e)
        {
            using (SqlConnection sql = ConnectData.GetSqlConnection())
            {
                sql.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[Danh sách sản phẩm]";
                    cmd.Connection = sql;
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        using (DataTable dt  = new DataTable())
                        {
                            adapter.Fill(dt);
                            dt.Columns["sMaSP"].ColumnName = "Mã sản phẩm";
                            dt.Columns["sTenSP"].ColumnName = "Tên sản phẩm";
                            dt.Columns["sTenHang"].ColumnName = "Loại hàng";

                            dgvDanhSach.DataSource = dt;
                            dgvDanhSach.Columns["Mã sản phẩm"].Width = 150;
                            dgvDanhSach.Columns["Tên sản phẩm"].Width = 300;
                            dgvDanhSach.Columns["Loại hàng"].Width = 200;
                        }
                    }
                }
                string query = "SELECT * FROM tblLoaiHang";
                using (SqlCommand cmd = new SqlCommand(query,sql))
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
            btnXem.Enabled = false;
            btnSua.Enabled = false;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBoLoc_Click(object sender, EventArgs e)
        {
            txtMaSP.Text = "";
            txtTenSP.Text = "";
            cboLoaiHang.Text = "";
            using (SqlConnection sql = ConnectData.GetSqlConnection())
            {
                sql.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[Danh sách sản phẩm]";
                    cmd.Connection = sql;
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            adapter.Fill(dt);
                            dt.Columns["sMaSP"].ColumnName = "Mã sản phẩm";
                            dt.Columns["sTenSP"].ColumnName = "Tên sản phẩm";
                            dt.Columns["sTenHang"].ColumnName = "Loại hàng";

                            dgvDanhSach.DataSource = dt;
                            dgvDanhSach.Columns["Mã sản phẩm"].Width = 150;
                            dgvDanhSach.Columns["Tên sản phẩm"].Width = 300;
                            dgvDanhSach.Columns["Loại hàng"].Width = 200;
                        }
                    }
                }
                sql.Close();
            }
            dgvDanhSach.ClearSelection();
            btnXem.Enabled = false;
            btnSua.Enabled = false;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            using (SqlConnection sql = ConnectData.GetSqlConnection())
            {
                sql.Open();
                string query = "SELECT sMaSP, sTenSP, sTenHang\n" +
                               "FROM tblSanPham AS sp\n" +
                               "JOIN tblLoaiHang AS lh ON sp.sLoaiHang = lh.sLoaiHang\n" +
                               "WHERE 1=1\n";
                if (txtMaSP.Text != "") query += $"\nAND sp.sMaSP LIKE '%{txtMaSP.Text}%'";
                if (txtTenSP.Text != "") query += $"\nAND sp.sTenSP LIKE N'%{txtTenSP.Text}%'";
                if (cboLoaiHang.Text != "") query += $"\nAND lh.sTenHang = N'{cboLoaiHang.Text}'";
                using (SqlCommand cmd = new SqlCommand(query, sql))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            adapter.Fill(dt);
                            dt.Columns["sMaSP"].ColumnName = "Mã sản phẩm";
                            dt.Columns["sTenSP"].ColumnName = "Tên sản phẩm";
                            dt.Columns["sTenHang"].ColumnName = "Loại hàng";

                            dgvDanhSach.DataSource = dt;
                            dgvDanhSach.Columns["Mã sản phẩm"].Width = 150;
                            dgvDanhSach.Columns["Tên sản phẩm"].Width = 300;
                            dgvDanhSach.Columns["Loại hàng"].Width = 200;
                        }
                    }
                }
                sql.Close();
            }
        }

        private void dgvDanhSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvDanhSach_SelectionChanged(object sender, EventArgs e)
        {
            btnXem.Enabled = true;
            btnSua.Enabled = true;
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            if (dgvDanhSach.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvDanhSach.SelectedRows[0];
                if (!selectedRow.IsNewRow)
                {
                    string masp = selectedRow.Cells["Mã sản phẩm"].Value.ToString();
                    frmThongTinSanPham form = new frmThongTinSanPham(masp, false);
                    this.Hide();
                    form.ShowDialog();
                    form = null;
                    this.Show();
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvDanhSach.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvDanhSach.SelectedRows[0];
                if (!selectedRow.IsNewRow)
                {
                    string masp = selectedRow.Cells["Mã sản phẩm"].Value.ToString();
                    frmThongTinSanPham form = new frmThongTinSanPham(masp, true);
                    this.Hide();
                    form.ShowDialog();
                    form = null;
                    this.Show();
                }
            }
        }

        private void dgvDanhSach_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvDanhSach.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvDanhSach.SelectedRows[0];
                if (!selectedRow.IsNewRow)
                {
                    string masp = selectedRow.Cells["Mã sản phẩm"].Value.ToString();
                    frmThongTinSanPham form = new frmThongTinSanPham(masp, false);
                    this.Hide();
                    form.ShowDialog();
                    form = null;
                    this.Show();
                }
            }
        }

        private void dgvDanhSach_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
