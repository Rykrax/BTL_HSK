using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_HSK_ver_1
{
    internal class Account
    {
        private string taiKhoan;
        private string matKhau;

        public Account() { }

        public Account(string taiKhoan, string matKhau)
        {
            this.taiKhoan = taiKhoan;
            this.matKhau = matKhau;
        }

        public string TaiKhoan { get => taiKhoan; set => taiKhoan = value; }
        public string MatKhau { get => matKhau; set => matKhau = value; }
    }
}
