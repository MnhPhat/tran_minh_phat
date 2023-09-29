namespace Bai3_02
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txthovaten = new System.Windows.Forms.MaskedTextBox();
            this.txtngaysinh = new System.Windows.Forms.MaskedTextBox();
            this.TxtMasv = new System.Windows.Forms.MaskedTextBox();
            this.rdbnu = new System.Windows.Forms.RadioButton();
            this.rdbNam = new System.Windows.Forms.RadioButton();
            this.checkmuasam = new System.Windows.Forms.CheckBox();
            this.checkdulich = new System.Windows.Forms.CheckBox();
            this.checkTT = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblNgaysinh = new System.Windows.Forms.Label();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.lblmsv = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.gbdanhsach = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gbdanhsach.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txthovaten);
            this.groupBox1.Controls.Add(this.txtngaysinh);
            this.groupBox1.Controls.Add(this.TxtMasv);
            this.groupBox1.Controls.Add(this.rdbnu);
            this.groupBox1.Controls.Add(this.rdbNam);
            this.groupBox1.Controls.Add(this.checkmuasam);
            this.groupBox1.Controls.Add(this.checkdulich);
            this.groupBox1.Controls.Add(this.checkTT);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblNgaysinh);
            this.groupBox1.Controls.Add(this.lblHoTen);
            this.groupBox1.Controls.Add(this.lblmsv);
            this.groupBox1.Location = new System.Drawing.Point(21, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(310, 389);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập Thông Tin";
            // 
            // txthovaten
            // 
            this.txthovaten.Location = new System.Drawing.Point(109, 92);
            this.txthovaten.Name = "txthovaten";
            this.txthovaten.Size = new System.Drawing.Size(195, 26);
            this.txthovaten.TabIndex = 19;
            // 
            // txtngaysinh
            // 
            this.txtngaysinh.Location = new System.Drawing.Point(109, 147);
            this.txtngaysinh.Mask = "00/00/0000";
            this.txtngaysinh.Name = "txtngaysinh";
            this.txtngaysinh.Size = new System.Drawing.Size(195, 26);
            this.txtngaysinh.TabIndex = 18;
            this.txtngaysinh.ValidatingType = typeof(System.DateTime);
            // 
            // TxtMasv
            // 
            this.TxtMasv.Location = new System.Drawing.Point(109, 41);
            this.TxtMasv.Mask = "2100000000";
            this.TxtMasv.Name = "TxtMasv";
            this.TxtMasv.Size = new System.Drawing.Size(195, 26);
            this.TxtMasv.TabIndex = 17;
           
            // 
            // rdbnu
            // 
            this.rdbnu.AutoSize = true;
            this.rdbnu.Location = new System.Drawing.Point(184, 201);
            this.rdbnu.Name = "rdbnu";
            this.rdbnu.Size = new System.Drawing.Size(54, 24);
            this.rdbnu.TabIndex = 16;
            this.rdbnu.TabStop = true;
            this.rdbnu.Text = "Nữ";
            this.rdbnu.UseVisualStyleBackColor = true;
            // 
            // rdbNam
            // 
            this.rdbNam.AutoSize = true;
            this.rdbNam.Location = new System.Drawing.Point(63, 201);
            this.rdbNam.Name = "rdbNam";
            this.rdbNam.Size = new System.Drawing.Size(67, 24);
            this.rdbNam.TabIndex = 15;
            this.rdbNam.TabStop = true;
            this.rdbNam.Text = "Nam";
            this.rdbNam.UseVisualStyleBackColor = true;
            // 
            // checkmuasam
            // 
            this.checkmuasam.AutoSize = true;
            this.checkmuasam.Location = new System.Drawing.Point(85, 359);
            this.checkmuasam.Name = "checkmuasam";
            this.checkmuasam.Size = new System.Drawing.Size(100, 24);
            this.checkmuasam.TabIndex = 14;
            this.checkmuasam.Text = "Mua sắm";
            this.checkmuasam.UseVisualStyleBackColor = true;
            // 
            // checkdulich
            // 
            this.checkdulich.AutoSize = true;
            this.checkdulich.Location = new System.Drawing.Point(85, 305);
            this.checkdulich.Name = "checkdulich";
            this.checkdulich.Size = new System.Drawing.Size(83, 24);
            this.checkdulich.TabIndex = 13;
            this.checkdulich.Text = "Du lịch";
            this.checkdulich.UseVisualStyleBackColor = true;
            // 
            // checkTT
            // 
            this.checkTT.AutoSize = true;
            this.checkTT.Location = new System.Drawing.Point(85, 252);
            this.checkTT.Name = "checkTT";
            this.checkTT.Size = new System.Drawing.Size(102, 24);
            this.checkTT.TabIndex = 12;
            this.checkTT.Text = "Thể Thao";
            this.checkTT.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(114, 168);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 20);
            this.label7.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(114, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 20);
            this.label6.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 256);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Sở thích";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(-4, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Giới tính";
            // 
            // lblNgaysinh
            // 
            this.lblNgaysinh.AutoSize = true;
            this.lblNgaysinh.Location = new System.Drawing.Point(6, 147);
            this.lblNgaysinh.Name = "lblNgaysinh";
            this.lblNgaysinh.Size = new System.Drawing.Size(78, 20);
            this.lblNgaysinh.TabIndex = 3;
            this.lblNgaysinh.Text = "Ngày sinh";
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Location = new System.Drawing.Point(6, 92);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(77, 20);
            this.lblHoTen.TabIndex = 2;
            this.lblHoTen.Text = "Họ và tên";
            // 
            // lblmsv
            // 
            this.lblmsv.AutoSize = true;
            this.lblmsv.Location = new System.Drawing.Point(6, 41);
            this.lblmsv.Name = "lblmsv";
            this.lblmsv.Size = new System.Drawing.Size(96, 20);
            this.lblmsv.TabIndex = 0;
            this.lblmsv.Text = "Mã sinh viên";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnsua);
            this.groupBox2.Controls.Add(this.btnxoa);
            this.groupBox2.Controls.Add(this.btnthem);
            this.groupBox2.Location = new System.Drawing.Point(362, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(411, 111);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng";
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(291, 33);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(103, 41);
            this.btnsua.TabIndex = 2;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(150, 33);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(113, 41);
            this.btnxoa.TabIndex = 1;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(7, 36);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(102, 38);
            this.btnthem.TabIndex = 0;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.button1_Click);
            // 
            // gbdanhsach
            // 
            this.gbdanhsach.Controls.Add(this.label2);
            this.gbdanhsach.Controls.Add(this.label1);
            this.gbdanhsach.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.gbdanhsach.Location = new System.Drawing.Point(362, 159);
            this.gbdanhsach.Name = "gbdanhsach";
            this.gbdanhsach.Size = new System.Drawing.Size(411, 242);
            this.gbdanhsach.TabIndex = 2;
            this.gbdanhsach.TabStop = false;
            this.gbdanhsach.Text = "Danh sách";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbdanhsach);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.gbdanhsach.ResumeLayout(false);
            this.gbdanhsach.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblNgaysinh;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.Label lblmsv;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox gbdanhsach;
        private System.Windows.Forms.RadioButton rdbnu;
        private System.Windows.Forms.RadioButton rdbNam;
        private System.Windows.Forms.CheckBox checkmuasam;
        private System.Windows.Forms.CheckBox checkdulich;
        private System.Windows.Forms.CheckBox checkTT;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnthem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.MaskedTextBox TxtMasv;
        private System.Windows.Forms.MaskedTextBox txthovaten;
        private System.Windows.Forms.MaskedTextBox txtngaysinh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

