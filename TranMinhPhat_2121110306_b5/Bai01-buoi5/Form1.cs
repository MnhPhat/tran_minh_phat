using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai01_buoi5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] danhsachkhoa = { "CNTT", "QTKD", "Kế toán", "Ngoại Ngữ" };
       
        private void Form1_Load(object sender, EventArgs e)
        {
            dtpngaysinh.MaxDate = DateTime.Now;
            loadkhoa();

        }
        private void loadkhoa()
        {
            cbkhoa.DataSource = danhsachkhoa;
            cbkhoa.SelectedItem = 0;
        }
         
        private void btnthem_Click(object sender, EventArgs e)
        {
            try
            {
                if(tb_msv.Text.Length!=10)
                {
                    throw new Exception("Mã sinh viên phải 10 kí tự");

                }
                if(Tb_hoten.Text.Length<2)
                {
                    throw new Exception("Họ tên ít nhất phải 2 kí tự");
                }
                //lấy thông tin
                string masv = tb_msv.Text;
                string hoten = Tb_hoten.Text;
                string ngaysinh = dtpngaysinh.Text;
                string khoa = cbkhoa.Text;
                //lưu dữ liệu vào lưới
                int rowindex = dgvdanhsach.Rows.Add();
                dgvdanhsach.Rows[rowindex].Cells["dtmsv"].Value = masv;
                dgvdanhsach.Rows[rowindex].Cells["dthoten"].Value = hoten;
                dgvdanhsach.Rows[rowindex].Cells["dtdiemtb"].Value = ngaysinh;
                dgvdanhsach.Rows[rowindex].Cells["dtKhoa"].Value = khoa;
            }
            catch ( Exception ex)
            {
                MessageBox.Show(ex.Message,"Thông Báo",MessageBoxButtons.OK,MessageBoxIcon.Information );
            }
        }
        int rowchoose;
        private void dgvdanhsach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
             

            try
            {
                if(e.RowIndex==-1||e.RowIndex>=dgvdanhsach.Rows.Count-1)
                {
                    throw new Exception("Chưa chọn sinh viên");
                }
                rowchoose = e.RowIndex;
                tb_msv.Text = dgvdanhsach.Rows[rowchoose].Cells["dtmsv"].Value.ToString();
                Tb_hoten.Text = dgvdanhsach.Rows[rowchoose].Cells["dthoten"].Value.ToString();
                dtpngaysinh.Text = dgvdanhsach.Rows[rowchoose].Cells["dtngaysinh"].Value.ToString();
                cbkhoa.Text = dgvdanhsach.Rows[rowchoose].Cells["dtkhoa"].Value.ToString();
                btnthoat.Enabled = true;
                btnxoa.Enabled = true;
            }
            catch( Exception ex )
            {
                MessageBox.Show(ex.Message,"Thông Báo",MessageBoxButtons.OK,MessageBoxIcon.Information );
            }
          
        }

        private void btnxoa_Click(object sender, EventArgs e)
        { 
            
            try
            {
                if (rowchoose == -1 || rowchoose>= dgvdanhsach.Rows.Count - 1){
                    throw new Exception("Chưa chọn sinh viên để xóa");
                }
                dgvdanhsach.Rows.RemoveAt(rowchoose);
                rowchoose = -1;
            }
            catch( Exception ex )
            {
                MessageBox.Show(ex.Message,"Thông Báo",MessageBoxButtons.OK, MessageBoxIcon.Information );
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có muốn thoát không",
                "Thông Báo",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                );
            if (result==DialogResult.Yes)
            {
                Application.Exit();
            }

        }

    }
}
