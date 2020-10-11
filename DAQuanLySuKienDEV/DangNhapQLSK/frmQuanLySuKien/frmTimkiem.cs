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
    public partial class frmTimkiem : DevExpress.XtraEditors.XtraForm
    {
        public frmTimkiem()
        {
            InitializeComponent();
        }

        private void bttk_Click(object sender, EventArgs e)
        {
            if (txttt.Text == "") MessageBox.Show("Bạn chưa nhập thông tin cần tìm kiếm.", "Thông Báo");
            {
                Database kn = new Database();
                DataTable dt = new DataTable();
                if (rakh.Checked)
                {
                    dt = kn.Docbang("SELECT * FROM KHACHHANG WHERE HoTenKhachHang like  N'%" + txttt.Text + "%'");
                    dataGridViewkh.DataSource = dt;
                }
                if (ranv.Checked)
                {
                    dt = kn.Docbang("SELECT * FROM NHANVIEN WHERE HoTenNhanVien like  N'%" + txttt.Text + "%'");
                    dataGridViewkh.DataSource = dt;
                }
                if (rask.Checked)
                {
                    dt = kn.Docbang("SELECT * FROM SUKIEN WHERE TenSuKien like  N'%" + txttt.Text + "%'");
                    dataGridViewkh.DataSource = dt;
                }
            }
        }

        private void btToanbo_Click(object sender, EventArgs e)
        {
            if(rakh.Checked)
            {
                Database db = new Database();
                DataTable dt = new DataTable();
                dt = db.Docbang("SELECT * FROM KHACHHANG");
                dataGridViewkh.DataSource = dt;
            }
            if(ranv.Checked)
            {
                Database db = new Database();
                DataTable dt = new DataTable();
                dt = db.Docbang("SELECT MaNhanVien, HoTenNhanVien, NgaySinh, GioiTinh, DiaChi, DienThoai, TenChucVu  FROM NHANVIEN nv,CHUCVU cv WHERE nv.MaChucVu=cv.MaChucVu");
                dataGridViewkh.DataSource = dt;
            }
            if(rask.Checked)
            {
                Database db = new Database();
                DataTable dt = new DataTable();
                dt = db.Docbang("SELECT * FROM SUKIEN");
                dataGridViewkh.DataSource = dt;
            }
        }

        private void dataGridViewkh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}