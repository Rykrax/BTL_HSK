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
    public partial class frmDanhSachNhanVien : Form
    {
        private iChuyenDuLieu _ichuyendulieu;
        public frmDanhSachNhanVien()
        {
            InitializeComponent();
        }

        public frmDanhSachNhanVien(iChuyenDuLieu ichuyendulieu) 
        {
            InitializeComponent();
            this._ichuyendulieu = ichuyendulieu;
        }

        private void btnBoLocGT_Click(object sender, EventArgs e)
        {
            radNam.Checked = false;
            radNu.Checked = false;
        }

        private void btnBoLocTen_Click(object sender, EventArgs e)
        {
            txtTenNV.Text = "";
        }

        private void btnBoChon_Click(object sender, EventArgs e)
        {
            radNam.Checked = false;
            radNu.Checked = false;
            txtTenNV.Text = "";
        }

        private void dgvDanhSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        public void LoadForm()
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection sql = ConnectData.GetSqlConnection())
            {
                sql.Open();
                string query = "SELECT sMaNV, sHoTen, CASE WHEN bGioiTinh = 1 THEN 'Nam' ELSE N'Nữ' END AS bGioiTinh, dNgayVaoLam, fLuongCoBan FROM tblNhanVien WHERE 1 = 1";
                if (txtTenNV.Text.Trim() != "") query += " AND sHoTen COLLATE Vietnamese_CI_AI LIKE @tennv";
                if (radNam.Checked == true)
                {
                    query += " AND bGioiTinh = 1";
                }
                else if (radNu.Checked == true)
                {
                    query += " AND bGioiTinh = 0";
                }
                using (SqlCommand cmd = new SqlCommand(query,sql))
                {
                    cmd.Parameters.AddWithValue("@tennv", "%" + txtTenNV.Text + "%");
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(dataTable);
                        dataTable.Columns["sMaNV"].ColumnName = "Mã nhân viên";
                        dataTable.Columns["sHoTen"].ColumnName = "Họ tên";
                        dataTable.Columns["bGioiTinh"].ColumnName = "Giới tính";
                        dataTable.Columns["dNgayVaoLam"].ColumnName = "Ngày vào làm";
                        dataTable.Columns["fLuongCoBan"].ColumnName = "Lương cơ bản";
               
                        dgvDanhSach.DataSource = dataTable;
                        dgvDanhSach.Columns["Mã nhân viên"].Width = 150;
                        dgvDanhSach.Columns["Họ tên"].Width = 220;
                        dgvDanhSach.Columns["Giới tính"].Width = 130;
                        dgvDanhSach.Columns["Ngày vào làm"].Width = 150;
                        dgvDanhSach.Columns["Lương cơ bản"].Width = 180;
                    }
                }
                sql.Close();
            }
        }

        private void frmDanhSachNhanVien_Load(object sender, EventArgs e)
        {
            LoadForm();
        }

        private void txtTenNV_TextChanged(object sender, EventArgs e)
        {
            LoadForm();
        }

        private void radNu_CheckedChanged(object sender, EventArgs e)
        {
            LoadForm();
        }

        private void radNam_CheckedChanged(object sender, EventArgs e)
        {
            LoadForm();
        }

        private void dgvDanhSach_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
           /* if (dgvDanhSach.Columns[e.ColumnIndex].Name == "Giới tính" && e.Value != null)
            {
                // Chuyển đổi giá trị của cột "Giới tính" từ số sang chuỗi
                if ((int)e.Value == 1)
                {
                    e.Value = "Nam";
                }
                else if ((int)e.Value == 0)
                {
                    e.Value = "Nữ";
                }
            }*/
        }

        private void dgvDanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                int index = e.RowIndex;
                DataGridViewRow row = dgvDanhSach.Rows[index];
                try
                {
                    string manv = dgvDanhSach.Rows[index].Cells[0].Value.ToString();
                    _ichuyendulieu.XuLyMaNV(manv);
                    this.Close();
                }
                catch
                {
                    MessageBox.Show("Không có dữ liệu", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
