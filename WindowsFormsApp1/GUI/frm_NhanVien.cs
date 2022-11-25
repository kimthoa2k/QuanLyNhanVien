using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.DAL;

namespace WindowsFormsApp1.GUI
{
    public partial class frm_NhanVien : Form
    {
        LopDungChung lopChung;
        BLL.bllNhanVien bllNV;
        string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\Images\\";

        public frm_NhanVien()
        {
            InitializeComponent();
            bllNV = new BLL.bllNhanVien(this);
            lopChung = new LopDungChung();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
        public void loadDataNV()
        {
            bllNV.bllLoad();
        }


        private void btn_Them_Click(object sender, EventArgs e)
        {
            try
            {
                pictureBox1.Image.Save(path + txt_TenHinh.Text);
                bllNV.bllThem();
            }
            catch (Exception)
            {
                MessageBox.Show("Nhập tên hình");
            }
            loadDataNV();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            DialogResult dialog;
            dialog = MessageBox.Show("Bạn có muốn sửa không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                try
                {
                    pictureBox1.Image.Save(path + txt_TenHinh.Text);
                    bllNV.bllSua();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                loadDataNV();
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            DialogResult dialog;
            dialog = MessageBox.Show("Bạn có muốn xóa không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                try
                {
                    File.Delete(path + txt_TenHinh.Text);
                    bllNV.bllXoa();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                loadDataNV();
            }
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

        private void btn_Dem_Click(object sender, EventArgs e)
        {
            bllNV.bllDem();
        }

        private void frm_NhanVien_Load(object sender, EventArgs e)
        {
            loadCobPB(cob_PB);
            loadCobBP(cob_BP);
            loadCobCV(cob_CV);
            loadDataNV();
        }

        int chon = 0;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_MaNV.Text = dataGridView1.CurrentRow.Cells["MaNV"].Value.ToString();
            txt_HoTen.Text = dataGridView1.CurrentRow.Cells["HoTen"].Value.ToString();
            dateTimePicker2.Text = dataGridView1.CurrentRow.Cells["NgaySinh"].Value.ToString();
            cob_GioiTinh.Text = dataGridView1.CurrentRow.Cells["GioiTinh"].Value.ToString();
            txt_DiaChi.Text = dataGridView1.CurrentRow.Cells["DiaChi"].Value.ToString();
            dateTimePicker1.Text = dataGridView1.CurrentRow.Cells["NgayVaoLam"].Value.ToString();
            txt_TenHinh.Text = dataGridView1.CurrentRow.Cells["HinhAnh"].Value.ToString();
            pictureBox1.ImageLocation = path + txt_TenHinh.Text;
            chon = 1;
            cob_PB.SelectedValue = dataGridView1.CurrentRow.Cells["MaPB"].Value.ToString();
            chon = 1;
            cob_BP.SelectedValue = dataGridView1.CurrentRow.Cells["MaBP"].Value.ToString();
            chon = 1;
            cob_CV.SelectedValue = dataGridView1.CurrentRow.Cells["MaCV"].Value.ToString();
        }

        private void btn_LaodTable_Click(object sender, EventArgs e)
        {
            loadDataNV();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog OFD = new OpenFileDialog();
            OFD.Title = "Hãy chọn hình";
            OFD.Filter = "Tất cả file |*.*|JPG|*.jpg|PNG|*.png|JPEG|*.jpeg";
            if (OFD.ShowDialog() == DialogResult.OK)
            pictureBox1.Image = Image.FromFile(OFD.FileName);
        }

        public void loadCobPB(ComboBox cobPB)
        {
            try
            {
                string sqlCobPB = "select * from PhongBan";
                cobPB.DataSource = lopChung.loadNV(sqlCobPB);
                cobPB.DisplayMember = "TenPB";
                cobPB.ValueMember = "MaPB";
            }
            catch (Exception)
            {
                MessageBox.Show("Load dữ liệu không được");
            }
        }

        public void loadCobBP(ComboBox cobBP)
        {
            try
            {
                string sqlCobBP = "select * from BoPhan";
                cobBP.DataSource = lopChung.loadNV(sqlCobBP);
                cobBP.DisplayMember = "TenBP";
                cobBP.ValueMember = "MaBP";
            }
            catch (Exception)
            {
                MessageBox.Show("Load dữ liệu không được");
            }

        }

        public void loadCobCV(ComboBox cobCV)
        {
            try
            {
                string sqlCobCV = "select * from ChucVu";
                cobCV.DataSource = lopChung.loadNV(sqlCobCV);
                cobCV.DisplayMember = "TenCV";
                cobCV.ValueMember = "MaCV";
            }
            catch (Exception)
            {
                MessageBox.Show("Load dữ liệu không được");
            }

        }

        private void cob_PB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cob_PB.SelectedValue != null && chon == 0)
            {
                string textPB = cob_PB.GetItemText(cob_PB.SelectedValue).ToString();
                string sqlPB = "select * from PhongBan where MaPB = '" + textPB + "'";
                dataGridView1.DataSource = lopChung.loadNV(sqlPB);
            }
            if (chon == 1) chon = 0;
        }

        private void cob_BP_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cob_BP.SelectedValue != null && chon == 0)
            {
                string textBP = cob_BP.GetItemText(cob_BP.SelectedValue).ToString();
                string sqlBP = "select * from BoPhan where MaBP = '" + textBP + "'";
                dataGridView1.DataSource = lopChung.loadNV(sqlBP);
            }
            if (chon == 1) chon = 0;
        }

        private void cob_CV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cob_CV.SelectedValue != null && chon == 0)
            {
                string textCV = cob_CV.GetItemText(cob_CV.SelectedValue).ToString();
                string sqlCV = "select * from ChucVu where MaCV = '" + textCV + "'";
                dataGridView1.DataSource = lopChung.loadNV(sqlCV);
            }
            if (chon == 1) chon = 0;
        }

        private void btn_Tim_Click(object sender, EventArgs e)
        {
            frm_TimKiem tk = new frm_TimKiem();
            tk.Show();
        }
    }
}
