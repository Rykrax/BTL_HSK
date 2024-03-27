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
    public partial class frmQuenMatKhau : Form
    {
        public frmQuenMatKhau()
        {
            InitializeComponent();
        }
        Modify modify = new Modify();

        private void btnMatKhau_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            if (!RegexCheck.IsEmail(email))
            {
                MessageBox.Show("Email không đúng định dạng!");
            }
            else
            {
                string query = $"SELECT * FROM Account WHERE sEmail = '{email}'";
                if (modify.Accounts(query).Count > 0)
                {
                    MessageBox.Show($"Mật khẩu của bạn là: {modify.Accounts(query)[0].MatKhau}");
                }
                else
                {
                    MessageBox.Show("Email chưa được đăng ký!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
