using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace frmQuanLySuKien
{
    class clsTaikhoan
    {
        Database db;
        public clsTaikhoan()
        {
            db = new Database();
        }
        public DataTable LayDSTaiKhoan()
        {
            string strSQL = "Select MaID, TenDangNhap, TaiKhoan, MaDangKy, MatKhau From DANGNHAP D";
            DataTable dt = new DataTable();
            dt = db.Docbang(strSQL);
            return dt;
        }
        public void XoaTaiKhoan(string index_tk)
        {
            string sql = "Delete from DANGNHAP where MaID = " + index_tk;
            db.Thuchien(sql);
        }
        public void ThemTaiKhoan(string tendangnhap, string taikhoan, string madangky, string matkhau)
        {
            string sql = string.Format("Insert Into DANGNHAP Values(N'{0}', '{1}', '{2}', '{3}')", tendangnhap, taikhoan, madangky, matkhau);
            db.Thuchien(sql);
        }
        public void CapNhatTaiKhoan(string index_tk, string tendangnhap, string taikhoan, string madangky, string matkhau)
        {
            string str = string.Format("Update DANGNHAP set TenDangNhap = N'{0}', TaiKhoan = '{1}', MaDangKy = '{2}',  MatKhau = '{3}' where MaID = '{4}'", tendangnhap, taikhoan, madangky, matkhau, index_tk);
            db.Thuchien(str);
        }
    }
}


