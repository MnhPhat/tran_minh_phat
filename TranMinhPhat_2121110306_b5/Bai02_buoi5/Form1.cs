using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai02_buoi5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbkhoa = new System.Windows.Forms.ComboBox();
            this.tbdiemtb = new System.Windows.Forms.TextBox();
            this.tbhoten = new System.Windows.Forms.TextBox();
            this.tbmsv = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btthoat = new System.Windows.Forms.Button();
            this.btxoa = new System.Windows.Forms.Button();
            this.btsua = new System.Windows.Forms.Button();
            this.btthem = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvdanhsach = new System.Windows.Forms.DataGridView();
            this.dtmsv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dthoten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtdiemtb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdanhsach)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(580, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thông Tin Sinh Viên";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbkhoa);
            this.groupBox1.Controls.Add(this.tbdiemtb);
            this.groupBox1.Controls.Add(this.tbhoten);
            this.groupBox1.Controls.Add(this.tbmsv);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(47, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1257, 243);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin";
            // 
            // cbkhoa
            // 
            this.cbkhoa.FormattingEnabled = true;
            this.cbkhoa.Location = new System.Drawing.Point(751, 146);
            this.cbkhoa.Name = "cbkhoa";
            this.cbkhoa.Size = new System.Drawing.Size(478, 28);
            this.cbkhoa.TabIndex = 7;
            this.cbkhoa.Text = "Công Nghệ Thông Tin";
            // 
            // tbdiemtb
            // 
            this.tbdiemtb.Location = new System.Drawing.Point(751, 37);
            this.tbdiemtb.Name = "tbdiemtb";
            this.tbdiemtb.Size = new System.Drawing.Size(478, 26);
            this.tbdiemtb.TabIndex = 6;
            // 
            // tbhoten
            // 
            this.tbhoten.Location = new System.Drawing.Point(126, 152);
            this.tbhoten.Name = "tbhoten";
            this.tbhoten.Size = new System.Drawing.Size(478, 26);
            this.tbhoten.TabIndex = 5;
            // 
            // tbmsv
            // 
            this.tbmsv.Location = new System.Drawing.Point(126, 40);
            this.tbmsv.Name = "tbmsv";
            this.tbmsv.Size = new System.Drawing.Size(478, 26);
            this.tbmsv.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(652, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Khoa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(643, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Điểm TB";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Họ Tên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã Sinh viên";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btthoat);
            this.groupBox2.Controls.Add(this.btxoa);
            this.groupBox2.Controls.Add(this.btsua);
            this.groupBox2.Controls.Add(this.btthem);
            this.groupBox2.Location = new System.Drawing.Point(47, 335);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1257, 204);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức Năng";
            // 
            // btthoat
            // 
            this.btthoat.Location = new System.Drawing.Point(985, 54);
            this.btthoat.Name = "btthoat";
            this.btthoat.Size = new System.Drawing.Size(208, 85);
            this.btthoat.TabIndex = 3;
            this.btthoat.Text = "Thoát";
            this.btthoat.UseVisualStyleBackColor = true;
            this.btthoat.Click += new System.EventHandler(this.btthoat_Click);
            // 
            // btxoa
            // 
            this.btxoa.Location = new System.Drawing.Point(656, 54);
            this.btxoa.Name = "btxoa";
            this.btxoa.Size = new System.Drawing.Size(208, 85);
            this.btxoa.TabIndex = 2;
            this.btxoa.Text = "Xóa";
            this.btxoa.UseVisualStyleBackColor = true;
            this.btxoa.Click += new System.EventHandler(this.btxoa_Click);
            // 
            // btsua
            // 
            this.btsua.Location = new System.Drawing.Point(307, 54);
            this.btsua.Name = "btsua";
            this.btsua.Size = new System.Drawing.Size(208, 85);
            this.btsua.TabIndex = 1;
            this.btsua.Text = "Sửa";
            this.btsua.UseVisualStyleBackColor = true;
            this.btsua.Click += new System.EventHandler(this.btsua_Click);
            // 
            // btthem
            // 
            this.btthem.Location = new System.Drawing.Point(24, 54);
            this.btthem.Name = "btthem";
            this.btthem.Size = new System.Drawing.Size(208, 85);
            this.btthem.TabIndex = 0;
            this.btthem.Text = "Thêm";
            this.btthem.UseVisualStyleBackColor = true;
            this.btthem.Click += new System.EventHandler(this.btthem_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvdanhsach);
            this.groupBox3.Location = new System.Drawing.Point(47, 560);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1257, 278);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách";
            // 
            // dgvdanhsach
            // 
            this.dgvdanhsach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdanhsach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dtmsv,
            this.dthoten,
            this.dtdiemtb,
            this.dtKhoa});
            this.dgvdanhsach.Location = new System.Drawing.Point(24, 44);
            this.dgvdanhsach.Name = "dgvdanhsach";
            this.dgvdanhsach.RowHeadersWidth = 62;
            this.dgvdanhsach.RowTemplate.Height = 28;
            this.dgvdanhsach.Size = new System.Drawing.Size(1205, 217);
            this.dgvdanhsach.TabIndex = 0;
            // 
            // dtmsv
            // 
            this.dtmsv.HeaderText = "Mã sinh viên";
            this.dtmsv.MinimumWidth = 8;
            this.dtmsv.Name = "dtmsv";
            this.dtmsv.Width = 150;
            // 
            // dthoten
            // 
            this.dthoten.HeaderText = "Họ Tên";
            this.dthoten.MinimumWidth = 8;
            this.dthoten.Name = "dthoten";
            this.dthoten.Width = 150;
            // 
            // dtdiemtb
            // 
            this.dtdiemtb.HeaderText = "Điểm TB";
            this.dtdiemtb.MinimumWidth = 8;
            this.dtdiemtb.Name = "dtdiemtb";
            this.dtdiemtb.Width = 150;
            // 
            // dtKhoa
            // 
            this.dtKhoa.HeaderText = "Khoa";
            this.dtKhoa.MinimumWidth = 8;
            this.dtKhoa.Name = "dtKhoa";
            this.dtKhoa.Width = 150;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1370, 850);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdanhsach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        int rowindex = -1;
        string[] listkhoa = { "Công Nghệ Thông Tin ", "Kế Toán", "Ngoại Ngữ", "Điện Tử" };
       

        private void Form1_Load(object sender, EventArgs e)
        {
            cbkhoa.DataSource = listkhoa;
        }
       
        private void btthem_Click(object sender, EventArgs e)
        {
            double diemtb;
            
            try
            {
                if (!tbmsv.Text.Length.Equals(1))
                {
                    throw new Exception("Mã sinh viên phải 10 kí tự");

                }
                if (this.checkMaSV(tbmsv.Text)==false)
                {
                    throw new Exception("Họ tên sinh viên đã tồn tại");
                }
                if (tbmsv.Text.Length.Equals(0))
                {
                    throw new Exception("Họ tên sinh viên không dc trống");

                }
                if (!double.TryParse(tbdiemtb.Text,out diemtb))
                {
                    throw new Exception("Điểm TB phải là số");

                }
                //lấy thông tin
                string masv = tbmsv.Text;
                string hoten = tbhoten.Text;
                string khoa = cbkhoa.Text;
                int row = dgvdanhsach.Rows.Add();
                //lưu dữ liệu vào lưới
                
                dgvdanhsach.Rows[row].Cells["dtmsv"].Value = masv;
                dgvdanhsach.Rows[row].Cells["dthoten"].Value = hoten;
                dgvdanhsach.Rows[row].Cells["dtdiemtb"].Value = diemtb;
                dgvdanhsach.Rows[row].Cells["dtkhoa"].Value = khoa;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông Báo");
            }
        }
        public bool checkMaSV(string masv)
        {
            if (dgvdanhsach.Rows.Count == 0)
            {
                return true;
            }
            for (int row = 0; row < dgvdanhsach.Rows.Count - 1; row++)
            {
                if (dgvdanhsach.Rows[row].Cells["masv"].Value.ToString()==masv) { }
                {
                    return false;
                }            
            }
            return true;
        }
        private void dgvdanhsach_CellClick(object sender, DataGridViewCellEventArgs e)
        {


            rowindex=e.RowIndex;
            {
                if (rowindex != -1 && rowindex < dgvdanhsach.Rows.Count - 1)
                
                
                tbmsv.Text = dgvdanhsach.Rows[rowindex].Cells["dtmsv"].Value.ToString();
                tbhoten.Text = dgvdanhsach.Rows[rowindex].Cells["dthoten"].Value.ToString();
                tbdiemtb.Text = dgvdanhsach.Rows[rowindex].Cells["dtngaysinh"].Value.ToString();
                string tenkhoa = dgvdanhsach.Rows[rowindex].Cells["dtkhoa"].Value.ToString();
                int i = 0;
                while (i < listkhoa.Length && listkhoa[i]!=tenkhoa) { 
                i++;
                }
                cbkhoa.SelectedIndex = i;
            }
            

        }

        private void btsua_Click(object sender, EventArgs e)
        {
            double diemtb;
            try
            {
                if(rowindex==-1||rowindex>=dgvdanhsach.Rows.Count)
                {
                    throw new Exception("Chưa chọn sinh viên cần xóa");
                }
                if (!tbmsv.Text.Length.Equals(10))
                {
                    throw new Exception("Mã sinh viên phải 10 kí tự");

                }
                if (this.checkMaSV(tbmsv.Text) == false && tbmsv.Text != dgvdanhsach.Rows[rowindex].Cells["masv"].Value.ToString())
                {
                    throw new Exception("Họ tên sinh viên đã tồn tại");
                }
                if (tbmsv.Text.Length.Equals(0))
                {
                    throw new Exception("Họ tên sinh viên không dc trống");

                }
                if (!double.TryParse(tbdiemtb.Text, out diemtb))
                {
                    throw new Exception("Điểm TB phải là số");

                }
                string masv = tbmsv.Text;
                string hoten = tbhoten.Text;
                string khoa = cbkhoa.Text;
                int row = dgvdanhsach.Rows.Add();
                //lưu dữ liệu vào lưới

                dgvdanhsach.Rows[row].Cells["dtmsv"].Value = masv;
                dgvdanhsach.Rows[row].Cells["dthoten"].Value = hoten;
                dgvdanhsach.Rows[row].Cells["dtdiemtb"].Value = diemtb;
                dgvdanhsach.Rows[row].Cells["dtkhoa"].Value = khoa;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông Báo");
            }
        }

        private void btxoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (rowindex == -1 || rowindex >= dgvdanhsach.Rows.Count - 1)
                {
                    throw new Exception("Chưa chọn sv cần xóa");
                }
                dgvdanhsach.Rows.RemoveAt(rowindex);
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông Báo");
            }
        }

        private void btthoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
               "Bạn có muốn thoát không",
               "Thông Báo",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Question
               );
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
