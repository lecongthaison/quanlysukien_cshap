namespace frmQuanLySuKien
{
    partial class frmDanhsachnhanvien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDanhsachnhanvien));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btThem = new DevExpress.XtraBars.BarButtonItem();
            this.btXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btSua = new DevExpress.XtraBars.BarButtonItem();
            this.btLuu = new DevExpress.XtraBars.BarButtonItem();
            this.btHuy = new DevExpress.XtraBars.BarButtonItem();
            this.btThoat = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbChucvu = new System.Windows.Forms.ComboBox();
            this.cbGioitinhNV = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpNgaySinh1 = new System.Windows.Forms.DateTimePicker();
            this.txtDiaChi1 = new System.Windows.Forms.TextBox();
            this.txtDienThoai1 = new System.Windows.Forms.TextBox();
            this.txtHoten1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lsvNhanVien = new System.Windows.Forms.ListView();
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.btThem,
            this.btXoa,
            this.btSua,
            this.btLuu,
            this.btHuy,
            this.btThoat});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 7;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.Size = new System.Drawing.Size(1052, 162);
            this.ribbon.StatusBar = this.ribbonStatusBar;
       
            // 
            // btThem
            // 
            this.btThem.Caption = "Thêm";
            this.btThem.Id = 1;
            this.btThem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btThem.ImageOptions.LargeImage")));
            this.btThem.Name = "btThem";
            this.btThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btThem_ItemClick);
            // 
            // btXoa
            // 
            this.btXoa.Caption = "Xóa";
            this.btXoa.Id = 2;
            this.btXoa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btXoa.ImageOptions.LargeImage")));
            this.btXoa.Name = "btXoa";
            this.btXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btXoa_ItemClick);
            // 
            // btSua
            // 
            this.btSua.Caption = "Sữa";
            this.btSua.Id = 3;
            this.btSua.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btSua.ImageOptions.LargeImage")));
            this.btSua.Name = "btSua";
            this.btSua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btSua_ItemClick);
            // 
            // btLuu
            // 
            this.btLuu.Caption = "Lưu";
            this.btLuu.Id = 4;
            this.btLuu.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btLuu.ImageOptions.LargeImage")));
            this.btLuu.Name = "btLuu";
            this.btLuu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btLuu_ItemClick);
            // 
            // btHuy
            // 
            this.btHuy.Caption = "Hủy";
            this.btHuy.Id = 5;
            this.btHuy.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btHuy.ImageOptions.LargeImage")));
            this.btHuy.Name = "btHuy";
            this.btHuy.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btHuy_ItemClick);
            // 
            // btThoat
            // 
            this.btThoat.Caption = "Thoát";
            this.btThoat.Id = 6;
            this.btThoat.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btThoat.ImageOptions.LargeImage")));
            this.btThoat.Name = "btThoat";
            this.btThoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btThoat_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ribbonPage1.ImageOptions.SvgImage")));
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Tính Năng";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btThem);
            this.ribbonPageGroup1.ItemLinks.Add(this.btXoa);
            this.ribbonPageGroup1.ItemLinks.Add(this.btSua);
            this.ribbonPageGroup1.ItemLinks.Add(this.btLuu);
            this.ribbonPageGroup1.ItemLinks.Add(this.btHuy);
            this.ribbonPageGroup1.ItemLinks.Add(this.btThoat);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Customer";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 493);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1052, 31);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbChucvu);
            this.groupBox2.Controls.Add(this.cbGioitinhNV);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.dtpNgaySinh1);
            this.groupBox2.Controls.Add(this.txtDiaChi1);
            this.groupBox2.Controls.Add(this.txtDienThoai1);
            this.groupBox2.Controls.Add(this.txtHoten1);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(292, 68);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(760, 90);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin chi tiết";
            // 
            // cbChucvu
            // 
            this.cbChucvu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbChucvu.FormattingEnabled = true;
            this.cbChucvu.Location = new System.Drawing.Point(487, 64);
            this.cbChucvu.Name = "cbChucvu";
            this.cbChucvu.Size = new System.Drawing.Size(103, 23);
            this.cbChucvu.TabIndex = 38;
            // 
            // cbGioitinhNV
            // 
            this.cbGioitinhNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGioitinhNV.FormattingEnabled = true;
            this.cbGioitinhNV.Location = new System.Drawing.Point(487, 38);
            this.cbGioitinhNV.Name = "cbGioitinhNV";
            this.cbGioitinhNV.Size = new System.Drawing.Size(103, 23);
            this.cbGioitinhNV.TabIndex = 37;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(389, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "Giới tính";
            // 
            // dtpNgaySinh1
            // 
            this.dtpNgaySinh1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgaySinh1.Location = new System.Drawing.Point(131, 38);
            this.dtpNgaySinh1.Name = "dtpNgaySinh1";
            this.dtpNgaySinh1.Size = new System.Drawing.Size(228, 21);
            this.dtpNgaySinh1.TabIndex = 5;
            // 
            // txtDiaChi1
            // 
            this.txtDiaChi1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChi1.Location = new System.Drawing.Point(131, 63);
            this.txtDiaChi1.MaxLength = 200;
            this.txtDiaChi1.Name = "txtDiaChi1";
            this.txtDiaChi1.Size = new System.Drawing.Size(228, 21);
            this.txtDiaChi1.TabIndex = 7;
            // 
            // txtDienThoai1
            // 
            this.txtDienThoai1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDienThoai1.Location = new System.Drawing.Point(487, 14);
            this.txtDienThoai1.MaximumSize = new System.Drawing.Size(228, 21);
            this.txtDienThoai1.MaxLength = 12;
            this.txtDienThoai1.Name = "txtDienThoai1";
            this.txtDienThoai1.Size = new System.Drawing.Size(228, 21);
            this.txtDienThoai1.TabIndex = 6;
            this.txtDienThoai1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDienThoai1_KeyPress);
            // 
            // txtHoten1
            // 
            this.txtHoten1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoten1.Location = new System.Drawing.Point(131, 14);
            this.txtHoten1.MaxLength = 50;
            this.txtHoten1.Name = "txtHoten1";
            this.txtHoten1.Size = new System.Drawing.Size(228, 21);
            this.txtHoten1.TabIndex = 1;
            this.txtHoten1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHoten1_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(389, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Điện thoại";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(48, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 15);
            this.label8.TabIndex = 0;
            this.label8.Text = "Địa chỉ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(48, 43);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 15);
            this.label12.TabIndex = 0;
            this.label12.Text = "Ngày sinh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(389, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Chức Vụ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ và tên";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lsvNhanVien);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 164);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1040, 303);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chung";
            // 
            // lsvNhanVien
            // 
            this.lsvNhanVien.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader13,
            this.columnHeader14,
            this.columnHeader15,
            this.columnHeader1});
            this.lsvNhanVien.FullRowSelect = true;
            this.lsvNhanVien.GridLines = true;
            this.lsvNhanVien.Location = new System.Drawing.Point(12, 20);
            this.lsvNhanVien.Name = "lsvNhanVien";
            this.lsvNhanVien.Size = new System.Drawing.Size(1028, 311);
            this.lsvNhanVien.TabIndex = 1;
            this.lsvNhanVien.UseCompatibleStateImageBehavior = false;
            this.lsvNhanVien.View = System.Windows.Forms.View.Details;
            this.lsvNhanVien.SelectedIndexChanged += new System.EventHandler(this.lsvNhanVien_SelectedIndexChanged);
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Mã NV";
            this.columnHeader10.Width = 78;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Họ Tên Nhân Viên";
            this.columnHeader11.Width = 185;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Ngày Sinh";
            this.columnHeader12.Width = 121;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Giới Tính";
            this.columnHeader13.Width = 86;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "Địa Chỉ";
            this.columnHeader14.Width = 295;
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "Điện Thoại";
            this.columnHeader15.Width = 151;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Chức Vụ";
            this.columnHeader1.Width = 109;
            // 
            // frmDanhsachnhanvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 524);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1062, 525);
            this.MinimumSize = new System.Drawing.Size(1062, 525);
            this.Name = "frmDanhsachnhanvien";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Danh Sách Nhân Viên";
            this.Load += new System.EventHandler(this.frmDanhsachnhanvien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem btThem;
        private DevExpress.XtraBars.BarButtonItem btXoa;
        private DevExpress.XtraBars.BarButtonItem btSua;
        private DevExpress.XtraBars.BarButtonItem btLuu;
        private DevExpress.XtraBars.BarButtonItem btHuy;
        private DevExpress.XtraBars.BarButtonItem btThoat;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbGioitinhNV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh1;
        private System.Windows.Forms.TextBox txtDiaChi1;
        private System.Windows.Forms.TextBox txtDienThoai1;
        private System.Windows.Forms.TextBox txtHoten1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbChucvu;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView lsvNhanVien;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}