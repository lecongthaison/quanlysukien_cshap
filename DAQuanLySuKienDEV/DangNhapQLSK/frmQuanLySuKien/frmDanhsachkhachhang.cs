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
    public partial class frmDanhsachkhachhang : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        bool cothem;
        clsKhachHang kh = new clsKhachHang();
        public frmDanhsachkhachhang()
        {
            InitializeComponent();
        }
        void Hienthikhachhang()
        {
            DataTable dt = kh.LayDSKhachHang();
            lsvKhachHang.Items.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lvi = lsvKhachHang.Items.Add(dt.Rows[i][0].ToString());
                lvi.SubItems.Add(dt.Rows[i][1].ToString());
                lvi.SubItems.Add(dt.Rows[i][2].ToString());
                lvi.SubItems.Add(dt.Rows[i][3].ToString());
                lvi.SubItems.Add(dt.Rows[i][4].ToString());
                lvi.SubItems.Add(dt.Rows[i][5].ToString());
                lvi.SubItems.Add(dt.Rows[i][6].ToString());
                lvi.SubItems.Add(dt.Rows[i][7].ToString());
                lvi.SubItems.Add(dt.Rows[i][8].ToString());
            }
        }
        void setNull()
        {
            txtHoten1.Text = "";
            txtDiaChi1.Text = "";
            txtDienThoai1.Text = "";
            txtEmail1.Text = "";

        }
        void setButton(bool val)
        {
            btnThem.Enabled = val;
            btnXoa.Enabled = val;
            btnSua.Enabled = val;
            btnThoat.Enabled = val;
            btnLuu.Enabled = !val;
            btnHuy.Enabled = !val;
        }
        public void Khoa(bool a)
        {
            txtHoten1.ReadOnly = a;
            txtDiaChi1.ReadOnly = a;
            txtDienThoai1.ReadOnly = a;
            txtEmail1.ReadOnly = a;
        }

        private void lsvKhachHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvKhachHang.SelectedIndices.Count > 0)
            {
                txtHoten1.Text = lsvKhachHang.SelectedItems[0].SubItems[1].Text;
                dtpNgaySinh1.Value = DateTime.Parse(lsvKhachHang.SelectedItems[0].SubItems[2].Text);
                cbGioitinhKh.SelectedIndex = 1;
                txtDiaChi1.Text = lsvKhachHang.SelectedItems[0].SubItems[4].Text;
                txtEmail1.Text = lsvKhachHang.SelectedItems[0].SubItems[5].Text;
                dateNgayLap1.Value = DateTime.Parse(lsvKhachHang.SelectedItems[0].SubItems[6].Text);
                dateNgayhet1.Value = DateTime.Parse(lsvKhachHang.SelectedItems[0].SubItems[7].Text);
                txtDienThoai1.Text = lsvKhachHang.SelectedItems[0].SubItems[8].Text;
                string gt = lsvKhachHang.SelectedItems[0].SubItems[3].Text;
                if (gt == "Nam")
                {
                    cbGioitinhKh.SelectedIndex = 0;
                }
            }
        }

        private void btnThem_ItemClick(object sender, ItemClickEventArgs e)
        {
            cothem = true;
            setButton(false);
            Khoa(false);
            setNull();
            txtHoten1.Focus();
        }

        private void btnSua_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (lsvKhachHang.SelectedIndices.Count > 0)
            {
                cothem = false;
                setButton(false);
                Khoa(false);
                txtHoten1.Focus();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn 1 Khách hàng", "Thộng báo");
            }
        }

        private void btnThoat_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnHuy_ItemClick(object sender, ItemClickEventArgs e)
        {
            setButton(true);
            setNull();
            Khoa(true);
        }

        private void btnLuu_ItemClick(object sender, ItemClickEventArgs e)
        {
            string ngay = String.Format("{0:MM/dd/yyyy}", dtpNgaySinh1.Value);
            string ngay1 = String.Format("{0:MM/dd/yyyy}", dateNgayLap1.Value);
            string ngay2 = String.Format("{0:MM/dd/yyyy}", dateNgayhet1.Value);
            if (cothem)
            {
                string a = cbGioitinhKh.SelectedValue.ToString();
                kh.ThemKhachHang(txtHoten1.Text, ngay, cbGioitinhKh.SelectedValue.ToString(), txtDiaChi1.Text, txtEmail1.Text, ngay1, ngay2, txtDienThoai1.Text);
                MessageBox.Show("Thêm mới thành công");
            }
            else
            {
                kh.CapNhatKhachHang(lsvKhachHang.SelectedItems[0].SubItems[0].Text, txtHoten1.Text, ngay, cbGioitinhKh.SelectedValue.ToString(), txtDiaChi1.Text, txtEmail1.Text, ngay1, ngay2, txtDienThoai1.Text);
                MessageBox.Show("Cập nhật thành công");
            }
            Hienthikhachhang();
            setNull();
            setButton(true);
            Khoa(true);
        }

        private void btnXoa_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (lsvKhachHang.SelectedIndices.Count > 0)
            {
                DialogResult dr = MessageBox.Show("Bạn có chắc xóa không ? ", "Xóa khách hàng", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    kh.XoaKhachHang(lsvKhachHang.SelectedItems[0].SubItems[0].Text);
                    Hienthikhachhang();
                    setNull();
                    Khoa(true);
                    setButton(true);
                }
            }
            else
                MessageBox.Show("Bạn phải chọn mẩu tin cần xóa");
        }

        private void frmDanhsachkhachhang_Load(object sender, EventArgs e)
        {
            Hienthikhachhang();
            setButton(true);
            setNull();
            Khoa(true);
            Dictionary<string, string> test = new Dictionary<string, string>();
            test.Add("Nam", "Nam");
            test.Add("Nữ", "Nữ");
            cbGioitinhKh.DataSource = new BindingSource(test, null);
            cbGioitinhKh.DisplayMember = "Value";
            cbGioitinhKh.ValueMember = "Key";
        }

        private void txtHoten1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }
        private void txtDienThoai1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
