using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.GUI
{
    public partial class frm_QuanLyNhanVien : Form
    {
        public frm_QuanLyNhanVien()
        {
            InitializeComponent();
        }

        private void thôngTinNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_NhanVien"] == null)
            {
                frm_NhanVien nv = new frm_NhanVien();
                nv.MdiParent = this;
                nv.Show();
            }
            else Application.OpenForms["frm_NhanVien"].Activate();
        }

        private void tìmKiếmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_TimKiem"] == null) 
            {
                frm_TimKiem tk = new frm_TimKiem();
                tk.MdiParent = this;
                tk.Show();
            }
            else Application.OpenForms["frm_TimKiem"].Activate();
        }
    }
}
