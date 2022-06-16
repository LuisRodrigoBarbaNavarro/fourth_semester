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

namespace WindowsFormsApp5
{
    public partial class SalesReport : Form
    {
        Validate validate = new Validate();
        public SalesReport()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row.CreateCells(dataGridView1);

            row.Cells[0].Value = textBox1.Text;
            row.Cells[1].Value = textBox2.Text;
            row.Cells[2].Value = textBox3.Text;
            row.Cells[3].Value = textBox4.Text;
            row.Cells[4].Value = textBox5.Text;
            row.Cells[5].Value = dateTimePicker1.Text;

            dataGridView1.Rows.Add(row);

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            chart1.Series["Precio"].Points.Clear();
            chart2.Series["Volumen"].Points.Clear();

            try
            {
                for (int i = 0; i <= dataGridView1.Rows.Count; i++)
                {
                    String temp_date = dataGridView1.Rows[i].Cells[5].Value.ToString();
                    int temp_price = int.Parse(dataGridView1.Rows[i].Cells[4].Value.ToString());
                    int temp_volume = int.Parse(dataGridView1.Rows[i].Cells[3].Value.ToString());

                    chart1.Series["Precio"].Points.AddXY(temp_date, temp_price);
                    chart2.Series["Volumen"].Points.AddXY(temp_date, temp_volume);
                }
            }
            catch (Exception)
            {
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            validate.number(e);
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            validate.letter(e);
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            validate.number(e);
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            validate.number(e);
        }
    }
}
