using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai01_buoi7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        SinhVienDao svDAO = new SinhVienDao();
        KhoaDao khDAO = new KhoaDao();
        string insertupdate = "";
        private void Form1_Load(object sender, EventArgs e)
        {
            btnxoa.Enabled = false;
            btnsua.Enabled = false;
           
            

            loadDSKhoa();

          

        }
       



        private void loadDSKhoa()
        {
            dgvdanhsach.DataSource = khDAO.getlist();
            dgvdanhsach.DataSource = "MaKhoa";
            dgvdanhsach.DataSource = "TenKhoa";
            dgvdanhsach.DataSource = "GhiChu";
        }
      

        private void btnthem_Click(object sender, EventArgs e)
        {
            insertupdate = "insert";
            btnluu.Enabled = true;
            
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            insertupdate = "update";
            btnluu.Enabled = true;
          
        }

        private void dgvdanhsach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                int rowindex = e.RowIndex;
                if (rowindex == -1 || rowindex >= dgvdanhsach.Rows.Count - 1)
                {
                    throw new Exception("Chưa chọn sinh viên");
                }


                txtmakhoa.Text = dgvdanhsach.Rows[rowindex].Cells["lvmakhoa"].Value.ToString();
                txttenkhoa.Text = dgvdanhsach.Rows[rowindex].Cells["lvtenkhoa"].Value.ToString();
                txtghichu.Text = dgvdanhsach.Rows[rowindex].Cells["lvghichu"].Value.ToString();
               
                btnxoa.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (txtmakhoa.Text.Length != 10)
                {
                    throw new Exception("Mã khoa phải đủ 10 kí tự số");
                }
              
                string makhoa = txtmakhoa.Text;
                string tenkhoa = txttenkhoa.Text;
                string ghichu = txtghichu.Text;
                Khoa k = new Khoa( makhoa,tenkhoa,ghichu);
                switch (insertupdate) {
                    case "insert":
                        {

                            khDAO.InsertTwo(k);
                            loadDSKhoa();
                          
                            MessageBox.Show("Thêm thành công", "thông báo");
                            break;
                        }
                    case "update":
                        {
                            khDAO.UpdateTwo(k);
                            loadDSKhoa();
                            
                            MessageBox.Show("Cập nhật thành công", "Thông báo");
                            break;
                        }    }
                }

             catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
               

            }

     

        private void btnxoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtmakhoa.Text.Length != 10)
                    throw new Exception("Mã khoa không đúng");
                string makhoa = txtmakhoa.Text;
                svDAO.DeleteTwo(makhoa);
                loadDSKhoa();
                
                MessageBox.Show("Xóa thành công", "Thông báo");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes) { }
                {
                Application.Exit(); 
                }
        }
    }
}

       
