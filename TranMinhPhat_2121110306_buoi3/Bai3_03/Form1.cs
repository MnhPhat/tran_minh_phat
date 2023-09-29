using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai3_03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            int stt = 1;
            int soluongsach ;
            try
            {
                if (txtmasach.Text.Trim().Length == 0)
                {
                    throw new Exception("Mã sách không được để trống");
                }
                if (txtten.Text.Trim().Length == 0)
                {
                    throw new Exception("Tên sách không được để trống");
                }
                if (txtgia.Text.Length <4)
                {
                    throw new Exception("Giá không hợp lệ ");
                }
                
                if (!int.TryParse(txtsoluong.Text, out soluongsach))
                {
                    throw new Exception(" Số lượng không được để trống   ");
                }
                if(soluongsach < 1)
                {
                    throw  new Exception("số lượng không hợp lệ");
                }
                string tensach = txtten.Text;
                string masach = txtmasach.Text;
                string soluong = txtsoluong.Text;
                string giatien = txtgia.Text;
                lblsach.Text += "\n" + stt + "Mã sách: " + masach + "\n" + "Tên sách: " + tensach + "\n" + "Số lượng: " + soluong + "\n" + "Giá tiền" + giatien + "\r\n";
                stt++;

            }catch (Exception ex) {
            lblsach.Text = ex.Message;
            }
         }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            lblsach.Text = " ";
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
