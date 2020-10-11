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
    public partial class frmDangky : DevExpress.XtraEditors.XtraForm
    {
        clsTaikhoan tk = new clsTaikhoan();
        public frmDangky()
        {
            InitializeComponent();
        }
        void Hienthitaikhoan()
        {
            DataTable dt = tk.LayDSTaiKhoan();
        }
        void setNull()
        {
            txttendangnhap.Text = "";
            txttaikhoan.Text = "";
            txtmadangky.Text = "";
            txtmatkhau.Text = "";

        }

        private void frmDangky_Load(object sender, EventArgs e)
        {
            setNull();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            if (txttendangnhap.Text == "" && txttaikhoan.Text == "" && txtmadangky.Text == "" && txtmatkhau.Text == "") MessageBox.Show("Bạn chưa nhập thông tin đăng ký.", "Thông Báo");
            else if (txttendangnhap.Text == "") MessageBox.Show("Bạn chưa nhập tên đăng nhập.", "Thông Báo");
            else if (txttaikhoan.Text == "") MessageBox.Show("Bạn chưa nhập tài khoản.", "Thông Báo");
            else if (txtmadangky.Text == "") MessageBox.Show("Bạn chưa nhập mã đăng ký.", "Thông Báo");
            else if (txtmatkhau.Text == "") MessageBox.Show("Bạn chưa nhập lại mật khẩu.", "Thông Báo");
            else
            {
                tk.ThemTaiKhoan(txttendangnhap.Text, txttaikhoan.Text, txtmadangky.Text, txtmatkhau.Text);
                MessageBox.Show("Bạn đã đăng ký thành công!");
                Close();
            }
            setNull();
        }
    }
}