using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.DAL
{
    internal class dalNhanVien
    {
        LopDungChung lopChung;

        public dalNhanVien()
        {
            lopChung = new LopDungChung();
        }

        public DataTable dalLoad()
        {
            string sqlLoad = "select * from NhanVien";
            return lopChung.loadNV(sqlLoad);
        }

        public void dalThem(string maNV, string hoTen, DateTime ngaySinh, string gioiTinh, string diaChi, DateTime ngayVaoLam, string hinhAnh
            , object maPB, object maBP, object maCV)
        {
            string sqlThem = "insert into NhanVien values('" + maNV + "', N'" + hoTen + "', convert(dateTime,'" +
                ngaySinh + "'), N'" + gioiTinh + "', N'" + diaChi + "', convert(dateTime,'" + ngayVaoLam + "'), '" + hinhAnh + "','" + maPB + "','" + maBP + "','" + maCV + "')";
            lopChung.NonQuery(sqlThem);
        }

        public void dalSua(string maNV, string hoTen, DateTime ngaySinh, string gioiTinh, string diaChi, DateTime ngayVaoLam, string hinhAnh
             , object maPB, object maBP, object maCV)
        {
            string sqlCapNhat = "update NhanVien set HoTen = N'" + hoTen + "', NgaySinh = convert(dateTime,'" +
                ngaySinh + "'), GioiTinh = N'" + gioiTinh + "', DiaChi = N'" + diaChi + "', NgayVaoLam = convert(dateTime,'" + ngayVaoLam + "'), HinhAnh = '" + hinhAnh + "', MaPB = '" + maPB + "', MaBP = '" + maBP + "', MaCV = '" + maCV + "'  where MaNV = '" + maNV + "'";
            lopChung.NonQuery(sqlCapNhat);
        }
        public void dalXoa(string maNV)
        {
            string sqlXoa = "delete from NhanVien where MaNV = '" + maNV + "'";
            lopChung.NonQuery(sqlXoa);
        }

        public object dalDem()
        {
            string sqlDem = "select count (*) from NhanVien";
            return (int)lopChung.Scalar(sqlDem);
        }
    }
}
