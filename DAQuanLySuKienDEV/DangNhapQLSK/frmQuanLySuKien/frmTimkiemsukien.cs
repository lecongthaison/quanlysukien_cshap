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

namespace frmQuanLySuKien
{
    public partial class frmTimkiemsukien : DevExpress.XtraEditors.XtraForm
    {
        public frmTimkiemsukien()
        {
            InitializeComponent();
        }
        private void btsk_Click(object sender, EventArgs e)
        {
            if (txttt.Text == "") MessageBox.Show("Bạn chưa nhập thông tin cần tìm kiếm.", "Thông Báo");
            {
                if (ramsk.Checked)
                {
                    Database db = new Database();
                    DataTable dt = new DataTable();
                    dt = db.Docbang("SELECT * FROM SUKIEN WHERE MaSuKien like  '%" + txttt.Text + "%'");
                    dataGridViewsk.DataSource = dt;
                }
                if (ratsk.Checked)
                {
                    Database kn = new Database();
                    DataTable dt = new DataTable();
                    dt = kn.Docbang("SELECT * FROM SUKIEN WHERE TenSuKien like  N'%" + txttt.Text + "%'");
                    dataGridViewsk.DataSource = dt;
                }
            }
        }

        private void btToanbo_Click(object sender, EventArgs e)
        {
            Database db = new Database();
            DataTable dt = new DataTable();
            dt = db.Docbang("SELECT * FROM SUKIEN");
            dataGridViewsk.DataSource = dt;
        }
    }
}