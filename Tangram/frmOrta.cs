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
    public partial class frmOrta : Form
    {
        public frmOrta()
        {
            InitializeComponent();
        }

        private void btnO1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmO1 o1 = new frmO1();
            o1.Show();
        }

        private void btnO2_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmO2 o2 = new frmO2();
            o2.Show();
        }

        private void btnO3_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmO3 o3 = new frmO3();
            o3.Show();
        }
    }
}
