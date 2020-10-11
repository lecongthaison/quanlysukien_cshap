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
    public partial class frmTimkiemnhanvien : DevExpress.XtraEditors.XtraForm
    {
        public frmTimkiemnhanvien()
        {
            InitializeComponent();
        }

        private void bttk_Click(object sender, EventArgs e)
        {
            if (txttt.Text == "") MessageBox.Show("Bạn chưa nhập thông tin cần tìm kiếm.", "Thông Báo");
            {
                if (ramnv.Checked)
                {
                    Database db = new Database();
                    DataTable dt = new DataTable();
                    dt = db.Docbang("SELECT MaNhanVien, HoTenNhanVien, NgaySinh, GioiTinh, DiaChi, DienThoai, TenChucVu  FROM NHANVIEN nv,CHUCVU cv WHERE nv.MaChucVu=cv.MaChucVu AND  nv.MaNhanVien like  '%" + txttt.Text + "%'");
                    dataGridViewnv.DataSource = dt;
                }
                if (ratnv.Checked)
                {
                    Database kn = new Database();
                    DataTable dt = new DataTable();
                    dt = kn.Docbang("SELECT MaNhanVien, HoTenNhanVien, NgaySinh, GioiTinh, DiaChi, DienThoai, TenChucVu  FROM NHANVIEN nv,CHUCVU cv WHERE nv.MaChucVu=cv.MaChucVu AND  nv.HoTenNhanVien like  '%" + txttt.Text + "%'");
                    dataGridViewnv.DataSource = dt;
                }
                if (rasdt.Checked)
                {
                    Database kn = new Database();
                    DataTable dt = new DataTable();
                    dt = kn.Docbang("SELECT MaNhanVien, HoTenNhanVien, NgaySinh, GioiTinh, DiaChi, DienThoai, TenChucVu  FROM NHANVIEN nv,CHUCVU cv WHERE nv.MaChucVu=cv.MaChucVu AND  nv.DienThoai like  '%" + txttt.Text + "%'");
                    dataGridViewnv.DataSource = dt;
                }
            }
        }

        private void btToanbo_Click(object sender, EventArgs e)
        {
            Database db = new Database();
            DataTable dt = new DataTable();
            dt = db.Docbang("SELECT MaNhanVien, HoTenNhanVien, NgaySinh, GioiTinh, DiaChi, DienThoai, TenChucVu  FROM NHANVIEN nv,CHUCVU cv WHERE nv.MaChucVu=cv.MaChucVu");
            dataGridViewnv.DataSource = dt;
        }

        private void frmTimkiemnhanvien_Load(object sender, EventArgs e)
        {

        }
    }
}