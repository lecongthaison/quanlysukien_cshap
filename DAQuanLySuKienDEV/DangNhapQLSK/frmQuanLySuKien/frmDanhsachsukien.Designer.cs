namespace frmQuanLySuKien
{
    partial class frmDanhsachsukien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDanhsachsukien));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btThem2 = new DevExpress.XtraBars.BarButtonItem();
            this.btXoa2 = new DevExpress.XtraBars.BarButtonItem();
            this.btSua2 = new DevExpress.XtraBars.BarButtonItem();
            this.btLuu2 = new DevExpress.XtraBars.BarButtonItem();
            this.btHuy2 = new DevExpress.XtraBars.BarButtonItem();
            this.btThoat2 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lsvSuKien = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtTensukien = new System.Windows.Forms.TextBox();
            this.dtpNgaynhap = new System.Windows.Forms.DateTimePicker();
            this.txtTrigia = new System.Windows.Forms.TextBox();
            this.txtNguoiphutrach = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.btThem2,
            this.btXoa2,
            this.btSua2,
            this.btLuu2,
            this.btHuy2,
            this.btThoat2});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 7;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.Size = new System.Drawing.Size(909, 162);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // btThem2
            // 
            this.btThem2.Caption = "Thêm";
            this.btThem2.Id = 1;
            this.btThem2.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btThem2.ImageOptions.LargeImage")));
            this.btThem2.Name = "btThem2";
            this.btThem2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btThem2_ItemClick);
            // 
            // btXoa2
            // 
            this.btXoa2.Caption = "Xóa";
            this.btXoa2.Id = 2;
            this.btXoa2.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btXoa2.ImageOptions.LargeImage")));
            this.btXoa2.Name = "btXoa2";
            this.btXoa2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btXoa2_ItemClick);
            // 
            // btSua2
            // 
            this.btSua2.Caption = "Sửa";
            this.btSua2.Id = 3;
            this.btSua2.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btSua2.ImageOptions.LargeImage")));
            this.btSua2.Name = "btSua2";
            this.btSua2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btSua2_ItemClick);
            // 
            // btLuu2
            // 
            this.btLuu2.Caption = "Lưu";
            this.btLuu2.Id = 4;
            this.btLuu2.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btLuu2.ImageOptions.LargeImage")));
            this.btLuu2.Name = "btLuu2";
            this.btLuu2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btLuu2_ItemClick);
            // 
            // btHuy2
            // 
            this.btHuy2.Caption = "Hủy";
            this.btHuy2.Id = 5;
            this.btHuy2.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btHuy2.ImageOptions.LargeImage")));
            this.btHuy2.Name = "btHuy2";
            this.btHuy2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btHuy2_ItemClick);
            // 
            // btThoat2
            // 
            this.btThoat2.Caption = "Thoát";
            this.btThoat2.Id = 6;
            this.btThoat2.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btThoat2.ImageOptions.LargeImage")));
            this.btThoat2.Name = "btThoat2";
            this.btThoat2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btThoat2_ItemClick);
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
            this.ribbonPageGroup1.ItemLinks.Add(this.btThem2);
            this.ribbonPageGroup1.ItemLinks.Add(this.btXoa2);
            this.ribbonPageGroup1.ItemLinks.Add(this.btSua2);
            this.ribbonPageGroup1.ItemLinks.Add(this.btLuu2);
            this.ribbonPageGroup1.ItemLinks.Add(this.btHuy2);
            this.ribbonPageGroup1.ItemLinks.Add(this.btThoat2);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Sự Kiện";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 459);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(909, 31);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lsvSuKien);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(78, 159);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(749, 302);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chung";
            // 
            // lsvSuKien
            // 
            this.lsvSuKien.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lsvSuKien.FullRowSelect = true;
            this.lsvSuKien.GridLines = true;
            this.lsvSuKien.Location = new System.Drawing.Point(13, 18);
            this.lsvSuKien.Name = "lsvSuKien";
            this.lsvSuKien.Size = new System.Drawing.Size(723, 283);
            this.lsvSuKien.TabIndex = 1;
            this.lsvSuKien.UseCompatibleStateImageBehavior = false;
            this.lsvSuKien.View = System.Windows.Forms.View.Details;
            this.lsvSuKien.SelectedIndexChanged += new System.EventHandler(this.lsvSuKien_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã NV";
            this.columnHeader1.Width = 65;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên Sự Kiện";
            this.columnHeader2.Width = 205;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Người Phụ Trách";
            this.columnHeader4.Width = 169;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Trị Giá";
            this.columnHeader5.Width = 124;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Ngày Nhập";
            this.columnHeader6.Width = 157;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtTensukien);
            this.groupBox2.Controls.Add(this.dtpNgaynhap);
            this.groupBox2.Controls.Add(this.txtTrigia);
            this.groupBox2.Controls.Add(this.txtNguoiphutrach);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(291, 68);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(621, 94);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin chi tiết";
            // 
            // txtTensukien
            // 
            this.txtTensukien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTensukien.Location = new System.Drawing.Point(97, 30);
            this.txtTensukien.MaxLength = 100;
            this.txtTensukien.Name = "txtTensukien";
            this.txtTensukien.Size = new System.Drawing.Size(200, 21);
            this.txtTensukien.TabIndex = 9;
            this.txtTensukien.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTensukien_KeyPress);
            // 
            // dtpNgaynhap
            // 
            this.dtpNgaynhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgaynhap.Location = new System.Drawing.Point(381, 60);
            this.dtpNgaynhap.Name = "dtpNgaynhap";
            this.dtpNgaynhap.Size = new System.Drawing.Size(231, 21);
            this.dtpNgaynhap.TabIndex = 8;
            // 
            // txtTrigia
            // 
            this.txtTrigia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTrigia.Location = new System.Drawing.Point(381, 33);
            this.txtTrigia.MaxLength = 20;
            this.txtTrigia.Name = "txtTrigia";
            this.txtTrigia.Size = new System.Drawing.Size(231, 21);
            this.txtTrigia.TabIndex = 7;
            this.txtTrigia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTrigia_KeyPress);
            // 
            // txtNguoiphutrach
            // 
            this.txtNguoiphutrach.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNguoiphutrach.Location = new System.Drawing.Point(122, 60);
            this.txtNguoiphutrach.MaxLength = 50;
            this.txtNguoiphutrach.Name = "txtNguoiphutrach";
            this.txtNguoiphutrach.Size = new System.Drawing.Size(175, 21);
            this.txtNguoiphutrach.TabIndex = 6;
            this.txtNguoiphutrach.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTensukien_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(303, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Trị Giá";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(6, 63);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(114, 15);
            this.label12.TabIndex = 0;
            this.label12.Text = "Người Phụ Trách";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(303, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ngày Nhập";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Sự Kiện";
            // 
            // frmDanhsachsukien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 490);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(919, 491);
            this.MinimumSize = new System.Drawing.Size(919, 491);
            this.Name = "frmDanhsachsukien";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Danh Sách Sự Kiện";
            this.Load += new System.EventHandler(this.frnDanhsachsukien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem btThem2;
        private DevExpress.XtraBars.BarButtonItem btXoa2;
        private DevExpress.XtraBars.BarButtonItem btSua2;
        private DevExpress.XtraBars.BarButtonItem btLuu2;
        private DevExpress.XtraBars.BarButtonItem btHuy2;
        private DevExpress.XtraBars.BarButtonItem btThoat2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView lsvSuKien;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtTrigia;
        private System.Windows.Forms.TextBox txtNguoiphutrach;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTensukien;
        private System.Windows.Forms.DateTimePicker dtpNgaynhap;
    }
}