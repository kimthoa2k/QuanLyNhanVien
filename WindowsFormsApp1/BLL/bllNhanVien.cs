using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.GUI;

namespace WindowsFormsApp1.BLL
{
    internal class bllNhanVien
    {
        DAL.dalNhanVien dalNV = new DAL.dalNhanVien();
        frm_NhanVien nv;

        public bllNhanVien(frm_NhanVien fnv)
        {
            nv = fnv;
        }

        public void bllLoad()
        {
            nv.dataGridView1.DataSource = dalNV.dalLoad();
        }

        public void bllThem()
        {
            dalNV.dalThem(nv.txt_MaNV.Text, nv.txt_HoTen.Text, nv.dateTimePicker2.Value, nv.cob_GioiTinh.Text, nv.txt_DiaChi.Text, nv.dateTimePicker1.Value, nv.txt_TenHinh.Text,
                nv.cob_PB.SelectedValue, nv.cob_BP.SelectedValue, nv.cob_CV.SelectedValue);
        }

        public void bllSua()
        {
            dalNV.dalSua(nv.txt_MaNV.Text, nv.txt_HoTen.Text, nv.dateTimePicker2.Value, nv.cob_GioiTinh.Text, nv.txt_DiaChi.Text, nv.dateTimePicker1.Value, nv.txt_TenHinh.Text,
                nv.cob_PB.SelectedValue, nv.cob_BP.SelectedValue, nv.cob_CV.SelectedValue);
        }

        public void bllXoa()
        {
            dalNV.dalXoa(nv.txt_MaNV.Text);
        }

        public void bllDem()
        {
            nv.txt_dem.Text = dalNV.dalDem().ToString();
        }
    }
}
