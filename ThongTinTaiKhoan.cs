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
    public partial class frmThongTinTaiKhoan : Form
    {
        private string tk;

        public frmThongTinTaiKhoan(string tk)
        {
            InitializeComponent();
            this.tk = tk;
        }

        private void frmThongTinTaiKhoan_Load(object sender, EventArgs e)
        {
            using (SqlConnection sql = ConnectData.GetSqlConnection())
            {
                sql.Open();
                string query = $"SELECT * FROM Account WHERE sTaiKhoan = '{tk}'";
                using (SqlCommand cmd = new SqlCommand(query,sql))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            lblTaiKhoan.Text = reader.GetString(0);
                            lblMatKhau.Text = reader.GetString(1);
                            lblEmail.Text = reader.GetString(2);
                        }
                    }
                }
                sql.Close();
            }
        }
    }
}
