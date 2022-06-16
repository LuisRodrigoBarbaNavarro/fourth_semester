using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            //**Ejecución de hilos con método 'Join()'.

            //Creación del objeto de instancia de la clase 'metodosmsg'.
            Metodosmsg ms = new Metodosmsg();

            //Creación del objeto 'Thread', pasando el método 'ms.Hilo1'.
            Thread th1 = new Thread(ms.Hilo1);

            //Creación del objeto 'Thread', pasando el método 'ms.Hilo2'.
            Thread th2 = new Thread(ms.Hilo2);

            //Empieza el hilo denominado 'th1'.
            th1.Start();

            //Espera el hilo principal hasta que el hilo 'th1' termine su ejecución.
            //Una vez concluido el hilo 'th1', se procede al inicio del hilo 'th2'.
            th1.Join();

            //Empieza el hilo denominado 'th2'.
            th2.Start();

            //Espera el hilo principal hasta que el hilo 'th2' termine su ejecución.
            //Una vez concluido el hilo 'th2', se procede al Console.Readkey(). 
            th2.Join();

            //**OBSERVACIÓN:
            //El resultado será que se mostrarán primero los mensajes
            //del método 'Hilo1' del hilo 'th1', hasta que complete su
            //ejecución, se mostrarán los mensajes del método 'Hilo2'
            //del hilo 'th2'; esto pasa debido a que al inicio, el hilo
            //principal espera que el hilo 'th1' termine su ejecución para
            //posterirmente liberarlo y pasar al hilo 'th2'; evitando así
            //la ejecución paralela.

            //El método ReadKey() hace que el programa 
            //espere a que se presione una tecla e impide 
            //la pantalla hasta que se presiona una tecla.
            Console.ReadKey();

            //**NOTA: EL MÉTODO JOIN PERMITE A UN HILO QUEDARSE A LA ESPERA QUE TERMINE UN SEGUNDO HILO.
        }
    }
}
