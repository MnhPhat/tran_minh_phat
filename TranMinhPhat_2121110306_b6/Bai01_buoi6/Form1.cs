using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai01_buoi6
{
    public partial class frmlogin : Form
    {
        public frmlogin()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string username=txtuser.Text.Trim();
            string password =txtmatkhau.Text.Trim();
            if (username == "admin" && password == "123")
            {
                MessageBox.Show("Đăng nhập thành công!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Tên người dùng hoặc mật khẩu không đúng!");
            }
        }
    }
}
        