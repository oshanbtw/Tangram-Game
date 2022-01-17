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
    public partial class frmK1 : Form
    {
        public frmK1()
        {
            InitializeComponent();
            INIT();
        }
        int sayac = 0;
        private Point firstPoint = new Point();
        public void INIT()
        {
            
            //Taşın sürüklenebilir olması için
            pictureBox2.MouseDown += (ss, ee) =>
            {
                if (ee.Button == System.Windows.Forms.MouseButtons.Left) { firstPoint = Control.MousePosition; }
            };
            pictureBox2.MouseMove += (ss, ee) =>
            {
                if (ee.Button == System.Windows.Forms.MouseButtons.Left)
                {
                    Point temp = Control.MousePosition;
                    Point res = new Point(firstPoint.X - temp.X, firstPoint.Y - temp.Y);

                    pictureBox2.Location = new Point(pictureBox2.Location.X - res.X, pictureBox2.Location.Y - res.Y);

                    firstPoint = temp;
                }

                //Taşın yerine oturması için
                if (pictureBox2.Location.X >= 90 && pictureBox2.Location.X <= 340 && pictureBox2.Location.Y >= 150 && pictureBox2.Location.Y <= 440)
                {
                    pictureBox2.Location = new Point(236, 284);
                    sayac++;
                }
            };

            //Taşın sürüklenebilir olması için
            pictureBox3.MouseDown += (ss, ee) =>
            {
                if (ee.Button == System.Windows.Forms.MouseButtons.Left) { firstPoint = Control.MousePosition; }
            };
            pictureBox3.MouseMove += (ss, ee) =>
            {
                if (ee.Button == System.Windows.Forms.MouseButtons.Left)
                {
                    Point temp = Control.MousePosition;
                    Point res = new Point(firstPoint.X - temp.X, firstPoint.Y - temp.Y);

                    pictureBox3.Location = new Point(pictureBox3.Location.X - res.X, pictureBox3.Location.Y - res.Y);

                    firstPoint = temp;
                }
                
                //Taşın yerine oturması için
                if (pictureBox3.Location.X >= 330 && pictureBox3.Location.X <= 430 && pictureBox3.Location.Y >= 165 && pictureBox3.Location.Y <= 255)
                {
                    pictureBox3.Location = new Point(374, 216);
                    sayac++;
                }
            };

            //Taşın sürüklenebilir olması için
            pictureBox4.MouseDown += (ss, ee) =>
            {
                if (ee.Button == System.Windows.Forms.MouseButtons.Left) { firstPoint = Control.MousePosition; }
            };
            pictureBox4.MouseMove += (ss, ee) =>
            {
                if (ee.Button == System.Windows.Forms.MouseButtons.Left)
                {
                    Point temp = Control.MousePosition;
                    Point res = new Point(firstPoint.X - temp.X, firstPoint.Y - temp.Y);

                    pictureBox4.Location = new Point(pictureBox4.Location.X - res.X, pictureBox4.Location.Y - res.Y);

                    firstPoint = temp;
                }

                //Taşın yerine oturması için
                if (pictureBox4.Location.X >= 210 && pictureBox4.Location.X <= 240 && pictureBox4.Location.Y >= 195 && pictureBox4.Location.Y <= 250)
                {
                    pictureBox4.Location = new Point(229, 234);
                    sayac++;
                }
            };

            //Taşın sürüklenebilir olması
            pictureBox5.MouseDown += (ss, ee) =>
            {
                if (ee.Button == System.Windows.Forms.MouseButtons.Left) { firstPoint = Control.MousePosition; }
            };
            pictureBox5.MouseMove += (ss, ee) =>
            {
                if (ee.Button == System.Windows.Forms.MouseButtons.Left)
                {
                    Point temp = Control.MousePosition;
                    Point res = new Point(firstPoint.X - temp.X, firstPoint.Y - temp.Y);

                    pictureBox5.Location = new Point(pictureBox5.Location.X - res.X, pictureBox5.Location.Y - res.Y);

                    firstPoint = temp;
                }

                //Taşın yerine oturması için
                if (pictureBox5.Location.X >= 365 && pictureBox5.Location.X <= 595 && pictureBox5.Location.Y >= 290 && pictureBox5.Location.Y <= 370)
                {
                    pictureBox5.Location = new Point(576, 334);
                    sayac++;
                }
            };

            //Taşların sürüklenebilir olması için
            pictureBox6.MouseDown += (ss, ee) =>
            {
                if (ee.Button == System.Windows.Forms.MouseButtons.Left) { firstPoint = Control.MousePosition; }
            };
            pictureBox6.MouseMove += (ss, ee) =>
            {
                if (ee.Button == System.Windows.Forms.MouseButtons.Left)
                {
                    Point temp = Control.MousePosition;
                    Point res = new Point(firstPoint.X - temp.X, firstPoint.Y - temp.Y);

                    pictureBox6.Location = new Point(pictureBox6.Location.X - res.X, pictureBox6.Location.Y - res.Y);

                    firstPoint = temp;
                }

                //Taşın yerine oturması için
                if (pictureBox6.Location.X >= 325 && pictureBox6.Location.X <= 365 && pictureBox6.Location.Y >= 355 && pictureBox6.Location.Y <= 405)
                {
                    pictureBox6.Location = new Point(353, 386);
                    sayac++;
                }
            };

            //Taşların sürüklenebilmesi için
            pictureBox7.MouseDown += (ss, ee) =>
            {
                if (ee.Button == System.Windows.Forms.MouseButtons.Left) { firstPoint = Control.MousePosition; }
            };
            pictureBox7.MouseMove += (ss, ee) =>
            {
                if (ee.Button == System.Windows.Forms.MouseButtons.Left)
                {
                    Point temp = Control.MousePosition;
                    Point res = new Point(firstPoint.X - temp.X, firstPoint.Y - temp.Y);

                    pictureBox7.Location = new Point(pictureBox7.Location.X - res.X, pictureBox7.Location.Y - res.Y);

                    firstPoint = temp;
                }
                
                //Taşın yerine oturması için
                if (pictureBox7.Location.X >= 615 && pictureBox7.Location.X <= 665 && pictureBox7.Location.Y >= 365 && pictureBox7.Location.Y <= 405)
                {
                    pictureBox7.Location = new Point(639, 387);
                    sayac++;
                }
            };

            //Taşın sürüklenmesi için
            pictureBox8.MouseDown += (ss, ee) =>
            {
                if (ee.Button == System.Windows.Forms.MouseButtons.Left) { firstPoint = Control.MousePosition; }
            };
            pictureBox8.MouseMove += (ss, ee) =>
            {
                if (ee.Button == System.Windows.Forms.MouseButtons.Left)
                {
                    Point temp = Control.MousePosition;
                    Point res = new Point(firstPoint.X - temp.X, firstPoint.Y - temp.Y);

                    pictureBox8.Location = new Point(pictureBox8.Location.X - res.X, pictureBox8.Location.Y - res.Y);

                    firstPoint = temp;
                }

                //Taşın yerine oturması için
                if (pictureBox8.Location.X >= 370 && pictureBox8.Location.X <= 515 && pictureBox8.Location.Y >= 350 && pictureBox8.Location.Y <= 405)
                {
                    pictureBox8.Location = new Point(499, 384);
                    sayac++;
                }
            };
        }

        private void btnBitir_Click(object sender, EventArgs e)
        {
            if(pictureBox2.Location.X == 236 && pictureBox3.Location.X == 374 && pictureBox4.Location.X == 229 && pictureBox5.Location.X == 576 && pictureBox6.Location.X == 353 && pictureBox7.Location.X == 639 && pictureBox8.Location.X == 499)
            {
                MessageBox.Show("Tebrikler Bölüm Bitti.");
                this.Hide();
            }
            else
            {
                MessageBox.Show("Yerine Oturmamış Taşlar Var.");
            }
        }
    }
}
