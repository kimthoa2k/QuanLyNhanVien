using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.DAL;

namespace WindowsFormsApp1.GUI
{
    public partial class frm_TimKiem : Form
    {
        BLL.bllTimKiem bllTK;
        frm_NhanVien nv;
        public frm_TimKiem()
        {
            InitializeComponent();
            bllTK = new BLL.bllTimKiem(this);
            nv = new frm_NhanVien();
        }

        private void ckb_PB_CheckedChanged(object sender, EventArgs e)
        {
            if (ckb_PB.Checked == true)
                nv.loadCobPB(cob_TPB);
            else
                MessageBox.Show("Xin chọn để tìm kiếm", "Thông báo");
        }

        private void cob_TPB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(ckb_PB.Checked == true)
            {
                try
                {
                    bllTK.bllTKPB();
                }
                catch (Exception )
                {
                    MessageBox.Show("Load dữ liệu không được");
                }
            }
            
        }

        private void ckb_BP_CheckedChanged(object sender, EventArgs e)
        {
            if (ckb_BP.Checked == true)
                nv.loadCobBP(cob_TBP);
            else
                MessageBox.Show("Xin chọn để tìm kiếm", "Thông báo");
        }

        private void cob_TBP_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ckb_BP.Checked == true)
            {
                try
                {
                    bllTK.bllTKBP();
                }
                catch (Exception)
                {
                    MessageBox.Show("Load dữ liệu không được");
                }
            }
        }

        private void ckb_CV_CheckedChanged(object sender, EventArgs e)
        {
            if (ckb_CV.Checked == true)
                nv.loadCobCV(cob_TCV);
            else
                MessageBox.Show("Xin chọn để tìm kiếm", "Thông báo");
        }

        private void cob_TCV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ckb_CV.Checked == true)
            {
                try
                {
                    bllTK.bllTKCV();
                }
                catch (Exception)
                {
                    MessageBox.Show("Load dữ liệu không được");
                }
            }
        }

        private void ckb_HoTen_CheckedChanged(object sender, EventArgs e)
        {
            if (ckb_HoTen.Checked == true)
                nv.loadDataNV();
            else
                MessageBox.Show("Xin chọn để tìm kiếm", "Thông báo");
        }

        private void txt_TimTen_TextChanged(object sender, EventArgs e)
        {
            if (ckb_HoTen.Checked == true)
            {
                try
                {
                    bllTK.bllTimTen();
                }
                catch (Exception)
                {
                    MessageBox.Show("Load dữ liệu không được");
                }
            }
        }
    }
}
