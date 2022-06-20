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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lstOrder.Items.Add(btnChicken.Text+" "+ lblchicken.Text);

        }

        private void btnClassic_Click(object sender, EventArgs e)
        {
            lstOrder.Items.Add(btnTurkey.Text+" " + lblTurkey.Text);
        }

        private void btnCheese_Click(object sender, EventArgs e)
        {
            lstOrder.Items.Add(btnBurger.Text + " " + lblCheese.Text);
        }

        private void btnAmircan_Click(object sender, EventArgs e)
        {
            lstOrder.Items.Add(btnFish.Text + " " + lblFish.Text);
        }

        private void btnPipsi_Click(object sender, EventArgs e)
        {
            lstOrder.Items.Add(btnPotato.Text + " " + lblPotato.Text);
        }

        private void btn7UP_Click(object sender, EventArgs e)
        {
            lstOrder.Items.Add(btnMilk.Text + " " + lblMilk.Text);

        }

        private void btnMiranda_Click(object sender, EventArgs e)
        {
            lstOrder.Items.Add(btnBread.Text + " " + lblBread.Text);
        }

        private void btnResat_Click(object sender, EventArgs e)
        {
            lstOrder.Items.Clear();
        }

      
    }
}
