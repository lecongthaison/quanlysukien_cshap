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
    public partial class Khachhangrp : Form
    {
        public Khachhangrp()
        {
            InitializeComponent();
        }

        private void Khachhangrp_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            Database ds = new Database();
            dt = ds.Docbang("Select *From KHACHHANG");
            rpkhachhang rp = new rpkhachhang();
            rp.SetDataSource(dt);
            crystalReportViewer1.ReportSource = rp;
        }
    }
}
