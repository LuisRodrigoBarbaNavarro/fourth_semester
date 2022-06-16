using System;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            Cuadrado cuadrado = new Cuadrado(4.0);
            Circulo circulo = new Circulo(6.0);
            
            Console.Write("Cuadrado: ");
            Console.Read();
            Console.Write("Área del Cuadrado: " + cuadrado.Area() + "\n");
            Console.Read();
            Console.Write("Dibujo del Cuadrado: ");
            cuadrado.Dibujar();
            Console.ReadLine();

            Console.Write("Circulo: ");
            Console.Read();
            Console.Write("Área del Circulo: " + circulo.Area() + "\n");
            Console.Read();
            Console.Write("Dibujo del Circulo: ");
            circulo.Dibujar();
            Console.Read();
        }
    }
}
