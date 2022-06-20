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
    public partial class frmmenu : Form
    {
        private string Showname;
        public frmmenu(string showname)
        {
            Showname = showname;
            InitializeComponent();
        }

        private void frmmenu_Load(object sender, EventArgs e)
        {

        }
    }
}
