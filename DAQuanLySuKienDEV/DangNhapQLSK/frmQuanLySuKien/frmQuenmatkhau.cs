using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;

namespace frmQuanLySuKien
{
    public partial class frmQuenmatkhau : DevExpress.XtraEditors.XtraForm
    {
        string strCnn = @"Data Source=DESKTOP-HERA2BI\SQLEXPRESS;Initial Catalog=QUANLYSUKIEN;Integrated Security=True";
        public frmQuenmatkhau()
        {
            InitializeComponent();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn = new SqlConnection(strCnn);
            SqlDataAdapter Dalaymatkhau = new SqlDataAdapter("select * from DANGNHAP where TaiKhoan ='" + txtTaikhoanq.Text + "'", conn);
            DataTable dtlaymatkhau = new DataTable();
            dtlaymatkhau.Clear();
            Dalaymatkhau.Fill(dtlaymatkhau);
            try
            {
                SqlCommand cmd = new SqlCommand();
                if (txtTaikhoanq.Text == "" && txtMadangky.Text == "" && txtMatkhaumoiq.Text == "" && txtMatkhaumoi1q.Text == "") MessageBox.Show("Bạn chưa nhập thông tin.", "Thông Báo");
                else if (txtTaikhoanq.Text == "") MessageBox.Show("Bạn chưa nhập tên tài khoản.", "Thông Báo");
                else if (txtMadangky.Text == "") MessageBox.Show("Bạn chưa nhập mã đăng ký.", "Thông Báo");
                else if (txtMatkhaumoiq.Text == "") MessageBox.Show("Bạn chưa nhập mật khẩu mới.", "Thông Báo");
                else if (txtMatkhaumoi1q.Text == "") MessageBox.Show("Bạn chưa nhập lại mật khẩu mới.", "Thông Báo");
                else
                    if ((txtTaikhoanq.Text == dtlaymatkhau.Rows[0]["TaiKhoan"].ToString()) && (txtMatkhaumoiq.Text == txtMatkhaumoi1q.Text))
                {
                    conn.Open();
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = System.String.Concat("update DANGNHAP set MatKhau =N'" + txtMatkhaumoiq.Text + "'where TaiKhoan =N'" + txtTaikhoanq.Text + "'");
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thay đổi mật khẩu thành công!", "Thông Báo");
                    this.Hide();
                    this.Close();
                }
                else
                { MessageBox.Show("Tên hoặc mật khẩu nhập không đúng!", "thông báo"); }
            }
            catch (SqlException)
            {
                MessageBox.Show("Có lỗi xảy ra, vui lòng xem lại thông tin nhập!", "Thông báo");
            }
            conn.Close();
        }
    }
}