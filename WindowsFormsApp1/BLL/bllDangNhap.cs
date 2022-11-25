using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.GUI;

namespace WindowsFormsApp1.BLL
{
    internal class bllDangNhap
    {
        DAL.dalDangNhap dalDN = new DAL.dalDangNhap();
        frm_DangNhap dn;
        public bllDangNhap(frm_DangNhap fdn)
        {
            dn = fdn;
        }
        public void BllDangNhap()
        {
            dalDN.DalDangNhap(dn.txt_TenDN.Text, dn.txt_MatKhau.Text);
        }
    }
}
