using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Supermarket_ad0487
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            pnlshow.Controls.Clear();
            Form4 frm = new Form4();
            frm.TopLevel = false;
            frm.AutoScroll = true;
           
            pnlshow.Controls.Add(frm);
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Show();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            pnlshow.Controls.Clear();
            Form3 frm = new Form3();
            frm.TopLevel = false;
            frm.AutoScroll = true;
            
            pnlshow.Controls.Add(frm);
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Show();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
