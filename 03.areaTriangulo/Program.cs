using System;

namespace _03.areaTriangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            float base1,altura1,area1;
            Console.WriteLine("Programa que calcula el area de un triangulo");

            Console.WriteLine("Dame la base");
            base1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Dame la altura");
            altura1 = float.Parse(Console.ReadLine());

            area1 = (base1 * altura1) /2;

            Console.WriteLine($"El area es{area1}");

            Console.ReadLine();

        }
    }
}
