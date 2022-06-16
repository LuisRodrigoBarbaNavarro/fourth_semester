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
    public partial class Context : Form
    {
        public Context()
        {
            InitializeComponent();
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void salesReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SalesReport report_window = new SalesReport();
            report_window.Show();
        }

        private void debutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Project.Debut debut_window = new Project.Debut();
            debut_window.Show();
        }

        private void registerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Project2.Register register_window = new Project2.Register();
            register_window.Show();
        }

        private void tableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WindowsFormsApp4.GridViewApplication table_window = new WindowsFormsApp4.GridViewApplication();
            table_window.Show();
        }

        private void chartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WindowsFormsApp3.ChartApplication chart_window = new WindowsFormsApp3.ChartApplication();
            chart_window.Show();
        }

        private void customizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Customize customize_window = new Customize();
            customize_window.Show();
        }
    }
}
