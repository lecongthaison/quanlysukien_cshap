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
    public partial class frmDanhsachnhanvien : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        bool cothem;
        clsNhanvien nv = new clsNhanvien();
        public frmDanhsachnhanvien()
        {
            InitializeComponent();
        }
        void HienthiNhanvien()
        {
            DataTable dt = nv.LayDSNhanvien();
            lsvNhanVien.Items.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lvi = lsvNhanVien.Items.Add(dt.Rows[i][0].ToString());
                lvi.SubItems.Add(dt.Rows[i][1].ToString());
                lvi.SubItems.Add(dt.Rows[i][2].ToString());
                lvi.SubItems.Add(dt.Rows[i][3].ToString());
                lvi.SubItems.Add(dt.Rows[i][4].ToString());
                lvi.SubItems.Add(dt.Rows[i][5].ToString());
                lvi.SubItems.Add(dt.Rows[i][6].ToString());
            }
        }
        void setNull()
        {
            txtHoten1.Text = "";
            txtDiaChi1.Text = "";
            txtDienThoai1.Text = "";
        }
        void setButton(bool val)
        {
            btThem.Enabled = val;
            btXoa.Enabled = val;
            btSua.Enabled = val;
            btThoat.Enabled = val;
            btLuu.Enabled = !val;
            btHuy.Enabled = !val;
        }
        public void Khoa(bool a)
        {
            txtHoten1.ReadOnly = a;
            txtDiaChi1.ReadOnly = a;
            txtDienThoai1.ReadOnly = a;
        }
        void HienthiBangcap()
        {
            DataTable dt = nv.LayChucvu();
            cbChucvu.DataSource = dt;
            cbChucvu.DisplayMember = "TenChucVu";
            cbChucvu.ValueMember = "MaChucVu";
        }
        private void lsvNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvNhanVien.SelectedIndices.Count > 0)
            {
                txtHoten1.Text = lsvNhanVien.SelectedItems[0].SubItems[1].Text;
                dtpNgaySinh1.Value = DateTime.Parse(lsvNhanVien.SelectedItems[0].SubItems[2].Text);
                cbGioitinhNV.SelectedIndex = 1;
                txtDiaChi1.Text = lsvNhanVien.SelectedItems[0].SubItems[4].Text;
                txtDienThoai1.Text = lsvNhanVien.SelectedItems[0].SubItems[5].Text;
                cbChucvu.SelectedIndex = cbChucvu.FindString(lsvNhanVien.SelectedItems[0].SubItems[6].Text);
                string gt = lsvNhanVien.SelectedItems[0].SubItems[3].Text;
                if (gt == "Nam")
                {
                    cbGioitinhNV.SelectedIndex = 0;
                }
            }
        }

        private void btThem_ItemClick(object sender, ItemClickEventArgs e)
        {
            cothem = true;
            setButton(false);
            Khoa(false);
            setNull();
            txtHoten1.Focus();
        }

        private void btSua_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (lsvNhanVien.SelectedIndices.Count > 0)
            {
                cothem = false;
                setButton(false);
                Khoa(false);
                txtHoten1.Focus();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn 1 Nhân viên", "Thộng báo");
            }
        }

        private void btThoat_ItemClick(object sender, ItemClickEventArgs e)
        {
            Close();
        }

        private void btHuy_ItemClick(object sender, ItemClickEventArgs e)
        {
            setButton(true);
            setNull();
            Khoa(true);
        }

        private void btLuu_ItemClick(object sender, ItemClickEventArgs e)
        {
            string ngay = String.Format("{0:MM/dd/yyyy}", dtpNgaySinh1.Value);
            if (cothem)
            {
                string a = cbGioitinhNV.SelectedValue.ToString();
                nv.ThemNhanVien(txtHoten1.Text, ngay, cbGioitinhNV.Text, txtDiaChi1.Text, txtDienThoai1.Text, cbChucvu.SelectedValue.ToString());
                MessageBox.Show("Thêm mới thành công");
            }
            else
            {
                nv.CapNhatNhanVien(lsvNhanVien.SelectedItems[0].SubItems[0].Text, txtHoten1.Text, ngay, cbGioitinhNV.Text, txtDiaChi1.Text, txtDienThoai1.Text, cbChucvu.SelectedValue.ToString());
                MessageBox.Show("Cập nhật thành công");
            }
            HienthiNhanvien();
            setNull();
            setButton(true);
            Khoa(true);
        }

        private void btXoa_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (lsvNhanVien.SelectedIndices.Count > 0)
            {
                DialogResult dr = MessageBox.Show("Bạn có chắc xóa không ? ", "Xóa nhân viên", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    nv.XoaNhanVien(lsvNhanVien.SelectedItems[0].SubItems[0].Text);
                    HienthiNhanvien();
                    setNull();
                    Khoa(true);
                    setButton(true);
                }
            }
            else
                MessageBox.Show("Bạn phải chọn mẩu tin cần xóa");
        }

        private void frmDanhsachnhanvien_Load(object sender, EventArgs e)
        {
            HienthiNhanvien();
            HienthiBangcap();
            setButton(true);
            setNull();
            Khoa(true);
            Dictionary<string, string> test = new Dictionary<string, string>();
            test.Add("Nam", "Nam");
            test.Add("Nữ", "Nữ");
            cbGioitinhNV.DataSource = new BindingSource(test, null);
            cbGioitinhNV.DisplayMember = "Value";
            cbGioitinhNV.ValueMember = "Key";
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