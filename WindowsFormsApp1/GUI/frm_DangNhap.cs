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
    public partial class frm_DangNhap : Form
    {
        BLL.bllDangNhap bllDN;
        public frm_DangNhap()
        {
            InitializeComponent();
            bllDN = new BLL.bllDangNhap(this);
        }

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            bllDN.BllDangNhap();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            DialogResult dialog;
            dialog = MessageBox.Show("Bạn có muốn thoát chương trình không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
