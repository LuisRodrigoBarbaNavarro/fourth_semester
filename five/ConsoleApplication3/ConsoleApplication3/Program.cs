using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            //**Ejecución de hilos con método 'Join()'.

            //Creación del objeto de instancia de la clase 'ThreadProcess'.
            ThreadProcess tp = new ThreadProcess();

            //Creación del objeto de tipo 'Thread', pasando el método 'tp.ThreadCode_1'.
            Thread thread_1 = new Thread(tp.ThreadCode_1);
            //Creación del objeto de tipo 'Thread', pasando el método 'tp.ThreadCode_2'.
            Thread thread_2 = new Thread(tp.ThreadCode_2);
            //Creación del objeto de tipo 'Thread', pasando el método 'tp.ThreadCode_3'.
            Thread thread_3 = new Thread(tp.ThreadCode_3);

            Console.WriteLine("Ejecución - Threads:");
            Console.WriteLine("Inicio de ejecución del hilo principal. \n");

            //Empieza el hilo denominado 'thread_1'.
            thread_1.Start();
            //Se espera el hilo principal hasta que el hilo 'thread_1' termine su ejecución.
            //Concluida su ejecución, se procede al inicio del hilo 'thread_2'.
            thread_1.Join();

            //Empieza el hilo denominado 'thread_2'.
            thread_2.Start();
            //Se espera el hilo principal hasta que el hilo 'thread_2' termine su ejecución.
            //Concluida su ejecución, se procede al inicio del hilo 'thread_3'.
            thread_2.Join();

            //Empieza el hilo denominado 'thread_3'.
            thread_3.Start();
            //Se espera el hilo principal hasta que el hilo 'thread_3' termine su ejecución.
            //Concluida su ejecución, se procede a la siguiente instrucción.
            thread_3.Join();

            Console.WriteLine("Terminación de ejecución del hilo principal.");

            /*
             * CONCLUSIÓN:
             *  Los resultados generados por los hilos no se intercalan debido a que utilizamos,
             *  el método 'Join()' que nos permite bloquear temporalmente el proceso de
             *  llamada hasta que se termine el hilo representado por su instancia.
             */

            //Método 'ReadKey()' hace que el programa espere a que se presione
            //alguna de las teclas.
            Console.ReadKey();
        }
    }
}
