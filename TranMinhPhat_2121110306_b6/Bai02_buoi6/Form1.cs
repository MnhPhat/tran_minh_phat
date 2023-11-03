using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai02_buoi6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addformToPanel(Form form)
        {
            form.FormBorderStyle = FormBorderStyle.None;
            form.TopLevel = false;
            pnhead.Dock= DockStyle.Fill;
            pnhead.Controls.Clear();
            pnhead.Controls.Add(form);
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form frm = new formsinhvien();
            addformToPanel(frm);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form frm = new formkhoa();
            addformToPanel(frm);
        }
    }
}
