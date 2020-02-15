using System;

namespace _11.VectorInverso
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nombres = {"Paola","Eduardo","Pedro","Alfonso","Leisy"};
            string cadena ="";
            string cadena2 ="";
            //Tamano del array
            int length =nombres.Length;
            //Vector original
            for (int i = 0; i < length; i++)
            {
                cadena+=nombres[i]+" ";
            }
            Console.WriteLine($"Vector original: {cadena}\n");
            
            //Vector invertido
            Array.Reverse(nombres);
            for (int i = 0; i < length; i++)
            {
                cadena2+=nombres[i]+" ";

            }
            Console.WriteLine($"Vector invertido: {cadena2}\n");
            Console.ReadKey();
        

            
        }
    }
}
