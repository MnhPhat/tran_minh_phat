namespace Bai3_03
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
            this.gbtt = new System.Windows.Forms.GroupBox();
            this.txtsoluong = new System.Windows.Forms.MaskedTextBox();
            this.txtgia = new System.Windows.Forms.MaskedTextBox();
            this.txtten = new System.Windows.Forms.MaskedTextBox();
            this.txtmasach = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbmasach = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnthoat = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.maskedTextBox5 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox6 = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblsach = new System.Windows.Forms.GroupBox();
            this.gbtt.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbtt
            // 
            this.gbtt.Controls.Add(this.txtsoluong);
            this.gbtt.Controls.Add(this.txtgia);
            this.gbtt.Controls.Add(this.txtten);
            this.gbtt.Controls.Add(this.txtmasach);
            this.gbtt.Controls.Add(this.label4);
            this.gbtt.Controls.Add(this.label3);
            this.gbtt.Controls.Add(this.label2);
            this.gbtt.Controls.Add(this.lbmasach);
            this.gbtt.Location = new System.Drawing.Point(13, 13);
            this.gbtt.Name = "gbtt";
            this.gbtt.Size = new System.Drawing.Size(379, 398);
            this.gbtt.TabIndex = 0;
            this.gbtt.TabStop = false;
            this.gbtt.Text = "Nhập thông tin sách";
            // 
            // txtsoluong
            // 
            this.txtsoluong.Location = new System.Drawing.Point(119, 300);
            this.txtsoluong.Mask = "0000";
            this.txtsoluong.Name = "txtsoluong";
            this.txtsoluong.Size = new System.Drawing.Size(242, 26);
            this.txtsoluong.TabIndex = 7;
            // 
            // txtgia
            // 
            this.txtgia.Location = new System.Drawing.Point(119, 234);
            this.txtgia.Mask = "000000 VNĐ";
            this.txtgia.Name = "txtgia";
            this.txtgia.Size = new System.Drawing.Size(242, 26);
            this.txtgia.TabIndex = 6;
            // 
            // txtten
            // 
            this.txtten.Location = new System.Drawing.Point(119, 134);
            this.txtten.Name = "txtten";
            this.txtten.Size = new System.Drawing.Size(242, 26);
            this.txtten.TabIndex = 5;
            // 
            // txtmasach
            // 
            this.txtmasach.Location = new System.Drawing.Point(119, 58);
            this.txtmasach.Name = "txtmasach";
            this.txtmasach.Size = new System.Drawing.Size(242, 26);
            this.txtmasach.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 303);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Số lượng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Giá";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên sách";
            // 
            // lbmasach
            // 
            this.lbmasach.AutoSize = true;
            this.lbmasach.Location = new System.Drawing.Point(7, 65);
            this.lbmasach.Name = "lbmasach";
            this.lbmasach.Size = new System.Drawing.Size(69, 20);
            this.lbmasach.TabIndex = 0;
            this.lbmasach.Text = "Mã sách";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnthoat);
            this.groupBox1.Controls.Add(this.btnxoa);
            this.groupBox1.Controls.Add(this.btnthem);
            this.groupBox1.Controls.Add(this.maskedTextBox5);
            this.groupBox1.Controls.Add(this.maskedTextBox6);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(409, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(393, 212);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chức Năng";
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(280, 82);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(113, 55);
            this.btnthoat.TabIndex = 10;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(153, 82);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(113, 55);
            this.btnxoa.TabIndex = 9;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(11, 82);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(113, 55);
            this.btnthem.TabIndex = 8;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // maskedTextBox5
            // 
            this.maskedTextBox5.Location = new System.Drawing.Point(119, 300);
            this.maskedTextBox5.Name = "maskedTextBox5";
            this.maskedTextBox5.Size = new System.Drawing.Size(242, 26);
            this.maskedTextBox5.TabIndex = 7;
            // 
            // maskedTextBox6
            // 
            this.maskedTextBox6.Location = new System.Drawing.Point(119, 234);
            this.maskedTextBox6.Mask = "00-000 VNĐ";
            this.maskedTextBox6.Name = "maskedTextBox6";
            this.maskedTextBox6.Size = new System.Drawing.Size(242, 26);
            this.maskedTextBox6.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 303);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Số lượng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Giá";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 20);
            this.label6.TabIndex = 1;
            // 
            // lblsach
            // 
            this.lblsach.Location = new System.Drawing.Point(409, 247);
            this.lblsach.Name = "lblsach";
            this.lblsach.Size = new System.Drawing.Size(379, 178);
            this.lblsach.TabIndex = 9;
            this.lblsach.TabStop = false;
            this.lblsach.Text = "Sách";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblsach);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbtt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbtt.ResumeLayout(false);
            this.gbtt.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbtt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbmasach;
        private System.Windows.Forms.MaskedTextBox txtsoluong;
        private System.Windows.Forms.MaskedTextBox txtgia;
        private System.Windows.Forms.MaskedTextBox txtten;
        private System.Windows.Forms.MaskedTextBox txtmasach;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox5;
        private System.Windows.Forms.MaskedTextBox maskedTextBox6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.GroupBox lblsach;
    }
}

