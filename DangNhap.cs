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
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void picInvisible_Click(object sender, EventArgs e)
        {
            picVisible.BringToFront();
            txtMatKhau.PasswordChar = '\0';
        }

        private void picVisible_Click(object sender, EventArgs e)
        {
            picInvisible.BringToFront();
            txtMatKhau.PasswordChar = '*';
        }

        private void llbDangKy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtTaiKhoan.Text = "";
            txtMatKhau.Text = "";
            this.Hide();
            frmDangKy form = new frmDangKy();
            form.ShowDialog();
            form = null;
            this.Show();
        }

        private void llbQuenMK_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtTaiKhoan.Text = "";
            txtMatKhau.Text = "";
            this.Hide();
            frmQuenMatKhau form = new frmQuenMatKhau();
            form.ShowDialog();
            form = null;
            this.Show();
        }
        Modify modify = new Modify();

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string tk = txtTaiKhoan.Text;
            string mk = txtMatKhau.Text;
            if (tk.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập tài khoản!");
            }
            else if (mk.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu!");
            }
            else
            {
                string query = $"SELECT * FROM Account WHERE sTaiKhoan = '{tk}' AND sMatKhau = '{mk}'";
                if (modify.Accounts(query).Count > 0)
                {
                    MessageBox.Show("Đăng nhập thành công");
                    this.Hide();
                    frmTrangChu form = new frmTrangChu(tk);
                    txtTaiKhoan.Text = "";
                    txtMatKhau.Text = "";
                    form.ShowDialog();
                    form = null;
                    if (!this.IsDisposed) this.Show();
                } 
                else
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác");
                }
            }
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {

        }

        private void frmDangNhap_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
