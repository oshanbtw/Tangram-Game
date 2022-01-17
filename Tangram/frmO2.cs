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
    public partial class frmO2 : Form
    {
        public frmO2()
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
                if (pictureBox1.Location.X >= 439 && pictureBox1.Location.X <= 439 && pictureBox1.Location.Y >= 285 && pictureBox1.Location.Y <= 345)
                {
                    pictureBox1.Location = new Point(455, 309);
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
                if (pictureBox2.Location.X >= 326 && pictureBox2.Location.X <= 398 && pictureBox2.Location.Y >= 285 && pictureBox2.Location.Y <= 345)
                {
                    pictureBox2.Location = new Point(378, 309);
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
                if (pictureBox3.Location.X >= 342 && pictureBox3.Location.X <= 423 && pictureBox3.Location.Y >= 142 && pictureBox3.Location.Y <= 197)
                {
                    pictureBox3.Location = new Point(367, 159);
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
                if (pictureBox4.Location.X >= 340 && pictureBox4.Location.X <= 390 && pictureBox4.Location.Y >= 60 && pictureBox4.Location.Y <= 100)
                {
                    pictureBox4.Location = new Point(361, 89);
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
                if (pictureBox5.Location.X >= 340 && pictureBox5.Location.X <= 377 && pictureBox5.Location.Y >= 0 && pictureBox5.Location.Y <= 69)
                {
                    pictureBox5.Location = new Point(361, 22);
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
                if (pictureBox6.Location.X >= 419 && pictureBox6.Location.X <= 454 && pictureBox6.Location.Y >= 0 && pictureBox6.Location.Y <= 69)
                {
                    pictureBox6.Location = new Point(439, 26);
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
                if (pictureBox7.Location.X >= 638 && pictureBox7.Location.X <= 704 && pictureBox7.Location.Y >= 463 && pictureBox7.Location.Y <= 486)
                {
                    pictureBox7.Location = new Point(663, 474);
                }

            };
        }

        private void btnBitir_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Location.X == 455 && pictureBox2.Location.X == 378 && pictureBox3.Location.X == 367 && pictureBox4.Location.X == 361 && pictureBox5.Location.X == 361 && pictureBox6.Location.X == 439 && pictureBox7.Location.X == 663)
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
