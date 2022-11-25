using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.GUI;

namespace WindowsFormsApp1.DAL
{
    internal class dalTimKiem
    {
        LopDungChung lopChung;

        public dalTimKiem()
        {
            lopChung = new LopDungChung();
        }

        public DataTable dalLoad()
        {
            string sqlLoad = "select * from NhanVien";
            return lopChung.loadNV(sqlLoad);
        }

        public DataTable dalLoadPB(object cobTPB)
        {
            string sqlTPB = "select * from NhanVien where MaPB = '" + cobTPB+ "'";
            return lopChung.loadNV(sqlTPB);
        }

        public DataTable dalLoadBP(object cobTBP)
        {
            string sqlTBP = "select * from NhanVien where MaBP = '" + cobTBP + "'";
            return lopChung.loadNV(sqlTBP);
        }
        public DataTable dalLoadCV(object cobTCV)
        {
            string sqlTCV = "select * from NhanVien where MaCV = '" + cobTCV + "'";
            return lopChung.loadNV(sqlTCV);
        }

        public DataTable dalTimTen(object ten)
        {
            string sqlTim = " select * from NhanVien where HoTen like N'%" + ten + "%'";
            return lopChung.loadNV(sqlTim);
        }

    }
}
