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
    public partial class frmLevel : Form
    {
        public frmLevel()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
           
        }

        private void btnKolay_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmKolay k = new frmKolay();
            k.Show();
        }

        private void btnOrta_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmOrta O = new frmOrta();
            O.Show();
        }

        private void btnZor_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmZor z = new frmZor();
            z.Show();
        }
    }
}
