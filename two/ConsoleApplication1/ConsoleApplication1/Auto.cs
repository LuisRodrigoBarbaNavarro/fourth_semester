using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public class Auto
    {
        private string Marca;
        private string Modelo;
        private string Color;
        private int Serie;

        public void Frenar()
        {
            Console.Write("EL TOYOTA FRENA");
            Console.ReadKey();
        }

        public void Arrancar()
        {
            Console.Write("EL TOYOTA ARRANCA");
            Console.ReadKey();
        }
    }
}