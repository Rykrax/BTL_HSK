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
    public partial class frmQuanLyKhachHang : Form
    {
        public frmQuanLyKhachHang()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void grbDanhSach_Enter(object sender, EventArgs e)
        {

        }

        private void frmQuanLyKhachHang_Load(object sender, EventArgs e)
        {
            HienThiDuLieu();
        }

        private void HienThiDuLieu()
        {
            /*using(SqlConnection sql = ConnectData.GetSqlConnection())
            {
                sql.Open();
                string query = "SELECT * FROM tblKhachHang";
                SqlDataAdapter adapter = new SqlDataAdapter(query, sql);
                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);

                DataSet ds = new DataSet();
                adapter.Fill(ds, "tblKhachHang");
                dgvDanhSach.DataSource = ds.Tables["tblKhachHang"];

                sql.Close();
            }*/
        }
    }
}
