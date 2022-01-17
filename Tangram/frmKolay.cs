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
    public partial class frmKolay : Form
    {
        public frmKolay()
        {
            InitializeComponent();
        }

        private void btnK1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmK1 k1 = new frmK1();
            k1.Show();
        }

        private void btnK2_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmK2 k2 = new frmK2();
            k2.Show();
        }

        private void btnK3_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmK3 k3 = new frmK3();
            k3.Show();
        }
    }
}
