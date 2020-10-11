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
using System.Threading;

namespace frmQuanLySuKien
{
    public partial class frmQuanLySuKien : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmQuanLySuKien()
        {
            Thread t = new Thread(new ThreadStart(sqlashScreen));
            t.Start();
            Thread.Sleep(3000);
            InitializeComponent();
            t.Abort();
        }
        private void sqlashScreen()
        {
            Application.Run(new LoadQuanlysukien());
        }
        private void btGioithieu_ItemClick(object sender, ItemClickEventArgs e) //frmGioithieu
        {
            frmGioithieu f3 = new frmGioithieu();
            f3.ShowDialog();
        }

        private void btDanhsachnhanvien_ItemClick(object sender, ItemClickEventArgs e) //frmDanhsachnhanvien
        {
            frmDanhsachnhanvien f4 = new frmDanhsachnhanvien();
            f4.ShowDialog();
        }

        private void btdsnv_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmDanhsachnhanvien f4 = new frmDanhsachnhanvien();
            f4.ShowDialog();
        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e) //Danh sách khách hàng
        {
            frmDanhsachkhachhang f5 = new frmDanhsachkhachhang();
            f5.ShowDialog();
        }

        private void barButtonItem43_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmDanhsachkhachhang f5 = new frmDanhsachkhachhang();
            f5.ShowDialog();
        }

        private void barButtonItem9_ItemClick(object sender, ItemClickEventArgs e) //Danh sách sự kiện
        {
            frmDanhsachsukien f6 = new frmDanhsachsukien();
            f6.ShowDialog();
        }

        private void barButtonItem45_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmDanhsachsukien f6 = new frmDanhsachsukien();
            f6.ShowDialog();
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmDoimatkhau f7 = new frmDoimatkhau();
            f7.ShowDialog();
        }

        private void barButtonItem51_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmTimkiemkhachhang f9 = new frmTimkiemkhachhang();
            f9.ShowDialog();
        }

        private void barButtonItem53_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmTimkiemnhanvien f10 = new frmTimkiemnhanvien();
            f10.ShowDialog();
        }

        private void barButtonItem54_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmTimkiemsukien f11 = new frmTimkiemsukien();
            f11.ShowDialog();
        }

        private void barButtonItem40_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmTimkiem f12 = new frmTimkiem();
            f12.ShowDialog();
        }

        private void barButtonItem48_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmTrogiup f13 = new frmTrogiup();
            f13.ShowDialog();
        }
        private void barButtonItem50_ItemClick(object sender, ItemClickEventArgs e)
        {
            Nhanvien nv = new Nhanvien();
            nv.ShowDialog();
        }

        private void barButtonItem44_ItemClick(object sender, ItemClickEventArgs e)
        {
            Khachhangrp f14 = new Khachhangrp();
            f14.ShowDialog();
        }

        private void barButtonItem39_ItemClick(object sender, ItemClickEventArgs e)
        {
            Sukien f15 = new Sukien();
            f15.ShowDialog();
        }
    }
}