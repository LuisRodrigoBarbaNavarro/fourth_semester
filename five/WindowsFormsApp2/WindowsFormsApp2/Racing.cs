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

namespace WindowsFormsApp2
{
    public partial class Racing : Form
    {
        delegate void delegateFunction(PictureBox pic, int y, int velocidad);
        public Racing()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
        }

        private void CarVector_Paint(object sender, PaintEventArgs e)
        {
            Pen p1 = new Pen(Color.Black, 8);
            Graphics p = CreateGraphics();

            p.DrawLine(p1, new Point(9,124), new Point(750, 124));
            p.DrawLine(p1, new Point(9, 251), new Point(750, 251));
            p.DrawLine(p1, new Point(9, 376), new Point(750, 376));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            Thread[] threads = new Thread[3];

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
                d.Invoke(model_a, model_a.Location.Y, 10);
                MessageBox.Show("Primer lugar: Modelo A", "Posición", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (Thread.CurrentThread.Name.Equals("H1"))
            {
                d.Invoke(model_b, model_b.Location.Y, 100);
                MessageBox.Show("Tercer lugar: Modelo B", "Posición", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (Thread.CurrentThread.Name.Equals("H2"))
            {
                d.Invoke(model_c, model_c.Location.Y, 20);
                MessageBox.Show("Segundo lugar: Modelo C", "Posición", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void move(PictureBox pic, int y, int velocity)
        {
            for (int i = 0; i < 600; i++)
            {
                pic.Location = new Point(i, y);

                if (Thread.CurrentThread.Name.Equals("H0"))
                {
                    Thread.Sleep(velocity);
                }
                else if (Thread.CurrentThread.Name.Equals("H1"))
                {
                    Thread.Sleep(velocity);
                }
                else if (Thread.CurrentThread.Name.Equals("H2"))
                {
                    Thread.Sleep(velocity);
                }
            }
        }
    }
}
