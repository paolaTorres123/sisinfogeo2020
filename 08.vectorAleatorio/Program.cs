using System;

namespace _08.vectorAleatorio
{
    class Program
    {
        static void Main(string[] args)
        {
            const int MAX=15;

            int[] A = new int [MAX];
            int[] B = new int [MAX];
            int[] C = new int [MAX];

            Random aleatorio = new Random();

            //Generar numeros aleatorio

            for (int i = 0; i < MAX; i++)
            {
                A[i] = aleatorio.Next(1,100);
                B[i] = aleatorio.Next(1,100);
                C[i] = A[i] + B[i];
                
            }
            imprimir(A);
            imprimir(B);
            imprimir(C);
        

            Console.WriteLine("Suma de dos vectores aleatorios con 15 elementos");
        }
        static void imprimir(int[] v){
            for(int i=0; i<v.Length; i++)
            {
                Console.Write($"{v[i]} ");
                
            }
            Console.WriteLine();


        }
    }
}
