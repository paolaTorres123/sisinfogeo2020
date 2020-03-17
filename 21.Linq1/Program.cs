using System;
using System.Linq;
using System.Collections.Generic;


namespace _21.Linq1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Fuente de datos
            int [] numeros = new int[]{
            
                10,20,30,40,50,60,70,80,90,100,
                -10,-20,0,1000,2000,3000,4000,5000,
                10,20,30,40,50,60,70,80,90,101,
                -10,-20,0,1000,2000,3000,4000,5000,
            };
            var consulta = 
            from num in numeros
            where num%2==0
            select num;
            //Ejecutar consulta, pares (regresa un IEnumerable<int>)
            foreach (var num  in consulta)
            {
                Console.Write($"{num} ");
            }
            //Consulta 2, numeros entre 10 y 200 no negativos ni ceros, en un areglo (regresa un int[])
            var consulta2 = 
            (from num in  numeros 
            where num>=10 && num<=200 
            select num).ToArray();
            Console.WriteLine();

            Console.WriteLine("Numeros mayores a 100");
            for (int i = 0; i < consulta2.Count(); i++)
            {
                Console.Write($"{consulta2[i]} ");
            }
            //Consulta 3, negativos, en una lista (regresa List<int>)
            var consulta3 = 
            (from num in numeros
            where num<0
            select num).ToList();
            Console.WriteLine("\n Numeros negativos: ");
            consulta3.ForEach(num=>Console.Write(num));
        }
    }
}
