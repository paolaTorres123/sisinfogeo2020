using System;

namespace p32.Delegado2
{
    public delegate void MiDelegado(string msj);
    class Program
    {
        static void Main(string[] args)
        {
            MiDelegado d1;
            MiDelegado d2;
            MiDelegado d3;

            MiDelegado d;

            Console.Clear();

            d1 = Delegados.Mensaje1;
            d2 = Delegados.Mensaje2;

            d = d1+d2;
            d("El peje");
            Console.WriteLine();

            d3 = (string msj) => Console.WriteLine($"{msj} - paga todo que no pare la fiesta");
            d += d3;
            d("El borolas");
            Console.WriteLine();

            d -= d2;
            d("Pena");
            Console.WriteLine();

            d -= d1;
            d("Tello");
            Console.WriteLine();


        }
    }
}
