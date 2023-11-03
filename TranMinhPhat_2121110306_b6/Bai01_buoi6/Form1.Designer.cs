namespace Bai01_buoi6
{
    partial class frmlogin
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtuser = new System.Windows.Forms.TextBox();
            this.txtmatkhau = new System.Windows.Forms.TextBox();
            this.btnlogin = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblthongbao = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên đăng nhập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 340);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật khẩu";
            // 
            // txtuser
            // 
            this.txtuser.Location = new System.Drawing.Point(262, 134);
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(469, 26);
            this.txtuser.TabIndex = 2;
            this.txtuser.Text = "admin";
            // 
            // txtmatkhau
            // 
            this.txtmatkhau.Location = new System.Drawing.Point(262, 340);
            this.txtmatkhau.Name = "txtmatkhau";
            this.txtmatkhau.PasswordChar = '*';
            this.txtmatkhau.Size = new System.Drawing.Size(469, 26);
            this.txtmatkhau.TabIndex = 3;
            this.txtmatkhau.Text = "123";
            // 
            // btnlogin
            // 
            this.btnlogin.Location = new System.Drawing.Point(400, 520);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(239, 47);
            this.btnlogin.TabIndex = 4;
            this.btnlogin.Text = "Đăng nhập";
            this.btnlogin.UseVisualStyleBackColor = true;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 533);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 20);
            this.label3.TabIndex = 5;
            // 
            // lblthongbao
            // 
            this.lblthongbao.AutoSize = true;
            this.lblthongbao.ForeColor = System.Drawing.Color.Red;
            this.lblthongbao.Location = new System.Drawing.Point(117, 533);
            this.lblthongbao.Name = "lblthongbao";
            this.lblthongbao.Size = new System.Drawing.Size(0, 20);
            this.lblthongbao.TabIndex = 6;
            // 
            // frmlogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 651);
            this.Controls.Add(this.lblthongbao);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.txtmatkhau);
            this.Controls.Add(this.txtuser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmlogin";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtuser;
        private System.Windows.Forms.TextBox txtmatkhau;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblthongbao;
    }
}

