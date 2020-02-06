using System;

namespace _06.tablas
{
    class Program
    {
        static int Main(string[] args)
        {
            int opcion,contador=0,numero,resultado,inicio,limite;
            if(args.Length==0){
                Menu();
                return 1;

            }
            opcion = int.Parse(args[0]);

            Console.Clear();
            switch (opcion)
            {
                case 1:{
                    
                    Console.WriteLine("Tabla de multiplicar");
                    Console.WriteLine("Dime el numero para calcular la tabla: \n");
                    numero =Int32.Parse(Console.ReadLine());
                    Console.WriteLine($"Tabla de multiplicar de {numero}");
                    for(contador=1;contador<=10;contador++){
                        resultado = contador*numero;
                        Console.WriteLine(contador+"X"+numero+"="+resultado);
                    }
                    Console.WriteLine("Presione ENTER para cerrar");
                    Console.ReadKey();
                }break;
                case 2:{

                    for(tablaF=1;tablaF<=int.Parse(args[1]);tablaF+=1){
                        for(rango=int.Parse(args[2]);rango<=int.Parse(args[3]);rango+=1){
                            Console.WriteLine($"{tablaF} X {rango} = {tablaF*rango}");
                        }
                        Console.WriteLine("");
                    }
                }break;
            }

            return 1;
        }
            static void Menu(){
            Console.Clear();
            Console.WriteLine("Programa para tablas de multiplicar \n\n");
            Console.WriteLine("[1] Tabla multipliar");
            Console.WriteLine("[2] Tabla de multiplicar deseada");



        }
           


           
        }
    }
}
