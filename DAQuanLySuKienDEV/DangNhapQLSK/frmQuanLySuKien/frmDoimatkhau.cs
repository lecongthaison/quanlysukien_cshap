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
    public partial class frmDoimatkhau : DevExpress.XtraEditors.XtraForm
    {
        string strCnn = @"Data Source=DESKTOP-HERA2BI\SQLEXPRESS;Initial Catalog=QUANLYSUKIEN;Integrated Security=True";
        public frmDoimatkhau()
        {
            InitializeComponent();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn = new SqlConnection(strCnn);
            SqlDataAdapter Dadoimatkhau = new SqlDataAdapter("select * from DANGNHAP where TaiKhoan ='" + txtTaikhoan.Text + "'", conn);
            DataTable dtdoimatkhau = new DataTable();
            dtdoimatkhau.Clear();
            Dadoimatkhau.Fill(dtdoimatkhau);
            try
            {
                SqlCommand cmd = new SqlCommand();
                if (txtTaikhoan.Text == "" && txtMatkhaucu.Text == "" && txtMatkhaumoi.Text == "" && txtMatkhaumoi1.Text == "") MessageBox.Show("Bạn chưa nhập thông tin.", "Thông Báo");
                else if (txtTaikhoan.Text == "") MessageBox.Show("Bạn chưa nhập tên tài khoản.", "Thông Báo");
                else if (txtMatkhaucu.Text == "") MessageBox.Show("Bạn chưa nhập mật hiên tại.", "Thông Báo");
                else if (txtMatkhaumoi.Text == "") MessageBox.Show("Bạn chưa nhập mật khẩu mới.", "Thông Báo");
                else if (txtMatkhaumoi1.Text == "") MessageBox.Show("Bạn chưa nhập lại mật khẩu mới.", "Thông Báo");
                else
                    if ((txtTaikhoan.Text == dtdoimatkhau.Rows[0]["TaiKhoan"].ToString()) && (txtMatkhaucu.Text == dtdoimatkhau.Rows[0]["MatKhau"].ToString()) && (txtMatkhaumoi.Text == txtMatkhaumoi1.Text))
                {
                    conn.Open();
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = System.String.Concat("update DANGNHAP set MatKhau =N'" + txtMatkhaumoi.Text + "'where TaiKhoan =N'" + txtTaikhoan.Text + "'");                
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thay đổi mật khẩu thành công!", "Thông Báo");
                    this.Hide();
                    //Xemthongtincanhan m = new Xemthongtincanhan();
                    //m.ShowDialog();
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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmQuenmatkhau f8 = new frmQuenmatkhau();
            f8.Show();
            this.Hide();
        }
    }
    
}