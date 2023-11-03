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
    public partial class Formmain : Form
    {
        public Formmain()
        {
            InitializeComponent();
        }

        public static string username = null;
        public static List<string> listkhoa = new List<string>();

  

        private void frmMain_Load(object sender, EventArgs e)
        {
            if (username == null)
            {
                Form frmlogin = new frmlogin();
                frmlogin.ShowDialog();
               
            }
        }

     
    }
}
