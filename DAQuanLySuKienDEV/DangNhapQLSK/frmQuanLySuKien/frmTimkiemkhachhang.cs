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
    public partial class frmTimkiemkhachhang : DevExpress.XtraEditors.XtraForm
    {
        public frmTimkiemkhachhang()
        {
            InitializeComponent();
        }
        private void bttk_Click(object sender, EventArgs e)
        {
            if (txttt.Text == "") MessageBox.Show("Bạn chưa nhập thông tin cần tìm kiếm.", "Thông Báo");
            {
                if (ramkh.Checked)
                {
                    Database db = new Database();
                    DataTable dt = new DataTable();
                    dt = db.Docbang("SELECT * FROM KHACHHANG WHERE MaKhachHang like  '%" + txttt.Text + "%'");
                    dataGridViewkh.DataSource = dt;
                }
                if (ratkh.Checked)
                {
                    Database kn = new Database();
                    DataTable dt = new DataTable();
                    dt = kn.Docbang("SELECT * FROM KHACHHANG WHERE HoTenKhachHang like  N'%" + txttt.Text + "%'");
                    dataGridViewkh.DataSource = dt;
                }
                if (rasdt.Checked)
                {
                    Database kn = new Database();
                    DataTable dt = new DataTable();
                    dt = kn.Docbang("SELECT * FROM KHACHHANG WHERE DienThoai like  '%" + txttt.Text + "%'");
                    dataGridViewkh.DataSource = dt;
                }
            }
        }
        private void btToanbo_Click(object sender, EventArgs e)
        {
            Database db = new Database();
            DataTable dt = new DataTable();
            dt = db.Docbang("SELECT * FROM KHACHHANG");
            dataGridViewkh.DataSource = dt;
        }
    }
}