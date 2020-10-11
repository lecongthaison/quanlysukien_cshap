using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace frmQuanLySuKien
{
    class clsNhanvien
    {
        Database db;
        public clsNhanvien()
        {
            db = new Database();
        }
        public DataTable LayDSNhanvien()
        {
            string strSQL = "Select Manhanvien, HoTenNhanVien, Ngaysinh, GioiTinh, Diachi, Dienthoai, TenChucvu From Nhanvien N, CHUCVU B Where N.MaChucVu=B.MaChucVu";
            DataTable dt = new DataTable();
            dt = db.Docbang(strSQL);
            return dt;
        }
        public DataTable LayChucvu()
        {
            string strSQL = "Select * from chucvu";
            DataTable dt = db.Docbang(strSQL);
            return dt;
        }
        public void XoaNhanVien(string index_nv)
        {
            string sql = "Delete from NhanVien where MaNhanVien = " + index_nv;
            db.Thuchien(sql);
        }
        public void ThemNhanVien(string ten, string ngaysinh, string diachi, string gioitinh, string dienthoai, string index_cv)
        {
            string sql = string.Format("Insert Into NHANVIEN Values(N'{0}', '{1}', N'{2}', N'{3}', '{4}','{5}')", ten, ngaysinh, gioitinh, diachi, dienthoai, index_cv);
            db.Thuchien(sql);
        }
        public void CapNhatNhanVien(string index_nv, string hoten, string ngaysinh, string gioitinh, string diachi, string dienthoai, string index_cv)
        {
            string str = string.Format("Update NHANVIEN set HoTenNhanVien = N'{0}', NgaySinh = '{1}', Gioitinh = N'{2}', diachi = N'{3}',dienthoai = '{4}', MaChucVu = '{5}'  where MaNhanVien = '{6}'", hoten, ngaysinh, gioitinh, diachi, dienthoai, index_cv, index_nv);
            db.Thuchien(str);
        }


    }
}
