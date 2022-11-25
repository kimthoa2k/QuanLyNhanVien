using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1.DAL
{
    internal class LopDungChung
    {
        string chuoiKetNoi = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Documents\HE 2021-2022\DoAnNhom_CS464H\WindowsFormsApp1\WindowsFormsApp1\Database1.mdf;Integrated Security=True";
        SqlConnection conn;
        public LopDungChung()
        {
            conn = new SqlConnection(chuoiKetNoi);
        }

        public DataTable loadNV(string sqlNV)
        {
            SqlDataAdapter da = new SqlDataAdapter(sqlNV, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public void NonQuery(string sql)
        {
            SqlCommand comm = new SqlCommand(sql, conn);
            conn.Open();
            try
            {
                int ketQua = comm.ExecuteNonQuery();
                if (ketQua >= 1)
                    MessageBox.Show("Thành công");
                else
                    MessageBox.Show("Thất bại");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
        }
        public object Scalar(string sql)
        {
            SqlCommand comm = new SqlCommand(sql, conn);
            conn.Open();
            int ketqua = (int)comm.ExecuteScalar();
            conn.Close();
            return ketqua;
        }
    }
}
