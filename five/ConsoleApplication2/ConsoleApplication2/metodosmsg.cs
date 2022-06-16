using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Metodosmsg
    {
        //**CLASE CON DOS MÉTODOS QUE MUESTRAN MENSAJES POR PANTALLA
        //**EL OBJETIVO ES CREAR HILOS UNO PARA CADA UNO DE LOS MÉTODOS
        //**Y EJECUTARLOS DE FORMA PARALELA, DE FORMA QUE PODAMOS VER CÓMO EL
        //**RESULTADO SE VAN INTERCALANDO LOS MENSAJES ESCRITOS POR CADA MÉTODO.

        //Creación de método 'Hilo1' donde se hará una sucesión de 1 en 1 hasta
        //que el valor de 'i' sea menor a 10.
        public void Hilo1()
        {
            //Ciclo 'For' que permitirá la sucesión, donde el parámetro 'i' 
            //se inicializa en 0 y se irá incrementando en 1 hasta que sea menor a 10.
            for (int i = 0; i < 10; i++)
            {
                //Impresión en consola del parámetro 'i', seguido nombre del hilo
                //que en ese instante se ejecuta.
                Console.WriteLine("[" + i + "]" + "EJECUTANDO H1");

                //Suspende el hilo actual 'th1' 
                //durante 1000 milisegundos.
                Thread.Sleep(1000);
            }
        }

        //Creación de método 'Hilo2' donde se hará una sucesión de 2 en 2 hasta
        //que el valor de 'i' sea menor a 10.
        public void Hilo2()
        {
            //Ciclo 'For' que permitirá la sucesión, donde el parámetro 'i' 
            //se inicializa en 0 y se irá incrementando en 2 hasta que sea menor a 10.
            for (int i = 0; i < 10; i = i + 2)
            {
                //Impresión en consola del parámetro 'i', seguido nombre del hilo
                //que en ese instante se ejecuta.
                Console.WriteLine("[" + i + "]" + "EJECUTANDO H2");

                //Suspende el hilo actual 'th2' 
                //durante 5000 milisegundos.
                Thread.Sleep(5000);
            }
        }
    }
}
