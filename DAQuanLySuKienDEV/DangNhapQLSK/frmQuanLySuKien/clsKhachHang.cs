using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace frmQuanLySuKien
{
    class clsKhachHang
    {
        Database db;
        public clsKhachHang()
        {
            db = new Database();
        }
        public DataTable LayDSKhachHang()
        {
            string strSQL = "Select MaKhachHang, HoTenKhachHang, Ngaysinh, GioiTinh, Diachi, Email, NgayLapSuKien, NgayHetHan, DienThoai From KhachHang H";
            DataTable dt = new DataTable();
            dt = db.Docbang(strSQL);
            return dt;
        }
        public void XoaKhachHang(string index_kh)
        {
            string sql = "Delete from KhachHang where MaKhachHang = " + index_kh;
            db.Thuchien(sql);
        }
        public void ThemKhachHang(string ten, string ngaysinh, string gioitinh, string diachi, string email, string ngaylapsukien, string ngayhethan, string dienthoai)
        {
            string sql = string.Format("Insert Into KhachHang Values(N'{0}', '{1}', N'{2}', N'{3}', 'N{4}','{5}','{6}','{7}')", ten, ngaysinh, gioitinh, diachi, email, ngaylapsukien, ngayhethan, dienthoai);
            db.Thuchien(sql);
        }
        public void CapNhatKhachHang(string index_kh, string ten, string ngaysinh, string gioitinh, string diachi, string email, string ngaylapsukien, string ngayhethan, string dienthoai)
        {
            string str = string.Format("Update KHACHHANG set HoTenKhachHang = N'{0}', NgaySinh = '{1}', GioiTinh = N'{2}',  DiaChi = N'{3}', Email = N'{4}', NgayLapSuKien = '{5}', NgayHetHan = '{6}', DienThoai = '{7}'  where MaKhachHang = '{8}'", ten, ngaysinh, gioitinh, diachi, email, ngaylapsukien, ngayhethan, dienthoai, index_kh);
            db.Thuchien(str);
        }
    }
}
