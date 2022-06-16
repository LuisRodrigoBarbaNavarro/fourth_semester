using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class RacingTrack : Form
    {
        delegate void delegateFunction(PictureBox picture, int y, int velocity);
        public RacingTrack()
        {
            InitializeComponent();
            //this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
        }

        private void CarVector_Paint(object sender, PaintEventArgs e)
        {
            Pen p1 = new Pen(Color.LightBlue, 8);
            Pen p2 = new Pen(Color.LightSalmon, 8);
            Graphics p = CreateGraphics();

            //Recorrido del segundo modelo.
            p.DrawLine(p1, new Point(335,74), new Point(875, 74));
            p.DrawLine(p1, new Point(875, 70), new Point(875, 235));
            p.DrawLine(p1, new Point(871, 235), new Point(1258, 235));
            p.DrawLine(p1, new Point(1258, 231), new Point(1258, 392));
            p.DrawLine(p1, new Point(1262, 392), new Point(1006, 392));
            p.DrawLine(p1, new Point(1006, 388), new Point(1006, 566));
            p.DrawLine(p1, new Point(1010, 566), new Point(565, 566));
            p.DrawLine(p1, new Point(565, 570), new Point(565, 449));
            p.DrawLine(p1, new Point(569, 449), new Point(280, 449));
            p.DrawLine(p1, new Point(280, 445), new Point(280, 612));
            p.DrawLine(p1, new Point(284, 612), new Point(104, 612));
            p.DrawLine(p1, new Point(104, 616), new Point(104, 184));

            //Recorrido del segundo modelo.
            p.DrawLine(p2, new Point(335, 124), new Point(825, 124));
            p.DrawLine(p2, new Point(825, 120), new Point(825, 285));
            p.DrawLine(p2, new Point(821, 285), new Point(1208, 285));
            p.DrawLine(p2, new Point(1208, 281), new Point(1208, 346));
            p.DrawLine(p2, new Point(1208, 342), new Point(952, 342));
            p.DrawLine(p2, new Point(956, 342), new Point(956, 520));
            p.DrawLine(p2, new Point(956, 516), new Point(615, 516));
            p.DrawLine(p2, new Point(615, 520), new Point(615, 399));
            p.DrawLine(p2, new Point(619, 399), new Point(230, 399));
            p.DrawLine(p2, new Point(230, 395), new Point(230, 562));
            p.DrawLine(p2, new Point(234, 562), new Point(154, 562));
            p.DrawLine(p2, new Point(154, 566), new Point(154, 184));

        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            Thread[] threads = new Thread[2];

            for (int i = 0; i < threads.Length; i++)
            {
                threads[i] = new Thread(method);
                threads[i].Name = "H" + i;
                threads[i].Start();
            }
            button1.Enabled = true;
        }

        private void method()
        {
            delegateFunction d = new delegateFunction(move);

            if (Thread.CurrentThread.Name.Equals("H0"))
            {
                d.Invoke(model_a, model_a.Location.Y, 20);
                MessageBox.Show("Primer lugar: Gato A", "Posición", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (Thread.CurrentThread.Name.Equals("H1"))
            {
                d.Invoke(model_b, model_b.Location.Y, 40);
                MessageBox.Show("Segundo lugar: Gato B", "Posición", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void move(PictureBox picture, int y, int velocity)
        {
            
            if (Thread.CurrentThread.Name.Equals("H0"))
            {
                Image temp_image;
                int x;

                x = model_a.Location.X;
                for (int i = x; i <= 860; i++)
                {
                    picture.Location = new Point(i, y);
                    Thread.Sleep(velocity);
                }

                temp_image = model_a.Image;
                temp_image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                model_a.Image = temp_image;
                model_a.Size = new Size(model_a.Height, model_a.Width);

                x = model_a.Location.X;
                for (int i = model_a.Location.Y; i <= 225; i++)
                {
                    picture.Location = new Point(x, i);
                    Thread.Sleep(velocity);
                }

                temp_image = model_a.Image;
                temp_image.RotateFlip(RotateFlipType.Rotate270FlipNone);
                model_a.Image = temp_image;
                model_a.Size = new Size(model_a.Height, model_a.Width);

                x = model_a.Location.X;
                for (int i = x; i <= 1240; i++)
                {
                    picture.Location = new Point(i, model_a.Location.Y);
                    Thread.Sleep(velocity);
                }

                temp_image = model_a.Image;
                temp_image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                model_a.Image = temp_image;
                model_a.Size = new Size(model_a.Height, model_a.Width);

                x = model_a.Location.X;
                for (int i = model_a.Location.Y; i <= 382; i++)
                {
                    picture.Location = new Point(x, i);
                    Thread.Sleep(velocity);
                }

                temp_image = model_a.Image;
                temp_image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                model_a.Image = temp_image;
                model_a.Size = new Size(model_a.Height, model_a.Width);

                x = model_a.Location.X;
                for (int i = x; i >= 990; i--)
                {
                    picture.Location = new Point(i, model_a.Location.Y);
                    Thread.Sleep(velocity);
                }

                temp_image = model_a.Image;
                temp_image.RotateFlip(RotateFlipType.Rotate270FlipNone);
                model_a.Image = temp_image;
                model_a.Size = new Size(model_a.Height, model_a.Width);

                x = model_a.Location.X;
                for (int i = model_a.Location.Y; i <= 554; i++)
                {
                    picture.Location = new Point(x, i);
                    Thread.Sleep(velocity);
                }

                temp_image = model_a.Image;
                temp_image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                model_a.Image = temp_image;
                model_a.Size = new Size(model_a.Height, model_a.Width);

                x = model_a.Location.X;
                for (int i = x; i >= 555; i--)
                {
                    picture.Location = new Point(i, model_a.Location.Y);
                    Thread.Sleep(velocity);
                }

                temp_image = model_a.Image;
                temp_image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                model_a.Image = temp_image;
                model_a.Size = new Size(model_a.Height, model_a.Width);

                x = model_a.Location.X;
                for (int i = model_a.Location.Y; i >= 429; i--)
                {
                    picture.Location = new Point(x, i);
                    Thread.Sleep(velocity);
                }

                temp_image = model_a.Image;
                temp_image.RotateFlip(RotateFlipType.Rotate270FlipNone);
                model_a.Image = temp_image;
                model_a.Size = new Size(model_a.Height, model_a.Width);

                x = model_a.Location.X;
                for (int i = x; i >= 265; i--)
                {
                    picture.Location = new Point(i, model_a.Location.Y);
                    Thread.Sleep(velocity);
                }

                temp_image = model_a.Image;
                temp_image.RotateFlip(RotateFlipType.Rotate270FlipNone);
                model_a.Image = temp_image;
                model_a.Size = new Size(model_a.Height, model_a.Width);

                x = model_a.Location.X;
                for (int i = model_a.Location.Y; i <= 590; i++)
                {
                    picture.Location = new Point(x, i);
                    Thread.Sleep(velocity);
                }

                temp_image = model_a.Image;
                temp_image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                model_a.Image = temp_image;
                model_a.Size = new Size(model_a.Height, model_a.Width);

                x = model_a.Location.X;
                for (int i = x; i >= 86; i--)
                {
                    picture.Location = new Point(i, model_a.Location.Y);
                    Thread.Sleep(velocity);
                }

                temp_image = model_a.Image;
                temp_image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                model_a.Image = temp_image;
                model_a.Size = new Size(model_a.Height, model_a.Width);

                x = model_a.Location.X;
                for (int i = model_a.Location.Y; i >= 184; i--)
                {
                    picture.Location = new Point(x, i);
                    Thread.Sleep(velocity);
                }
            }
            else if (Thread.CurrentThread.Name.Equals("H1"))
            {
                Image temp_image;
                int x;

                x = model_b.Location.X;
                for (int i = x; i <= 810; i++)
                {
                    picture.Location = new Point(i, y);
                    Thread.Sleep(velocity);
                }

                temp_image = model_b.Image;
                temp_image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                model_b.Image = temp_image;
                model_b.Size = new Size(model_b.Height, model_b.Width);

                x = model_b.Location.X;
                for (int i = model_b.Location.Y; i <= 275; i++)
                {
                    picture.Location = new Point(x, i);
                    Thread.Sleep(velocity);
                }

                temp_image = model_b.Image;
                temp_image.RotateFlip(RotateFlipType.Rotate270FlipNone);
                model_b.Image = temp_image;
                model_b.Size = new Size(model_b.Height, model_b.Width);

                x = model_b.Location.X;
                for (int i = x; i <= 1190; i++)
                {
                    picture.Location = new Point(i, model_b.Location.Y);
                    Thread.Sleep(velocity);
                }

                temp_image = model_b.Image;
                temp_image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                model_b.Image = temp_image;
                model_b.Size = new Size(model_b.Height, model_b.Width);

                x = model_b.Location.X;
                for (int i = model_b.Location.Y; i <= 332; i++)
                {
                    picture.Location = new Point(x, i);
                    Thread.Sleep(velocity);
                }

                temp_image = model_b.Image;
                temp_image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                model_b.Image = temp_image;
                model_b.Size = new Size(model_b.Height, model_b.Width);

                x = model_b.Location.X;
                for (int i = x; i >= 940; i--)
                {
                    picture.Location = new Point(i, model_b.Location.Y);
                    Thread.Sleep(velocity);
                }

                temp_image = model_b.Image;
                temp_image.RotateFlip(RotateFlipType.Rotate270FlipNone);
                model_b.Image = temp_image;
                model_b.Size = new Size(model_b.Height, model_b.Width);

                x = model_b.Location.X;
                for (int i = model_b.Location.Y; i <= 504; i++)
                {
                    picture.Location = new Point(x, i);
                    Thread.Sleep(velocity);
                }

                temp_image = model_b.Image;
                temp_image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                model_b.Image = temp_image;
                model_b.Size = new Size(model_b.Height, model_b.Width);

                x = model_b.Location.X;
                for (int i = x; i >= 605; i--)
                {
                    picture.Location = new Point(i, model_b.Location.Y);
                    Thread.Sleep(velocity);
                }

                temp_image = model_b.Image;
                temp_image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                model_b.Image = temp_image;
                model_b.Size = new Size(model_b.Height, model_b.Width);

                x = model_b.Location.X;
                for (int i = model_b.Location.Y; i >= 379; i--)
                {
                    picture.Location = new Point(x, i);
                    Thread.Sleep(velocity);
                }

                temp_image = model_b.Image;
                temp_image.RotateFlip(RotateFlipType.Rotate270FlipNone);
                model_b.Image = temp_image;
                model_b.Size = new Size(model_b.Height, model_b.Width);

                x = model_b.Location.X;
                for (int i = x; i >= 215; i--)
                {
                    picture.Location = new Point(i, model_b.Location.Y);
                    Thread.Sleep(velocity);
                }

                temp_image = model_b.Image;
                temp_image.RotateFlip(RotateFlipType.Rotate270FlipNone);
                model_b.Image = temp_image;
                model_b.Size = new Size(model_b.Height, model_b.Width);

                x = model_b.Location.X;
                for (int i = model_b.Location.Y; i <= 540; i++)
                {
                    picture.Location = new Point(x, i);
                    Thread.Sleep(velocity);
                }

                temp_image = model_b.Image;
                temp_image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                model_b.Image = temp_image;
                model_b.Size = new Size(model_b.Height, model_b.Width);

                x = model_b.Location.X;
                for (int i = x; i >= 136; i--)
                {
                    picture.Location = new Point(i, model_b.Location.Y);
                    Thread.Sleep(velocity);
                }

                temp_image = model_b.Image;
                temp_image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                model_b.Image = temp_image;
                model_b.Size = new Size(model_b.Height, model_b.Width);

                x = model_b.Location.X;
                for (int i = model_b.Location.Y; i >= 184; i--)
                {
                    picture.Location = new Point(x, i);
                    Thread.Sleep(velocity);
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
