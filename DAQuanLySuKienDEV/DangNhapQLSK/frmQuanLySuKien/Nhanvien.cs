using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace frmQuanLySuKien
{
    public partial class Nhanvien : Form
    {
        public Nhanvien()
        {
            InitializeComponent();
        }

        private void Nhanvien_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            Database ds = new Database();
            dt = ds.Docbang("Select *From NHANVIEN");
            rpnhanvien rp = new rpnhanvien();
            rp.SetDataSource(dt);
            crystalReportViewer1.ReportSource = rp;
        }
    }
}
