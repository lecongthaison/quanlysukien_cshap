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
    public partial class Sukien : Form
    {
        public Sukien()
        {
            InitializeComponent();
        }

        private void Sukien_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            Database ds = new Database();
            dt = ds.Docbang("Select *From SUKIEN");
            rpsukien rp = new rpsukien();
            rp.SetDataSource(dt);
            crystalReportViewer1.ReportSource = rp;
        }
    }
}
