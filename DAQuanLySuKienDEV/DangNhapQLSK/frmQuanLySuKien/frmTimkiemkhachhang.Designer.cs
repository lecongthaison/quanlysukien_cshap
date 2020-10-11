namespace frmQuanLySuKien
{
    partial class frmTimkiemkhachhang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTimkiemkhachhang));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.bttk = new System.Windows.Forms.Button();
            this.txttt = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rasdt = new System.Windows.Forms.RadioButton();
            this.ratkh = new System.Windows.Forms.RadioButton();
            this.ramkh = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewkh = new System.Windows.Forms.DataGridView();
            this.btToanbo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewkh)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(709, 436);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.bttk);
            this.groupBox2.Controls.Add(this.txttt);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(201, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(496, 87);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nhập thông tin cần tìm kiếm";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(465, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Bạn hãy nhập thông tin mà bạn cần tìm kiếm vào đây rồi nhấn vào nút Tìm kiếm";
            // 
            // bttk
            // 
            this.bttk.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttk.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.bttk.Image = ((System.Drawing.Image)(resources.GetObject("bttk.Image")));
            this.bttk.Location = new System.Drawing.Point(366, 19);
            this.bttk.Name = "bttk";
            this.bttk.Size = new System.Drawing.Size(118, 35);
            this.bttk.TabIndex = 12;
            this.bttk.Text = "Tìm kiếm";
            this.bttk.UseVisualStyleBackColor = true;
            this.bttk.Click += new System.EventHandler(this.bttk_Click);
            // 
            // txttt
            // 
            this.txttt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttt.Location = new System.Drawing.Point(18, 25);
            this.txttt.MaxLength = 50;
            this.txttt.Name = "txttt";
            this.txttt.Size = new System.Drawing.Size(333, 21);
            this.txttt.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rasdt);
            this.groupBox1.Controls.Add(this.ratkh);
            this.groupBox1.Controls.Add(this.ramkh);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(183, 125);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn chức năng tìm kiếm";
            // 
            // rasdt
            // 
            this.rasdt.AutoSize = true;
            this.rasdt.Location = new System.Drawing.Point(130, 91);
            this.rasdt.Name = "rasdt";
            this.rasdt.Size = new System.Drawing.Size(14, 13);
            this.rasdt.TabIndex = 5;
            this.rasdt.TabStop = true;
            this.rasdt.UseVisualStyleBackColor = true;
            // 
            // ratkh
            // 
            this.ratkh.AutoSize = true;
            this.ratkh.Location = new System.Drawing.Point(130, 63);
            this.ratkh.Name = "ratkh";
            this.ratkh.Size = new System.Drawing.Size(14, 13);
            this.ratkh.TabIndex = 4;
            this.ratkh.TabStop = true;
            this.ratkh.UseVisualStyleBackColor = true;
            // 
            // ramkh
            // 
            this.ramkh.AutoSize = true;
            this.ramkh.Location = new System.Drawing.Point(130, 30);
            this.ramkh.Name = "ramkh";
            this.ramkh.Size = new System.Drawing.Size(14, 13);
            this.ramkh.TabIndex = 3;
            this.ramkh.TabStop = true;
            this.ramkh.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số Điện Thoại";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã Khách Hàng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Khách Hàng";
            // 
            // dataGridViewkh
            // 
            this.dataGridViewkh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewkh.Location = new System.Drawing.Point(12, 143);
            this.dataGridViewkh.Name = "dataGridViewkh";
            this.dataGridViewkh.Size = new System.Drawing.Size(685, 283);
            this.dataGridViewkh.TabIndex = 11;
            // 
            // btToanbo
            // 
            this.btToanbo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btToanbo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btToanbo.Image = ((System.Drawing.Image)(resources.GetObject("btToanbo.Image")));
            this.btToanbo.Location = new System.Drawing.Point(567, 105);
            this.btToanbo.Name = "btToanbo";
            this.btToanbo.Size = new System.Drawing.Size(118, 35);
            this.btToanbo.TabIndex = 14;
            this.btToanbo.Text = "Show Toàn Bộ";
            this.btToanbo.UseVisualStyleBackColor = true;
            this.btToanbo.Click += new System.EventHandler(this.btToanbo_Click);
            // 
            // frmTimkiemkhachhang
            // 
            this.AcceptButton = this.bttk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 438);
            this.Controls.Add(this.btToanbo);
            this.Controls.Add(this.dataGridViewkh);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(727, 477);
            this.MinimumSize = new System.Drawing.Size(727, 477);
            this.Name = "frmTimkiemkhachhang";
            this.Text = "Tìm kiếm Khách Hàng";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewkh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bttk;
        private System.Windows.Forms.TextBox txttt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rasdt;
        private System.Windows.Forms.RadioButton ratkh;
        private System.Windows.Forms.RadioButton ramkh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewkh;
        private System.Windows.Forms.Button btToanbo;
    }
}