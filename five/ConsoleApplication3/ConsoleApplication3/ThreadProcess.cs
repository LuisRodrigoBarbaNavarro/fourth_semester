using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class ThreadProcess
    {
        //**Código que se implementará en los hilos creados.

        /*
         * Creación del método 'ThreadCode_1' que imprime las letras del
         * abecedario desde la A hasta la H.
         */
        public void ThreadCode_1()
        {
            //Creación de objeto tipo 'StopWatch' que nos permite crear un cronómetro
            //para medir con précisión el tiempo transcurrido durante la ejecución del hilo.
            Stopwatch stopWatch = new Stopwatch();
           
            //Inicio del cronómetraje.
            stopWatch.Start();

            //Creación de 'Array' que contiene nuestras letras.
            String [] letters = {"A", "B", "C", "D", "E", "F", "G", "H"};

            //Creación de 'Foreach' para mostrar nuestro 'Array' de letras.
            foreach (var item in letters)
            {
                //Creamos una variable temporal de tipo 'TimeSpan' para representar
                //el intervalo de tiempo concreto cuando se muestra cada letra.
                TimeSpan temp = stopWatch.Elapsed;

                //Impresión en consola del parámetro 'item', seguido del nombre del hilo, y
                //el tiempo transcurrido en ese instante, del hilo.
                Console.WriteLine("[Letra: " + item + "]" 
                                  + " Ejecutando: Hilo 1 -"
                                  + " Tiempo actual transcurrido: " + temp.ToString("ss\\.ff") + " segundos.");

                //Suspende el hilo actual 'thread_1' durante 1500 milisegundos.
                Thread.Sleep(1500);
            }
            //Fin del cronómetraje.
            stopWatch.Stop();

            //Creación de variable de tipo 'TimeSpan' que muestra el tiempo total
            //de terminación del hilo.
            TimeSpan ts = stopWatch.Elapsed;

            //Formateo del la variable 'ts' para que muestre solamente segundos y milisegundos.
            ts.ToString("ss\\.ff");

            //Impresión en consola de nombre del hilo, seguido del tiempo de terminación.
            Console.WriteLine("Hilo 1 - Tiempo de terminación: " + ts.ToString("ss\\.ff") + " segundos. \n");
        }

        /*
         * Creación del método 'ThreadCode_2' que imprime los números de 2 en 2;
         * empezando por el 2 y terminando por el 16.
         */
        public void ThreadCode_2()
        {
            //Creación de objeto tipo 'StopWatch' que nos permite crear un cronómetro
            //para medir con précisión el tiempo transcurrido durante la ejecución del hilo.
            Stopwatch stopWatch = new Stopwatch();

            //Inicio del cronómetraje.
            stopWatch.Start();

            //Creación de 'Array' que contiene nuestros números.
            int[] numbers = {2, 4, 6, 8, 10, 12, 14, 16};

            //Creación de 'Foreach' para mostrar nuestro 'Array' de números.
            foreach (var item in numbers)
            {
                //Creamos una variable temporal de tipo 'TimeSpan' para representar
                //el intervalo de tiempo concreto cuando se muestra cada número.
                TimeSpan temp = stopWatch.Elapsed;

                //Impresión en consola del parámetro 'item', seguido del nombre del hilo, y
                //el tiempo transcurrido en ese instante, del hilo.
                Console.WriteLine("[Número: " + item + "]"
                                  + " Ejecutando: Hilo 2 -"
                                  + " Tiempo actual transcurrido: " + temp.ToString("ss\\.ff") + " segundos.");

                //Suspende el hilo actual 'thread_1' durante 2000 milisegundos.
                Thread.Sleep(2000);
            }
            //Fin del cronómetraje.
            stopWatch.Stop();

            //Creación de variable de tipo 'TimeSpan' que muestra el tiempo total
            //de terminación del hilo.
            TimeSpan ts = stopWatch.Elapsed;

            //Formateo del la variable 'ts' para que muestre solamente segundos y milisegundos.
            ts.ToString("ss\\.ff");

            //Impresión en consola de nombre del hilo, seguido del tiempo de terminación.
            Console.WriteLine("Hilo 2 - Tiempo de terminación: " + ts.ToString("ss\\.ff") + " segundos. \n");
        }

        /*
         * Creación del método 'ThreadCode_3' que imprime la sucesión de Fibonacci
         * hasta la posición 14. 
         */
        public void ThreadCode_3()
        {
            //Creación de objeto tipo 'StopWatch' que nos permite crear un cronómetro
            //para medir con précisión el tiempo transcurrido durante la ejecución del hilo.
            Stopwatch stopWatch = new Stopwatch();

            //Inicio del cronómetraje.
            stopWatch.Start();

            //Creación de nuestras variables a utilizar en la sucesión Fibonacci.
            int a = 0, b = 1, c = 0;

            //Creación de 'For' para desplegar el valor de cada posición con respecto a la
            //sucesión Fibonacci.
            for (int i = 2; i < 15; i++)
            {
                //Creamos una variable temporal de tipo 'TimeSpan' para representar
                //el intervalo de tiempo concreto cuando se muestra cada número de la sucesión.
                TimeSpan temp = stopWatch.Elapsed;

                //La suma de los dos números anteriores se almacena en la variable 'c'.
                c = a + b;

                //Impresión en consola del parámetro 'c', seguido del nombre del hilo, y
                //el tiempo transcurrido en ese instante, del hilo.
                Console.WriteLine("[Fibonacci: " + c + "]"
                                  + " Ejecutando: Hilo 3 -"
                                  + " Tiempo actual transcurrido: " + temp.ToString("ss\\.ff") + " segundos.");
                Thread.Sleep(500);

                //Se recorren los valores anteriormente usados en la sucesión.
                a = b;
                b = c;
            }
            //Fin del cronómetraje.
            stopWatch.Stop();

            //Creación de variable de tipo 'TimeSpan' que muestra el tiempo total
            //de terminación del hilo.
            TimeSpan ts = stopWatch.Elapsed;

            //Formateo del la variable 'ts' para que muestre solamente segundos y milisegundos.
            ts.ToString("ss\\.ff");

            //Impresión en consola de nombre del hilo, seguido del tiempo de terminación.
            Console.WriteLine("Hilo 3 - Tiempo de terminación: " + ts.ToString("ss\\.ff") + " segundos. \n");
        }
    }
}
