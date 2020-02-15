using System;

namespace _13.VectorEstaisticas
{
    class Program
    {
        int [] vector;
        int menor;
        int mayor;
        double promedio;

        public void Cargar()
        {
            Console.Write("Ingrese longitud del vector: "+"\n");
            string linea;
            linea = Console.ReadLine();
            int n = int.Parse(linea);
            vector = new int[n];
            for (int i = 0; i < vector.Length; i++)
            {
                Console.Write("Ingrese el valor del vector en la posicion["+(i+1)+"]:");
                linea = Console.ReadLine();
                vector[i]=int.Parse(linea);
            }
        }
        public void ValorMenor()
        {
            menor =vector[0];
            for (int i = 0; i < vector.Length; i++)
            {
                if(vector[i]<menor)
                {
                    menor = vector[i];
                }
            }
            Console.WriteLine($"\n El elemento menor es:{menor}");
        }
        public void ValorMayor()
        {
            mayor =vector[0];
            for (int i = 0; i < vector.Length; i++)
            {
                if(vector[i]>mayor)
                {
                    mayor = vector[i];
                }
            }
            Console.WriteLine($"\n El elemento mayor es:{mayor}");
        }
        public void Promedio()
        {
            //promedio = vector[0];
            for (int i = 0; i < vector.Length; i++)
            {
                promedio+=vector[i];
            }
            Console.WriteLine($"\nEl promedio del vector: {promedio/vector.Length}\n");
        }
        public void Varianza()
        {
            double r=0,t=0;
            for (int i = 0; i < vector.Length; i++)
            {
                r+=Math.Pow(vector[i],2);
                t=((r/vector.Length)-1);
                
                
            }
            Console.WriteLine($"{r}promedio");
            Console.WriteLine($"La varianza de los valores es {t}\n");
        }
        public void DesviacionEstandar()
        {
            double r=0,t=0,h=0;
            for (int i = 0; i < vector.Length; i++)
            {
                r+=Math.Pow(vector.Length,2);
                t=((r/vector.Length)-1);
                h=Math.Sqrt(t);
            }
            Console.WriteLine($"La desviacion Estandar de los vectores es: {h}\n");
        }



        static void Main(string[] args)
        {
            Program p = new Program();
            p.Cargar();
            p.ValorMenor();
            p.ValorMayor();
            p.Promedio();
            p.Varianza();
            p.DesviacionEstandar();
        }
    }
}
