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
    public partial class frmZor : Form
    {
        public frmZor()
        {
            InitializeComponent();
        }

        private void btnZ1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmZ1 z1 = new frmZ1();
            z1.Show();
        }

        private void btnZ2_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmZ2 z2 = new frmZ2();
            z2.Show();
        }

        private void btnZ3_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmZ3 z3 = new frmZ3();
            z3.Show();
        }
    }
}
