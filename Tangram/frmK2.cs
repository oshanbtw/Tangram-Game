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
    public partial class frmK2 : Form
    {
        public frmK2()
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
                if (pictureBox1.Location.X >= 283 && pictureBox1.Location.X <= 313 && pictureBox1.Location.Y >= 277 && pictureBox1.Location.Y <= 358)
                {
                    pictureBox1.Location = new Point(296, 321);
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
                if (pictureBox2.Location.X >= 520 && pictureBox2.Location.X <= 571 && pictureBox2.Location.Y >= 277 && pictureBox2.Location.Y <= 358)
                {
                    pictureBox2.Location = new Point(555, 321);
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
                if (pictureBox3.Location.X >= 376 && pictureBox3.Location.X <= 394 && pictureBox3.Location.Y >= 458 && pictureBox3.Location.Y <= 495)
                {
                    pictureBox3.Location = new Point(386, 473);
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
                if (pictureBox4.Location.X >= 609 && pictureBox4.Location.X <= 642 && pictureBox4.Location.Y >= 92 && pictureBox4.Location.Y <= 130)
                {
                    pictureBox4.Location = new Point(624, 111);
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
                if (pictureBox5.Location.X >= 557 && pictureBox5.Location.X <= 606 && pictureBox5.Location.Y >= 430 && pictureBox5.Location.Y <= 464)
                {
                    pictureBox5.Location = new Point(580, 448);
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
                if (pictureBox6.Location.X >= 201 && pictureBox6.Location.X <= 226 && pictureBox6.Location.Y >= 150 && pictureBox6.Location.Y <= 189)
                {
                    pictureBox6.Location = new Point(206, 168);
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
                if (pictureBox7.Location.X >= 597 && pictureBox7.Location.X <= 659 && pictureBox7.Location.Y >= 201 && pictureBox7.Location.Y <= 235)
                {
                    pictureBox7.Location = new Point(621, 218);
                }

            };
        }

        private void btnBitir_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Location.X == 296 && pictureBox2.Location.X == 555 && pictureBox3.Location.X == 386 && pictureBox4.Location.X == 624 && pictureBox5.Location.X == 580 && pictureBox6.Location.X == 206 && pictureBox7.Location.X == 621)
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
