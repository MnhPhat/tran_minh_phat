using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai3_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            try
            {
                double a, b;
                if(!double.TryParse(txtA.Text,out a))
                {
                    throw new Exception("so A khong dc de trong hoac la so ");
                }
                if(!double.TryParse(txtB.Text,out b))
                { 
                    throw new Exception("so b khong dc de trong phai co so"); 
                }
                txtKetqua.Text = (a + b).ToString();

            }
            catch (Exception ex)
            {
                txtKetqua.Text += ex.Message;
            }
        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            try
            {
                double a, b;
                if (double.TryParse(txtA.Text, out a))
                {
                    throw new Exception("so A khong dc de trong hoac la so ");
                }
                if (double.TryParse(txtB.Text, out b))
                {
                    throw new Exception("so b khong dc de trong phai co so");
                }
                txtKetqua.Text = (a - b).ToString();

            }
            catch (Exception ex)
            {
                txtKetqua.Text += ex.Message;
            }
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            try
            {
                double a, b;
                if (double.TryParse(txtA.Text, out a))
                {
                    throw new Exception("so A khong dc de trong hoac la so ");
                }
                if (double.TryParse(txtB.Text, out b))
                {
                    throw new Exception("so b khong dc de trong phai co so");
                }
                txtKetqua.Text = (a * b).ToString();

            }
            catch (Exception ex)
            {
                txtKetqua.Text += ex.Message;
            }
        }

        private void btnChia_Click(object sender, EventArgs e)
        {
            try
            {
                double a, b;
                if (!double.TryParse(txtA.Text, out a))
                {
                    throw new Exception("so A khong dc de trong hoac la so ");
                }
                
                if (!double.TryParse(txtB.Text, out b))
                {
                    throw new Exception("so b khong dc de trong phai co so va khac khong");
                }
                if (b == 0)
                {
                    throw new Exception("so b khong dc bang 0");
                }
                txtKetqua.Text = (a / b).ToString();

            }
            catch (Exception ex)
            {
                txtKetqua.Text += ex.Message;
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }   
}
