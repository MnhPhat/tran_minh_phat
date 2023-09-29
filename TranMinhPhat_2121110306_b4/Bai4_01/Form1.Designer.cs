namespace Bai4_01
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
            System.Windows.Forms.ListViewGroup listViewGroup3 = new System.Windows.Forms.ListViewGroup("Họ tên", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup4 = new System.Windows.Forms.ListViewGroup("Khoa", System.Windows.Forms.HorizontalAlignment.Left);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbdanhsach = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnlaiall = new System.Windows.Forms.Button();
            this.btnlai1 = new System.Windows.Forms.Button();
            this.btnall = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.cbkhoa = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnthoat = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.txthoten = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lvsinhvien = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbdanhsach);
            this.groupBox1.Location = new System.Drawing.Point(12, 109);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(276, 279);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách sinh viên";
            // 
            // lbdanhsach
            // 
            this.lbdanhsach.FormattingEnabled = true;
            this.lbdanhsach.ItemHeight = 20;
            this.lbdanhsach.Location = new System.Drawing.Point(16, 51);
            this.lbdanhsach.Name = "lbdanhsach";
            this.lbdanhsach.Size = new System.Drawing.Size(239, 224);
            this.lbdanhsach.TabIndex = 0;
  
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnlaiall);
            this.groupBox2.Controls.Add(this.btnlai1);
            this.groupBox2.Controls.Add(this.btnall);
            this.groupBox2.Controls.Add(this.btn1);
            this.groupBox2.Controls.Add(this.cbkhoa);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(304, 109);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(234, 329);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng";
            // 
            // btnlaiall
            // 
            this.btnlaiall.Location = new System.Drawing.Point(28, 289);
            this.btnlaiall.Name = "btnlaiall";
            this.btnlaiall.Size = new System.Drawing.Size(177, 34);
            this.btnlaiall.TabIndex = 5;
            this.btnlaiall.Text = "<<";
            this.btnlaiall.UseVisualStyleBackColor = true;
            // 
            // btnlai1
            // 
            this.btnlai1.Location = new System.Drawing.Point(28, 230);
            this.btnlai1.Name = "btnlai1";
            this.btnlai1.Size = new System.Drawing.Size(177, 34);
            this.btnlai1.TabIndex = 4;
            this.btnlai1.Text = "<";
            this.btnlai1.UseVisualStyleBackColor = true;
            // 
            // btnall
            // 
            this.btnall.Location = new System.Drawing.Point(28, 170);
            this.btnall.Name = "btnall";
            this.btnall.Size = new System.Drawing.Size(177, 34);
            this.btnall.TabIndex = 3;
            this.btnall.Text = ">>";
            this.btnall.UseVisualStyleBackColor = true;
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(28, 119);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(177, 34);
            this.btn1.TabIndex = 2;
            this.btn1.Text = ">";
            this.btn1.UseVisualStyleBackColor = true;
            // 
            // cbkhoa
            // 
            this.cbkhoa.FormattingEnabled = true;
            this.cbkhoa.Items.AddRange(new object[] {
            "1.Công Nghệ Thông Tin",
            "2.Công Nghệ Thực Phẩm",
            "3.Logistic"});
            this.cbkhoa.Location = new System.Drawing.Point(11, 70);
            this.cbkhoa.Name = "cbkhoa";
            this.cbkhoa.Size = new System.Drawing.Size(217, 28);
            this.cbkhoa.TabIndex = 1;
            this.cbkhoa.Tag = "Công Nghệ Thông Tin";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "khoa";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnthoat);
            this.groupBox3.Controls.Add(this.btnthem);
            this.groupBox3.Controls.Add(this.txthoten);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(13, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(787, 90);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sinh Viên";
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(682, 24);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(87, 38);
            this.btnthoat.TabIndex = 3;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(567, 25);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(87, 38);
            this.btnthem.TabIndex = 2;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // txthoten
            // 
            this.txthoten.Location = new System.Drawing.Point(99, 36);
            this.txthoten.Name = "txthoten";
            this.txthoten.Size = new System.Drawing.Size(426, 26);
            this.txthoten.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Họ Tên";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lvsinhvien);
            this.groupBox4.Location = new System.Drawing.Point(544, 109);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(256, 329);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Sinh viên được chọn";
            // 
            // lvsinhvien
            // 
            this.lvsinhvien.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            listViewGroup3.Header = "Họ tên";
            listViewGroup3.Name = "lv1";
            listViewGroup4.Header = "Khoa";
            listViewGroup4.Name = "lv2";
            this.lvsinhvien.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup3,
            listViewGroup4});
            this.lvsinhvien.HideSelection = false;
            this.lvsinhvien.Location = new System.Drawing.Point(7, 25);
            this.lvsinhvien.Name = "lvsinhvien";
            this.lvsinhvien.Size = new System.Drawing.Size(237, 298);
            this.lvsinhvien.TabIndex = 0;
            this.lvsinhvien.UseCompatibleStateImageBehavior = false;
            this.lvsinhvien.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Họ tên";
            this.columnHeader1.Width = 114;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Khoa";
            this.columnHeader2.Width = 121;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lbdanhsach;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnlaiall;
        private System.Windows.Forms.Button btnlai1;
        private System.Windows.Forms.Button btnall;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.ComboBox cbkhoa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.TextBox txthoten;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListView lvsinhvien;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}

