using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace WindowsFormsApp3
{
    public partial class ChartApplication : Form
    {
        List<int> values = new List<int>();
        public ChartApplication()
        {
            InitializeComponent();
            trackBar.Value = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void trackBar_Scroll(object sender, EventArgs e)
        {
            label2.Text = trackBar.Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            values.Add(trackBar.Value);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.chart1.Palette = ChartColorPalette.Excel;
            for (int i = 0; i < values.Count; i++)
            {
                chart1.Series["SensorTemperatura"].Points.Add(values[i]);
            }
        }
    }
}
