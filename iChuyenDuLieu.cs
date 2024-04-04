using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_HSK_ver_1
{
    public interface iChuyenDuLieu
    {
        void XuLyMaNV(string manv);
        void XuLyMaSP(string masp, string tensp, string dvt, string loaihang, int soluong);
    }
}
