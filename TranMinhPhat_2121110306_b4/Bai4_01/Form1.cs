using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai4_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //private void lbdanhsach_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    lbdanhsach.Items.Add("Nguyễn Văn A");
        //    lbdanhsach.Items.Add("Nguyễn Văn B");
        //    lbdanhsach.Items.Add("Nguyễn Văn C");
        //    lbdanhsach.Items.Add("Nguyễn Văn D");
        //    lbdanhsach.Items.Add("Nguyễn Văn E");
        //    cbkhoa.SelectedIndex = 1;   
        //}

        private void btnthem_Click(object sender, EventArgs e)
        {
            try
            {
                if(txthoten.Text.Length.Equals(0))
                {
                    throw new Exception("Họ tên chưa nhập");
                    
                }
                string hoten = txthoten.Text;
                lbdanhsach.Items.Add (hoten);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
