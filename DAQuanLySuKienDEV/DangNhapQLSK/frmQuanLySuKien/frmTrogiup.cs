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
    public partial class frmTrogiup : DevExpress.XtraEditors.XtraForm
    {
        public frmTrogiup()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
        }

        private void frmTrogiup_Load(object sender, EventArgs e)
        {
            //linkLabel1.Text = "";
            linkLabel1.Links.Add(6, 4, "https://www.facebook.com/thaison.lecong");
        }

        private void bttimkiem_Click(object sender, EventArgs e)
        {
        }
    }
}