using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication3
{
    public class Empleado
    {
        protected string fechaNacimiento;
        protected string nombre;
        protected double salario;

        public Empleado(string nombre, double salario)
        {
            this.nombre = nombre;
            this.salario = salario;
        }

        public Empleado()
        {
        }

        public string ObtenerDetalles()
        {
            return "Nombre: " + nombre + "\n" + "Salario: " + salario;
        }
    }
}