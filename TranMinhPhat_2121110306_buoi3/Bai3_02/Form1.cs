using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai3_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int stt = 1;
            try
            {
                if (txthovaten.Text.Trim().Length == 0)
                {
                    throw new Exception("Tên không được để trống");
                }
                if (TxtMasv.Text.Length != 10)
                {
                    throw new Exception("Mã sinh viên không hợp lệ");
                }
                if (txtngaysinh.Text.Length != 10)
                {
                    throw new Exception("Ngày sinh không hợp lệ ");
                }
                string hoten = txthovaten.Text;
                string masv = TxtMasv.Text;
                string ngaysinh = txtngaysinh.Text;
                string gioitinh = (rdbNam.Checked) ? "Nam" : "Nữ";
                string sothich = null;
                if (checkdulich.Checked)
                {
                    sothich += "Du Lịch";
                }
                if (checkTT.Checked)
                {
                    sothich += "Thể Thao";
                }
                if (checkmuasam.Checked)
                {
                    sothich += "Mua sắm";
                }
                if (sothich != null)
                {
                    sothich += "Sở thích: " + sothich;
                }
                gbdanhsach.Text +="\n"+ stt + "Họ tên: " + hoten + "\n" + "Ngày sinh: " + ngaysinh + "\n" + "Giới tính: " + gioitinh + "\n" + sothich + "\r\n";
                stt++;
            
            }catch (Exception ex)
            {
                gbdanhsach.Text = ex.Message;
            }

        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}
