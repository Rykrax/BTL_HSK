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
    public partial class frmDoiMatKhau : Form
    {
        string cur_acc;
        public frmDoiMatKhau(string cur_acc)
        {
            InitializeComponent();
            this.cur_acc = cur_acc;
        }

        Modify modify = new Modify();
        private void btnThayDoi_Click(object sender, EventArgs e)
        {
            string query = $"SELECT * FROM Account WHERE sTaiKhoan = '{cur_acc}'";
            List<Account> acc = new List<Account>();
            using (SqlConnection sql = ConnectData.GetSqlConnection())
            {
                sql.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = query;
                cmd.Connection = sql;

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    acc.Add(new Account(reader.GetString(0), reader.GetString(1)));
                }
                sql.Close();
            }
            string cur_mk = txtMatKhauHienTai.Text;
            string new_mk = txtMatKhauMoi.Text;
            string confirm = txtXacNhan.Text;
            if (!RegexCheck.IsPassword(cur_mk)) { MessageBox.Show("Vui lòng nhập mật khẩu hiện tại!"); return; }
            if (!RegexCheck.IsPassword(new_mk)) { MessageBox.Show("Vui lòng nhập mật khẩu mới!"); return; }
            if (!RegexCheck.IsPassword(confirm)) { MessageBox.Show("Vui lòng xác nhận mật khẩu!"); return; }
            else
            {
                if (cur_mk != acc[0].MatKhau)
                {
                    MessageBox.Show("Mật khẩu hiện tại không chính xác");
                    return;
                }
                else if (new_mk == acc[0].MatKhau)
                {
                    MessageBox.Show("Mật khẩu mới trùng với mật khẩu hiện tại");
                    return;
                } else if (new_mk != confirm)
                {
                    MessageBox.Show("Mật khẩu xác nhận không chính xác");
                    return;
                }
                else
                {
                    using(SqlConnection sql = ConnectData.GetSqlConnection())
                    {
                        sql.Open();
                        string sub_query = $"UPDATE Account SET sMatKhau = '{new_mk}' WHERE sTaiKhoan = '{cur_acc}'";
                        SqlCommand cmd = new SqlCommand(sub_query, sql);
                        cmd.ExecuteNonQuery();
                        sql.Close();
                    }
                    MessageBox.Show("Đổi mật khẩu thành công!");
                }
            }
        }

        private void frmDoiMatKhau_Load(object sender, EventArgs e)
        {
            txtMatKhauHienTai.PasswordChar = '*';
            txtMatKhauMoi.PasswordChar = '*';
            txtXacNhan.PasswordChar = '*';
        }

        private void chkHienMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHienMatKhau.Checked)
            {
                txtMatKhauHienTai.PasswordChar = '\0';
                txtMatKhauMoi.PasswordChar = '\0';
                txtXacNhan.PasswordChar = '\0';
            }
            else
            {
                txtMatKhauHienTai.PasswordChar = '*';
                txtMatKhauMoi.PasswordChar = '*';
                txtXacNhan.PasswordChar = '*';
            }
        }
    }
}
