using System;
using System.Threading;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread thread = new Thread(new ThreadStart(Methilos));
            thread.Start();

            for (int i = 1; i <= 10; i++)
                Console.Write(i + "\t");
            Console.Write("\n");
            Console.Write("\n");
            Console.Read();
        }

        static void Methilos()
        {
            for (int i = 5; i <= 50; i += 5)
                Console.Write(i + "\t");
        }
    }
}
