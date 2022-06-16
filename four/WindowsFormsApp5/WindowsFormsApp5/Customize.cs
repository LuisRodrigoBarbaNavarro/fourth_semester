using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Customize : Form
    {
        private int red;
        private int green;
        private int blue;

        public Customize()
        {
            InitializeComponent();
        }

        private void applySettings()
        {
            panel1.BackColor = Color.FromArgb(red, green, blue);
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            red = Convert.ToInt32(trackBar1.Value * 2.55);
            applySettings();
        }

        private void trackBar2_ValueChanged(object sender, EventArgs e)
        {
            green = Convert.ToInt32(trackBar2.Value * 2.55);
            applySettings();
        }

        private void trackBar3_ValueChanged(object sender, EventArgs e)
        {
            blue = Convert.ToInt32(trackBar3.Value * 2.55);
            applySettings();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.model_a;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.model_b;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.model_c;
        }
    }
}
