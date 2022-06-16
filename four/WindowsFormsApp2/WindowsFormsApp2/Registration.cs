using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Registration : Form
    {
        Resources.Validate validate = new Resources.Validate();

        static string gender;
        public Registration()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            register.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            output.Items.Add("Matricula: " + textBox1.Text);
            output.Items.Add("Nombre: " + textBox2.Text);
            output.Items.Add("A. Paterno: " + textBox3.Text);
            output.Items.Add("A. Materno: " + textBox4.Text);
            output.Items.Add("Correo: " + textBox5.Text);
            output.Items.Add("Genero: " + gender);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Hombre";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Mujer";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            output.Items.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            validate.number(e);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            validate.letter(e);
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            validate.letter(e);
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            validate.letter(e);
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            validate.letter(e);
        }
    }
}
