using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tangram
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHow_Click(object sender, EventArgs e)
        {
            frmHow f = new frmHow();
            f.Show();
        }

        private void btnDev_Click(object sender, EventArgs e)
        {
            frmDev d = new frmDev();
            d.Show();
        }

        private void btnBasla_Click(object sender, EventArgs e)
        {
            frmLevel l = new frmLevel();
            l.Show();
        }
    }
}
