using System;

namespace _10.vectorSumas
{
    class Program
    {
        static void Main(string[] args)
        {
            const int MAX=30;

            double[] A = new double [MAX];

            Random aleatorio = new Random();
            int cp=0,cn=0,cz=0;
            double sp=0,sn=0,sz=0;

            //Generar numeros aleatorio

            for (int i = 0; i < MAX; i++)
            {
                A[i] = aleatorio.Next(-10,50);
                if(A[i]>0){
                    cp++;
                    sp+=A[i];
                }else if(A[i]<0){
                    cn++;
                    sn+=A[i];
                }else{
                    cz++;
                    sz+=A[i];
                }
            }
            Console.WriteLine("Eleva al cubo los 30 elementos en un vector \n");
            imprimir(A);
            Console.WriteLine($"Los positivos son {cp} y suman {sp}");
            Console.WriteLine($"Los negativos son {cn} y suman {sn}");
            Console.WriteLine($"Los ceros son {cz} y suman {sz}");
        

            
        }
        static void imprimir(double[] v){
            for(int i=0; i<v.Length; i++)
            {
                Console.Write($"{v[i]} ");
                
            }
            Console.WriteLine();


        }
    }
}