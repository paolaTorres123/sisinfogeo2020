using System;

namespace p31.Delegado
{
    public delegate void MiDelegado(string msj);

    class Program
    {
        static void Main(string[] args)
        {
            MiDelegado d;//Instancia de delegado
            Console.Clear();
            
            //Delegado invoca al metodo Mensaje de la clase Mnesajes
            d = Mensajes.Mensaje1;
            d("Jose");

            //Delegado invoca al metodo2 de la calse Mensajes
            d = Mensajes.Mensaje2;
            d("Juan");

            //Delegado invoca a una expresion lambada
            d = (string msj) => Console.WriteLine($"{msj} - paga todo que no para la fiesta");
            d("Carlos");
            Console.WriteLine();
        }
    }
    public class Mensajes
    {
        public static void Mensaje1(string msj)
        {
            Console.WriteLine($"{msj} - lleva el pastel");
        }
        public static void Mensaje2(string msj)
        {
            Console.WriteLine($"{msj} - fue el culpable se cancela la fiesta");
        }
    }
}
