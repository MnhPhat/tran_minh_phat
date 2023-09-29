namespace Bai3_01
{
    partial class Form1
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
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.lblnhap_a = new System.Windows.Forms.Label();
            this.lblnhap_b = new System.Windows.Forms.Label();
            this.btnCong = new System.Windows.Forms.Button();
            this.btnTru = new System.Windows.Forms.Button();
            this.btnNhan = new System.Windows.Forms.Button();
            this.btnChia = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.lblKetqua = new System.Windows.Forms.Label();
            this.txtKetqua = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(115, 35);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(214, 26);
            this.txtA.TabIndex = 0;
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(115, 108);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(214, 26);
            this.txtB.TabIndex = 1;
            // 
            // lblnhap_a
            // 
            this.lblnhap_a.AutoSize = true;
            this.lblnhap_a.Location = new System.Drawing.Point(42, 38);
            this.lblnhap_a.Name = "lblnhap_a";
            this.lblnhap_a.Size = new System.Drawing.Size(20, 20);
            this.lblnhap_a.TabIndex = 2;
            this.lblnhap_a.Text = "A";
            // 
            // lblnhap_b
            // 
            this.lblnhap_b.AutoSize = true;
            this.lblnhap_b.Location = new System.Drawing.Point(42, 114);
            this.lblnhap_b.Name = "lblnhap_b";
            this.lblnhap_b.Size = new System.Drawing.Size(20, 20);
            this.lblnhap_b.TabIndex = 3;
            this.lblnhap_b.Text = "B";
            // 
            // btnCong
            // 
            this.btnCong.Location = new System.Drawing.Point(46, 214);
            this.btnCong.Name = "btnCong";
            this.btnCong.Size = new System.Drawing.Size(80, 30);
            this.btnCong.TabIndex = 4;
            this.btnCong.Text = "Cong";
            this.btnCong.UseVisualStyleBackColor = true;
            this.btnCong.Click += new System.EventHandler(this.btnCong_Click);
            // 
            // btnTru
            // 
            this.btnTru.Location = new System.Drawing.Point(177, 214);
            this.btnTru.Name = "btnTru";
            this.btnTru.Size = new System.Drawing.Size(79, 30);
            this.btnTru.TabIndex = 5;
            this.btnTru.Text = "Tru";
            this.btnTru.UseVisualStyleBackColor = true;
            this.btnTru.Click += new System.EventHandler(this.btnTru_Click);
            // 
            // btnNhan
            // 
            this.btnNhan.Location = new System.Drawing.Point(300, 214);
            this.btnNhan.Name = "btnNhan";
            this.btnNhan.Size = new System.Drawing.Size(80, 30);
            this.btnNhan.TabIndex = 6;
            this.btnNhan.Text = "Nhan";
            this.btnNhan.UseVisualStyleBackColor = true;
            this.btnNhan.Click += new System.EventHandler(this.btnNhan_Click);
            // 
            // btnChia
            // 
            this.btnChia.Location = new System.Drawing.Point(438, 214);
            this.btnChia.Name = "btnChia";
            this.btnChia.Size = new System.Drawing.Size(82, 30);
            this.btnChia.TabIndex = 7;
            this.btnChia.Text = "Chia";
            this.btnChia.UseVisualStyleBackColor = true;
            this.btnChia.Click += new System.EventHandler(this.btnChia_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(630, 263);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(146, 95);
            this.btnthoat.TabIndex = 8;
            this.btnthoat.Text = "Thoat";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // lblKetqua
            // 
            this.lblKetqua.AutoSize = true;
            this.lblKetqua.Location = new System.Drawing.Point(42, 338);
            this.lblKetqua.Name = "lblKetqua";
            this.lblKetqua.Size = new System.Drawing.Size(64, 20);
            this.lblKetqua.TabIndex = 9;
            this.lblKetqua.Text = "Ket qua";
            // 
            // txtKetqua
            // 
            this.txtKetqua.Location = new System.Drawing.Point(115, 332);
            this.txtKetqua.Name = "txtKetqua";
            this.txtKetqua.Size = new System.Drawing.Size(214, 26);
            this.txtKetqua.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtKetqua);
            this.Controls.Add(this.lblKetqua);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btnChia);
            this.Controls.Add(this.btnNhan);
            this.Controls.Add(this.btnTru);
            this.Controls.Add(this.btnCong);
            this.Controls.Add(this.lblnhap_b);
            this.Controls.Add(this.lblnhap_a);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtA);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Label lblnhap_a;
        private System.Windows.Forms.Label lblnhap_b;
        private System.Windows.Forms.Button btnCong;
        private System.Windows.Forms.Button btnTru;
        private System.Windows.Forms.Button btnNhan;
        private System.Windows.Forms.Button btnChia;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Label lblKetqua;
        private System.Windows.Forms.TextBox txtKetqua;
    }
}

