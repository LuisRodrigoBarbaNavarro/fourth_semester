using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApplication4
{
    public class Cuadrado : Figura
    {
        private double lado;

        public Cuadrado(double l)
        {
            this.lado = l;
        }

        public override double Area()
        {
            return Math.Pow(lado, 2);
        }

        public override void Dibujar()
        {
            Console.WriteLine(@"
             __________
            |          |
            |          |
            |          |
            |__________|
            ");
        }
    }
}