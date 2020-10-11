using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace frmQuanLySuKien
{
    class clsSuKien
    {
        Database db;
        public clsSuKien()
        {
            db = new Database();
        }
        public DataTable LayDSSuKien()
        {
            string strSQL = "Select MaSuKien, TenSuKien, NguoiPhuTrach, TriGia, NgayLapSuKien From SuKien S";
            DataTable dt = new DataTable();
            dt = db.Docbang(strSQL);
            return dt;
        }
        public void XoaSuKien(string index_sk)
        {
            string sql = "Delete from SuKien where MaSuKien = " + index_sk;
            db.Thuchien(sql);
        }
        public void ThemSuKien(string tensukien, string nguoiphutrach, string trigia, string ngaylapsukien)
        {
            string sql = string.Format("Insert Into SuKien Values(N'{0}', '{1}', N'{2}', 'N{3}')", tensukien, nguoiphutrach, trigia, ngaylapsukien);
            db.Thuchien(sql);
        }
        public void CapNhatSuKien(string index_sk, string tensukien, string nguoiphutrach, string trigia, string ngaylapsukien)
        {
            string str = string.Format("Update SUKIEN set TenSuKien = N'{0}', NguoiPhuTrach = N'{1}', TriGia = '{2}', NgayLapSuKien = '{3}' where MaSuKien = '{4}'", tensukien, nguoiphutrach, trigia, ngaylapsukien, index_sk);
            db.Thuchien(str);
        }
    }
}
