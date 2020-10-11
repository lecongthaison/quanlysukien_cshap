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
    public partial class frmDanhsachsukien : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        bool cothem;
        clsSuKien kh = new clsSuKien();
        public frmDanhsachsukien()
        {
            InitializeComponent();
        }
        void Hienthisukien()
        {
            DataTable dt = kh.LayDSSuKien();
            lsvSuKien.Items.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lvi = lsvSuKien.Items.Add(dt.Rows[i][0].ToString());
                lvi.SubItems.Add(dt.Rows[i][1].ToString());
                lvi.SubItems.Add(dt.Rows[i][2].ToString());
                lvi.SubItems.Add(dt.Rows[i][3].ToString());
                lvi.SubItems.Add(dt.Rows[i][4].ToString());
            }
        }
        void setNull()
        {
            txtTensukien.Text = "";
            txtNguoiphutrach.Text = "";
            txtTrigia.Text = "";
        }
        void setButton(bool val)
        {
            btThem2.Enabled = val;
            btXoa2.Enabled = val;
            btSua2.Enabled = val;
            btThoat2.Enabled = val;
            btLuu2.Enabled = !val;
            btHuy2.Enabled = !val;
        }
        public void Khoa(bool a)
        {
            txtTensukien.ReadOnly = a;
            txtNguoiphutrach.ReadOnly = a;
            txtTrigia.ReadOnly = a;
        }

        private void lsvSuKien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvSuKien.SelectedIndices.Count > 0)
            {
                txtTensukien.Text = lsvSuKien.SelectedItems[0].SubItems[1].Text;
                txtNguoiphutrach.Text = lsvSuKien.SelectedItems[0].SubItems[2].Text;
                txtTrigia.Text = lsvSuKien.SelectedItems[0].SubItems[3].Text;
                dtpNgaynhap.Value = DateTime.Parse(lsvSuKien.SelectedItems[0].SubItems[4].Text);
            }
        }

        private void btThem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            cothem = true;
            setButton(false);
            Khoa(false);
            setNull();
            txtTensukien.Focus();
        }

        private void btSua2_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (lsvSuKien.SelectedIndices.Count > 0)
            {
                cothem = false;
                setButton(false);
                Khoa(false);
                txtTensukien.Focus();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn 1 Sự kiện", "Thộng báo");
            }
        }

        private void btThoat2_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btHuy2_ItemClick(object sender, ItemClickEventArgs e)
        {
            setButton(true);
            setNull();
            Khoa(true);
        }

        private void btLuu2_ItemClick(object sender, ItemClickEventArgs e)
        {
            string ngay = String.Format("{0:MM/dd/yyyy}", dtpNgaynhap.Value);
            if (cothem)
            {
                kh.ThemSuKien(txtTensukien.Text, txtNguoiphutrach.Text, txtTrigia.Text, ngay);
                MessageBox.Show("Thêm mới thành công");
            }
            else
            {
                kh.CapNhatSuKien(lsvSuKien.SelectedItems[0].SubItems[0].Text, txtTensukien.Text, txtNguoiphutrach.Text, txtTrigia.Text, ngay);
                MessageBox.Show("Cập nhật thành công");
            }
            Hienthisukien();
            setNull();
            setButton(true);
            Khoa(true);
        }

        private void btXoa2_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (lsvSuKien.SelectedIndices.Count > 0)
            {
                DialogResult dr = MessageBox.Show("Bạn có chắc xóa không ? ", "Xóa su kien", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    kh.XoaSuKien(lsvSuKien.SelectedItems[0].SubItems[0].Text);
                    Hienthisukien();
                    setNull();
                    Khoa(true);
                    setButton(true);
                }
            }
            else
                MessageBox.Show("Bạn phải chọn mẩu tin cần xóa");
        }

        private void frnDanhsachsukien_Load(object sender, EventArgs e)
        {
            Hienthisukien();
            setButton(true);
            setNull();
            Khoa(true);
        }

        private void txtTrigia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtTensukien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }
    }
}
