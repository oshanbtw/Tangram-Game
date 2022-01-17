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
    public partial class frmO3 : Form
    {
        public frmO3()
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
                if (pictureBox1.Location.X >= 440 && pictureBox1.Location.X <= 505 && pictureBox1.Location.Y >= 150 && pictureBox1.Location.Y <= 208)
                {
                    pictureBox1.Location = new Point(477, 182);
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
                if (pictureBox2.Location.X >= 400 && pictureBox2.Location.X <= 460 && pictureBox2.Location.Y >= 223 && pictureBox2.Location.Y <= 305)
                {
                    pictureBox2.Location = new Point(415, 258);
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
                if (pictureBox3.Location.X >= 560 && pictureBox3.Location.X <= 600 && pictureBox3.Location.Y >= 10 && pictureBox3.Location.Y <= 80)
                {
                    pictureBox3.Location = new Point(577, 42);
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
                if (pictureBox4.Location.X >= 630 && pictureBox4.Location.X <= 665 && pictureBox4.Location.Y >= 290 && pictureBox4.Location.Y <= 350)
                {
                    pictureBox4.Location = new Point(647, 322);
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
                if (pictureBox5.Location.X >= 570 && pictureBox5.Location.X <= 590 && pictureBox5.Location.Y >= 455 && pictureBox5.Location.Y <= 505)
                {
                    pictureBox5.Location = new Point(577, 473);
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
                if (pictureBox6.Location.X >= 290 && pictureBox6.Location.X <= 318 && pictureBox6.Location.Y >= 450 && pictureBox6.Location.Y <= 468)
                {
                    pictureBox6.Location = new Point(301, 461);
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
                if (pictureBox7.Location.X >= 333 && pictureBox7.Location.X <= 371 && pictureBox7.Location.Y >= 165 && pictureBox7.Location.Y <= 199)
                {
                    pictureBox7.Location = new Point(358, 183);
                }

            };
        }

        private void btnBitir_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Location.X == 477 && pictureBox2.Location.X == 415 && pictureBox3.Location.X == 577 && pictureBox4.Location.X == 647 && pictureBox5.Location.X == 577 && pictureBox6.Location.X == 301 && pictureBox7.Location.X == 358)
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
