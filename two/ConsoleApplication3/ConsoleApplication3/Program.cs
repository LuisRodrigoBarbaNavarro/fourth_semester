using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            Empleado em = new Empleado("Luis", 5000.00);
            Manager m1 = new Manager("Rodrigo", 15000.00);
            Console.WriteLine("Los datos recopilados son: \n" + em.ObtenerDetalles() + "\n" + m1.ObtenerDetalles());
            Console.ReadLine();
        }
    }
}
