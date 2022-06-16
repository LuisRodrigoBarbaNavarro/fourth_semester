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

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void process()
        {
            Thread.Sleep(8000);
            MessageBox.Show("Terminación del proceso.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ThreadStart t = new ThreadStart(process);

            Thread thread_1 = new Thread(t);

            thread_1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Soy un botón prueba.");
        }
    }
}
