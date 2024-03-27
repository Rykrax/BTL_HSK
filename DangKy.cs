using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_HSK_ver_1
{
    public partial class frmDangKy : Form
    {
        public frmDangKy()
        {
            InitializeComponent();
        }

        private void frmDangKy_Load(object sender, EventArgs e)
        {
            txtMatKhau.PasswordChar = '*';
            txtXacNhan.PasswordChar = '*';
        }

        private void chkHienMK_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHienMK.Checked)
            {
                txtMatKhau.PasswordChar = '\0';
                txtXacNhan.PasswordChar = '\0';
            }
            else
            {
                txtMatKhau.PasswordChar = '*';
                txtXacNhan.PasswordChar = '*';
            }
        }
        Modify modify = new Modify();

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            string tk = txtTaiKhoan.Text;
            string mk = txtMatKhau.Text;
            string xn = txtXacNhan.Text;
            string email = txtEmail.Text;
            if (!RegexCheck.IsAccount(tk)) { MessageBox.Show("Vui lòng nhập tài khoản dài 6-32 kí tự, bao gồm kí tự chữ và số"); return; }
            if (!RegexCheck.IsAccount(mk)) { MessageBox.Show("Vui lòng nhập mật khẩu dài 6-32 kí tự, bao gồm kí tự chữ và số"); return; }
            if (!RegexCheck.IsAccount(mk)) { MessageBox.Show("Vui lòng xác nhận mật khẩu dài 6-32 kí tự, bao gồm kí tự chữ và số"); return; }
            else
            {
                if (mk.Trim() != xn.Trim()) { MessageBox.Show("Mật khẩu xác nhận không chính xác"); return; }
            }
            if (!RegexCheck.IsEmail(email)) { MessageBox.Show("Vui lòng nhập đúng định dạng email"); return; }
            if (modify.Accounts($"SELECT * FROM Account WHERE sEmail = '{email}'").Count != 0)
            {
                MessageBox.Show("Email đã tồn tại!");
                return;
            }
            try
            {
                string query = $"INSERT INTO Account VALUES ('{tk}','{mk}','{email}')";
                modify.Command(query);
                MessageBox.Show("Đăng ký tài khoản thành công!");
                this.Close();
            }
            catch
            {
                MessageBox.Show("Tên tài khoản đã tồn tại, vui lòng đăng kí bằng tên tài khoản khác");
            }
        }
    }
}
