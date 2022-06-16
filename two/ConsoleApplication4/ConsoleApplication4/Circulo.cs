using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApplication4
{
    public class Circulo : Figura
    {
        private double radio;
        public Circulo(double ra)
        {
            this.radio = ra;
        }
        public override void Dibujar()
        {
            Console.WriteLine(@"

                *  * 
             *        *
            *          *
            *          *
             *        *
                *  * 
            ");
        }
        public override double Area()
        {
            return Math.PI * Math.Pow(radio, 2);
        }
    }
}