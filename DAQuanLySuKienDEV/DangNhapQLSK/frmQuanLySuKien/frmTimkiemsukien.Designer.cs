namespace frmQuanLySuKien
{
    partial class frmTimkiemsukien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTimkiemsukien));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btToanbo = new System.Windows.Forms.Button();
            this.dataGridViewsk = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btsk = new System.Windows.Forms.Button();
            this.txttt = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ratsk = new System.Windows.Forms.RadioButton();
            this.ramsk = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewsk)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(710, 437);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btToanbo
            // 
            this.btToanbo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btToanbo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btToanbo.Image = ((System.Drawing.Image)(resources.GetObject("btToanbo.Image")));
            this.btToanbo.Location = new System.Drawing.Point(568, 105);
            this.btToanbo.Name = "btToanbo";
            this.btToanbo.Size = new System.Drawing.Size(118, 35);
            this.btToanbo.TabIndex = 18;
            this.btToanbo.Text = "Show Toàn Bộ";
            this.btToanbo.UseVisualStyleBackColor = true;
            this.btToanbo.Click += new System.EventHandler(this.btToanbo_Click);
            // 
            // dataGridViewsk
            // 
            this.dataGridViewsk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewsk.Location = new System.Drawing.Point(13, 143);
            this.dataGridViewsk.Name = "dataGridViewsk";
            this.dataGridViewsk.Size = new System.Drawing.Size(685, 283);
            this.dataGridViewsk.TabIndex = 17;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.btsk);
            this.groupBox2.Controls.Add(this.txttt);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(202, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(496, 87);
            this.groupBox2.TabIndex = 16;
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
            // btsk
            // 
            this.btsk.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btsk.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btsk.Image = ((System.Drawing.Image)(resources.GetObject("btsk.Image")));
            this.btsk.Location = new System.Drawing.Point(366, 19);
            this.btsk.Name = "btsk";
            this.btsk.Size = new System.Drawing.Size(118, 35);
            this.btsk.TabIndex = 12;
            this.btsk.Text = "Tìm kiếm";
            this.btsk.UseVisualStyleBackColor = true;
            this.btsk.Click += new System.EventHandler(this.btsk_Click);
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
            this.groupBox1.Controls.Add(this.ratsk);
            this.groupBox1.Controls.Add(this.ramsk);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(183, 87);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn chức năng tìm kiếm";
            // 
            // ratsk
            // 
            this.ratsk.AutoSize = true;
            this.ratsk.Location = new System.Drawing.Point(130, 63);
            this.ratsk.Name = "ratsk";
            this.ratsk.Size = new System.Drawing.Size(14, 13);
            this.ratsk.TabIndex = 4;
            this.ratsk.TabStop = true;
            this.ratsk.UseVisualStyleBackColor = true;
            // 
            // ramsk
            // 
            this.ramsk.AutoSize = true;
            this.ramsk.Location = new System.Drawing.Point(130, 30);
            this.ramsk.Name = "ramsk";
            this.ramsk.Size = new System.Drawing.Size(14, 13);
            this.ramsk.TabIndex = 3;
            this.ramsk.TabStop = true;
            this.ramsk.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã Sự Kiện";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Sự Kiện";
            // 
            // frmTimkiemsukien
            // 
            this.AcceptButton = this.btsk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 438);
            this.Controls.Add(this.btToanbo);
            this.Controls.Add(this.dataGridViewsk);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(727, 477);
            this.MinimumSize = new System.Drawing.Size(727, 477);
            this.Name = "frmTimkiemsukien";
            this.Text = "Tìm kiếm Sự Kiện";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewsk)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btToanbo;
        private System.Windows.Forms.DataGridView dataGridViewsk;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btsk;
        private System.Windows.Forms.TextBox txttt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton ratsk;
        private System.Windows.Forms.RadioButton ramsk;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}