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
    public partial class frmTrangChu : Form
    {
        string cur_acc;
        public frmTrangChu(string cur_acc)
        {
            InitializeComponent();
            this.cur_acc = cur_acc;
        }

        private void mnuThoat_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn có chắc chắn muốn thoát?"
                , "Confirm"
                , MessageBoxButtons.YesNo
                , MessageBoxIcon.Warning);
            if (kq == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void mnuDoiMatKhau_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDoiMatKhau form = new frmDoiMatKhau(cur_acc);
            form.ShowDialog();
            form = null;
            this.Show();
        }

        private void mnuDangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mnuKhachHang_Click(object sender, EventArgs e)
        {
            
        }

        private void mnuKhachHang_Click_1(object sender, EventArgs e)
        {
            frmQuanLyKhachHang form = new frmQuanLyKhachHang();
            this.Hide();
            form.ShowDialog();
            form = null;
            this.Show();
        }

        private void QuanLy_Click(object sender, EventArgs e)
        {

        }

        private void nhậpHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNhapHang form = new frmNhapHang();
            this.Hide();
            form.ShowDialog();
            form = null;
            this.Show();
        }

        private void frmTrangChu_Load(object sender, EventArgs e)
        {

        }

        private void thôngTinTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThongTinTaiKhoan form = new frmThongTinTaiKhoan(cur_acc);
            this.Hide();
            form.ShowDialog();
            form = null;
            this.Show();
        }

        private void quảnLýSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuanLySanPham form = new frmQuanLySanPham();
            this.Hide();
            form.ShowDialog();
            form = null;
            this.Show();
        }
    }
}
