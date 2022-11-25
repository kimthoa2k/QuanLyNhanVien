using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.GUI;

namespace WindowsFormsApp1.BLL
{
    internal class bllTimKiem
    {
        DAL.dalTimKiem dalTK = new DAL.dalTimKiem();
        frm_TimKiem tk;

        public bllTimKiem(frm_TimKiem ftk)
        {
            tk = ftk;
        }

        public void bllLoad()
        {
            tk.dataGridView2.DataSource = dalTK.dalLoad();
        }

        public void bllTKPB()
        {
            tk.dataGridView2.DataSource = dalTK.dalLoadPB(tk.cob_TPB.SelectedValue);
        }

        public void bllTKBP()
        {
            tk.dataGridView2.DataSource = dalTK.dalLoadBP(tk.cob_TBP.SelectedValue);
        }
        public void bllTKCV()
        {
            tk.dataGridView2.DataSource = dalTK.dalLoadCV(tk.cob_TCV.SelectedValue);
        }

        public void bllTimTen()
        {
            tk.dataGridView2.DataSource = dalTK.dalTimTen(tk.txt_TimTen.Text.Trim());
        }
    }
}
