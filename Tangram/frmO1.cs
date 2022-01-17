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
    public partial class frmO1 : Form
    {
        public frmO1()
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
                if (pictureBox1.Location.X >= 470 && pictureBox1.Location.X <= 550 && pictureBox1.Location.Y >= 185 && pictureBox1.Location.Y <= 245)
                {
                    pictureBox1.Location = new Point(500, 223);
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
                if (pictureBox2.Location.X >= 240 && pictureBox2.Location.X <= 368 && pictureBox2.Location.Y >= 185 && pictureBox2.Location.Y <= 245)
                {
                    pictureBox2.Location = new Point(289, 226);
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
                if (pictureBox3.Location.X >= 535 && pictureBox3.Location.X <= 575 && pictureBox3.Location.Y >= 85 && pictureBox3.Location.Y <= 135)
                {
                    pictureBox3.Location = new Point(550, 114);
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
                if (pictureBox4.Location.X >= 270 && pictureBox4.Location.X <= 310 && pictureBox4.Location.Y >= 100 && pictureBox4.Location.Y <= 155)
                {
                    pictureBox4.Location = new Point(287, 126 );
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
                if (pictureBox5.Location.X >= 640 && pictureBox5.Location.X <= 670 && pictureBox5.Location.Y >= 235  && pictureBox5.Location.Y <= 265)
                {
                    pictureBox5.Location = new Point(650, 248);
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
                if (pictureBox6.Location.X >= 395 && pictureBox6.Location.X <= 420 && pictureBox6.Location.Y >= 375 && pictureBox6.Location.Y <= 395)
                {
                    pictureBox6.Location = new Point(405, 388);
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
                if (pictureBox7.Location.X >= 225 && pictureBox7.Location.X <= 255 && pictureBox7.Location.Y >= 70 && pictureBox7.Location.Y <= 90)
                {
                    pictureBox7.Location = new Point(239, 78);
                }

            };
        }

        private void btnBitir_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Location.X == 500 && pictureBox2.Location.X == 289 && pictureBox3.Location.X == 550 && pictureBox4.Location.X == 287 && pictureBox5.Location.X == 650 && pictureBox6.Location.X == 405 && pictureBox7.Location.X == 239)
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

