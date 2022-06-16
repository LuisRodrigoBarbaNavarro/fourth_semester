using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class GridViewApplication : Form
    {
        public GridViewApplication()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row.CreateCells(dataGridView1);

            row.Cells[0].Value = textBox1.Text;
            row.Cells[1].Value = textBox2.Text;
            row.Cells[2].Value = textBox3.Text;
            row.Cells[3].Value = textBox4.Text;
            row.Cells[4].Value = textBox5.Text;
            row.Cells[5].Value = textBox6.Text;
            row.Cells[6].Value = textBox7.Text;

            dataGridView1.Rows.Add(row);

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
        }
    }
}
