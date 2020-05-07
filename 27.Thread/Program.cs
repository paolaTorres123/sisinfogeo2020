﻿using System;
using System.Threading;

namespace _27.Thread
{
    class Program
    {
        static void Main(string[] args)
        {
            //Nombramos al Thread principla
            Thread.CurrentThread.Name="Principal";

            //Creamos 2 threads
            Thread t1 = new Thread(Imprime);
            Thread t2 = new Thread(Imprime);

            //Damos nombre a los threads que creamos
            t1.Name="Thread1";
            t2.Name="Thread2";

            //Invocamos los threads
            t1.Start();
            t2.Start();

            //Invocamos Imprime desde Thread principal
            Imprime();

            Console.WriteLine("Saludos desde Main, se ha terminado todo");
        }
        static void Imprime()
        {
            for (int i=0; i<10; i++)
            {
                Console.WriteLine($"Imprime . {i} desde {Thread.CurrentThread.Name}");
                Thread.Sleep(100);
            }
        }
    }
}
