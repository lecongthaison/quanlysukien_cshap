using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace frmQuanLySuKien
{
    class Database
    {
        SqlConnection sqlConn;
        SqlDataAdapter da;
        DataSet ds;
        public Database()
        {
            string strCnn = "Data Source=DESKTOP-HERA2BI\\SQLEXPRESS;Initial Catalog=QUANLYSUKIEN;Integrated Security=True"; //Kết nối CSDL
            sqlConn = new SqlConnection(strCnn);
        }
        public DataTable Docbang(string sqlStr) //Đọc bảng
        {
            da = new SqlDataAdapter(sqlStr, sqlConn);
            ds = new DataSet();
            da.Fill(ds);
            return ds.Tables[0];
        }
        public void Thuchien(string strSQL) //Thực hiện
        {
            SqlCommand sqlcmd = new SqlCommand(strSQL, sqlConn);
            sqlConn.Open();
            sqlcmd.ExecuteNonQuery();
            sqlConn.Close();
        }

    }
}
