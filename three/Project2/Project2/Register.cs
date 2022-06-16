using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project2
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show(
                                     "Nombre: " + textBox1.Text + "\n" +
                                     "Apellido Paterno: " + textBox2.Text + "\n" +
                                     "Apellido Materno: " + textBox3.Text + "\n" +
                                     "Nombre de Usuario: " + textBox4.Text + "\n" +
                                     "Correo Electrónico: " + textBox5.Text + "\n" +
                                     "Contraseña: " + textBox6.Text + "\n" +
                                     "Modelo: " + comboBox1.Text + "\n" +
                                     "¿Son correctos?",
                                     "Confirmación",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                MessageBox.Show("¡Bienvenido!, " + textBox1.Text, "Completado");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Modelo Forerunner")
            {
                pictureBox1.Image = Properties.Resources.design_a;
            } else if (comboBox1.Text == "Modelo Covenant")
            {
                pictureBox1.Image = Properties.Resources.design_b;
            } else
            {
                pictureBox1.Image = Properties.Resources.design_c;
            }
        }
    }
}
