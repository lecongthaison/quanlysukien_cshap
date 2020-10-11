using frmQuanLySuKien;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using System.Data.SqlClient;


namespace frmQuanLySuKien
{
    public partial class frmDangNhap : DevExpress.XtraEditors.XtraForm
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-HERA2BI\SQLEXPRESS;Initial Catalog=QUANLYSUKIEN;Integrated Security=True");
        private string getID(string taikhoan, string matkhau)
        {
            string id = "";
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM DANGNHAP WHERE TaiKhoan ='" + txtTaiKhoan.Text + "' and MatKhau ='" + txtMatKhau.Text + "'", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt != null)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        id = dr["MaID"].ToString();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi xảy ra khi truy vấn dữ liệu hoặc kết nối với server thất bại !");
            }
            finally
            {
                con.Close();
            }
            return id;
        }

        public static string ID_USER = "";

        private void btDangNhap_Click(object sender, EventArgs e)
        {
            {
                ID_USER = getID(txtTaiKhoan.Text, txtMatKhau.Text);
                if (ID_USER != "")
                {
                    MessageBox.Show("Chúc mừng bạn đã đăng nhập thành công ^^");
                    //LoadQuanlysukien ld = new LoadQuanlysukien();
                    //ld.Show();
                    //this.Close();
                    frmQuanLySuKien fqlsk = new frmQuanLySuKien();
                    fqlsk.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Tài khoản và mật khẩu không đúng !");
                }
            }
        }

        private void txtTaiKhoan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar) || char.IsLetter(e.KeyChar))
            {
                return;
            }
            e.Handled = true;
        }

        private void btQuenpass_Click(object sender, EventArgs e)
        {
            frmQuenmatkhau f8 = new frmQuenmatkhau();
            f8.Show();
        }

        private void btDangky_Click(object sender, EventArgs e)
        {
            frmDangky f9 = new frmDangky();
            f9.Show();
        }
    }
}

