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
    public partial class frmZ3 : Form
    {
        public frmZ3()
        {
            InitializeComponent();
            INIT();
        }

        private Point firstPoint = new Point();
        public void INIT()
        {

            //Taşın sürüklenebilir olması için
            pictureBox1.MouseDown += (ss, ee) =>
            {
                if (ee.Button == System.Windows.Forms.MouseButtons.Left) { firstPoint = Control.MousePosition; }
            };
            pictureBox1.MouseMove += (ss, ee) =>
            {
                if (ee.Button == System.Windows.Forms.MouseButtons.Left)
                {
                    Point temp = Control.MousePosition;
                    Point res = new Point(firstPoint.X - temp.X, firstPoint.Y - temp.Y);

                    pictureBox1.Location = new Point(pictureBox1.Location.X - res.X, pictureBox1.Location.Y - res.Y);

                    firstPoint = temp;
                }


                //Taşın yerine oturması için
                if (pictureBox1.Location.X >= 300 && pictureBox1.Location.X <= 425 && pictureBox1.Location.Y >= 190 && pictureBox1.Location.Y <= 245)
                {
                    pictureBox1.Location = new Point(360, 215);
                }

            };

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
                if (pictureBox2.Location.X >= 200 && pictureBox2.Location.X <= 315 && pictureBox2.Location.Y >= 70 && pictureBox2.Location.Y <= 160)
                {
                    pictureBox2.Location = new Point(259, 117);
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
                if (pictureBox3.Location.X >= 320 && pictureBox3.Location.X <= 350 && pictureBox3.Location.Y >= 425 && pictureBox3.Location.Y <= 460)
                {
                    pictureBox3.Location = new Point(329, 446);
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
                if (pictureBox4.Location.X >= 540 && pictureBox4.Location.X <= 570 && pictureBox4.Location.Y >= 355 && pictureBox4.Location.Y <= 425)
                {
                    pictureBox4.Location = new Point(551, 385);
                }

            };

            //Taşın sürüklenebilir olması için
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
                if (pictureBox5.Location.X >= 525 && pictureBox5.Location.X <= 560 && pictureBox5.Location.Y >= 50 && pictureBox5.Location.Y <= 100)
                {
                    pictureBox5.Location = new Point(544, 78);
                }

            };

            //Taşın sürüklenebilir olması için
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
                if (pictureBox6.Location.X >= 550 && pictureBox6.Location.X <= 590 && pictureBox6.Location.Y >= 50 && pictureBox6.Location.Y <= 100)
                {
                    pictureBox6.Location = new Point(568, 80);
                }

            };

            //Taşın sürüklenebilir olması için
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
                if (pictureBox7.Location.X >= 420 && pictureBox7.Location.X <= 465 && pictureBox7.Location.Y >= 300 && pictureBox7.Location.Y <= 350)
                {
                    pictureBox7.Location = new Point(438, 328);
                }

            };
        }

        private void btnBitir_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Location.X == 360 && pictureBox2.Location.X == 259 && pictureBox3.Location.X == 329 && pictureBox4.Location.X == 551 && pictureBox5.Location.X == 544 && pictureBox6.Location.X == 568 && pictureBox7.Location.X == 438)
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
