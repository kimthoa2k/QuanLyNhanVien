using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.GUI;

namespace WindowsFormsApp1.DAL
{
    internal class dalDangNhap
    {
        LopDungChung lopChung;
        public dalDangNhap()
        {
            lopChung = new LopDungChung();
        }

        public void DalDangNhap(string tenDN, string matKhau)
        {
            string sqlDangNhap = "select count (*) from DangNhap where TenDN = N'" + tenDN + "' and MatKhau = N'" + matKhau + "'";

            int kq = (int)lopChung.Scalar(sqlDangNhap);
            if (kq >= 1)
            {
                frm_QuanLyNhanVien nv = new frm_QuanLyNhanVien();
                nv.Show();
            }
            else MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu");
        }
    }
}
