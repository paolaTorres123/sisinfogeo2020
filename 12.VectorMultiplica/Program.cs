using System;

namespace _12.VectorMultiplica
{
    class Program
    {
        static void Main(string[] args)
        {
            Random aleatorio = new Random();
            int productoEscalar = 0,n;
            Console.WriteLine("Ingrese el valor de n: ");
            n = int.Parse(Console.ReadLine());
            string concatenada=" ";
            string concatenada2="";

            int [] v = new int[n];
            int [] m = new int[n];

            for (int i = 0; i < n; i++)
            {
                v[i] = (int) (aleatorio.Next(1,99));   
                m[i] = (int) (aleatorio.Next(1,99));   
            }
            for (int i = 0; i < n; i++)
            {
                concatenada += " "+ v[i]+" ";  
            }
            Console.WriteLine($"Los valores para el primer vector son : {concatenada}");

            for (int i = 0; i < n; i++)
            {
                concatenada2 += " "+ m[i]+" ";
            }
            Console.WriteLine($"Los valores para el primer vector son : {concatenada2}");

            for (int i = 0; i < n; i++)
            {
                productoEscalar = productoEscalar + v[i]*m[i];

            }
            Console.WriteLine($"\n El productor escalar entre los dos vectores es de: {productoEscalar}");
            Console.ReadKey();
        }
    }
}
