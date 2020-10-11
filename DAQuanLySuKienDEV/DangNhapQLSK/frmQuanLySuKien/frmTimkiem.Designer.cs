namespace frmQuanLySuKien
{
    partial class frmTimkiem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTimkiem));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rask = new System.Windows.Forms.RadioButton();
            this.ranv = new System.Windows.Forms.RadioButton();
            this.rakh = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btToanbo = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.bttk = new System.Windows.Forms.Button();
            this.txttt = new System.Windows.Forms.TextBox();
            this.dataGridViewkh = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewkh)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(733, 461);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rask);
            this.groupBox1.Controls.Add(this.ranv);
            this.groupBox1.Controls.Add(this.rakh);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(183, 125);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn chức năng tìm kiếm";
            // 
            // rask
            // 
            this.rask.AutoSize = true;
            this.rask.Location = new System.Drawing.Point(130, 91);
            this.rask.Name = "rask";
            this.rask.Size = new System.Drawing.Size(14, 13);
            this.rask.TabIndex = 5;
            this.rask.TabStop = true;
            this.rask.UseVisualStyleBackColor = true;
            // 
            // ranv
            // 
            this.ranv.AutoSize = true;
            this.ranv.Location = new System.Drawing.Point(130, 63);
            this.ranv.Name = "ranv";
            this.ranv.Size = new System.Drawing.Size(14, 13);
            this.ranv.TabIndex = 4;
            this.ranv.TabStop = true;
            this.ranv.UseVisualStyleBackColor = true;
            // 
            // rakh
            // 
            this.rakh.AutoSize = true;
            this.rakh.Location = new System.Drawing.Point(130, 30);
            this.rakh.Name = "rakh";
            this.rakh.Size = new System.Drawing.Size(14, 13);
            this.rakh.TabIndex = 3;
            this.rakh.TabStop = true;
            this.rakh.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sự Kiện";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Khách Hàng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhân Viên";
            // 
            // btToanbo
            // 
            this.btToanbo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btToanbo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btToanbo.Image = ((System.Drawing.Image)(resources.GetObject("btToanbo.Image")));
            this.btToanbo.Location = new System.Drawing.Point(580, 105);
            this.btToanbo.Name = "btToanbo";
            this.btToanbo.Size = new System.Drawing.Size(118, 35);
            this.btToanbo.TabIndex = 16;
            this.btToanbo.Text = "Show Toàn Bộ";
            this.btToanbo.UseVisualStyleBackColor = true;
            this.btToanbo.Click += new System.EventHandler(this.btToanbo_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.bttk);
            this.groupBox2.Controls.Add(this.txttt);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(214, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(496, 87);
            this.groupBox2.TabIndex = 15;
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
            // dataGridViewkh
            // 
            this.dataGridViewkh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewkh.Location = new System.Drawing.Point(12, 146);
            this.dataGridViewkh.Name = "dataGridViewkh";
            this.dataGridViewkh.Size = new System.Drawing.Size(698, 283);
            this.dataGridViewkh.TabIndex = 17;
            // 
            // frmTimkiem
            // 
            this.AcceptButton = this.bttk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 435);
            this.Controls.Add(this.dataGridViewkh);
            this.Controls.Add(this.btToanbo);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(740, 474);
            this.MinimumSize = new System.Drawing.Size(740, 474);
            this.Name = "frmTimkiem";
            this.Text = "Tìm Kiếm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewkh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rask;
        private System.Windows.Forms.RadioButton ranv;
        private System.Windows.Forms.RadioButton rakh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btToanbo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bttk;
        private System.Windows.Forms.TextBox txttt;
        private System.Windows.Forms.DataGridView dataGridViewkh;
    }
}