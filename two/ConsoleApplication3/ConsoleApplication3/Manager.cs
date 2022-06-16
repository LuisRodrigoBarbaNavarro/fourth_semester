using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication3
{
    public class Manager : Empleado
    {
        protected string departamento;

        public Manager(string nombre, double salario)
        {
            this.nombre = nombre;
            this.salario = salario;
        }
        public Manager(string fechaNacimiento, string departamento)
        {
            this.fechaNacimiento = fechaNacimiento;
            this.departamento = departamento;
        }
    }
}