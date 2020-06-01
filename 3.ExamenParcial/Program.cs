using System;
using System.IO;
using System.Text;
using System.Collections;
using System.Diagnostics;

namespace _3.ExamenParcial
{
    class Program
    {
        static void Main(string[] args)
        {
            if(args.Length < 1) Menu();
            else{
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                switch(int.Parse(args[0])){
                    case 1: Menu(); break;
                    case 2: MiembrosSoloLectura(); break;
                    case 3: ExpresionSwitch(); break;
                    case 4: PatronPropiedades(); break;
                    case 5: PatronTupla(); break;
                    case 6: PatronPosicional(); break;
                    case 7: DeclaracionUsing(); break;
                    case 8: FuncionLocEstatica(); break;
                    case 9: IndiceRangos(); break;
                    /*https://docs.google.com/presentation/d/1b9mfqHuY7xUTecFe3vqPJXwnSY06NHpqjH5m4pSEfW4/edit?usp=sharing*/
                    default: Console.WriteLine("Opción invalida ..."); break;
                }
                Console.ForegroundColor=ConsoleColor.Blue;
            }
        }
        static void Menu()
        {
            Console.Clear();
            Console.ForegroundColor=ConsoleColor.White;
            Console.WriteLine("Características nuevas en C#8 \n");
            Console.WriteLine("[1] Menu.............................");
            Console.WriteLine("[2] Miembros de solo lectura.........");
            Console.WriteLine("[3] Expresiones switch...............");
            Console.WriteLine("[4] Patrones de propiedades..........");
            Console.WriteLine("[5] Patrones de tupla ...............");
            Console.WriteLine("[6] Patrones posicionales............");
            Console.WriteLine("[7] Declaraciones Using .............");
            Console.WriteLine("[8] Funciones locales estáticas......");
            Console.WriteLine("[9] Inidces y rangos.................");
            Console.ForegroundColor=ConsoleColor.Black;        
        }
        static void MiembrosSoloLectura()
        {
            ArrayList miArreglo = new ArrayList();
            miArreglo.Add( "Rojo" );
            miArreglo.Add( "Naranja" );
            miArreglo.Add( "Amarillo" );
            miArreglo.Add( "Rosa" );

            ArrayList miSoloLectArreglo = ArrayList.ReadOnly( miArreglo );

            // Muestra si ArrayList es de solo lectura o de escritura.
            Console.WriteLine( "miArreglo es {0}.", miArreglo.IsReadOnly ? "Solo lectura" : "Escritura" );
            Console.WriteLine( "miSoloLectArreglo es {0}.", miSoloLectArreglo.IsReadOnly ? "Solo lectura" : "Escritura" );

            // Muestra el contenido de ambas colecciones..
            Console.WriteLine( "\nInicialmente," );
            Console.WriteLine( "El arreglo original contiene:" );
            foreach ( String myStr in miArreglo )
                Console.WriteLine( "   {0}", myStr );
            Console.WriteLine( "La ArrayList de solo lectura miSoloLectArreglo contiene:" );
            foreach ( String myStr in miSoloLectArreglo )
                Console.WriteLine( "   {0}", myStr );

            // Agregar un elemento a la ArrayList original afecta a la ArrayList de solo lectura.
            miArreglo.Add( "Azul" );

            // Muestra de nuevo el contenido de ambas colecciones..
            Console.WriteLine( "\n Despues de añadir el nuevo elemento al ArrayList," );
            Console.WriteLine( "ArrayList miArreglo contiene:" );
            foreach ( String myStr in miArreglo )
                Console.WriteLine( "   {0}", myStr );
            Console.WriteLine( " miSoloLectArreglo arreglo de solo lectura contiene:" );
            foreach ( String myStr in miSoloLectArreglo )
                Console.WriteLine( "   {0}", myStr );

        }
        static void ExpresionSwitch()
        {
            int caseSwitch = 1;
            switch (caseSwitch)
            {
                case 1:
                Console.WriteLine("Ejemplo simple de switch");break;
                case 2:
                Console.WriteLine("Fin del ejemplo simple de switch");break;
                default:
                Console.WriteLine("Default");break;
            } 
        }
        static void PatronPropiedades()
        {
            
        }
        static void PatronTupla()
        {
            // conversiones levantadas
            var left = (a: 5, b: 10);
            (int? a, int? b) nullableMembers = (5, 10);
            Console.WriteLine(left == nullableMembers);

            // tipo convertido de izquierda es (largo, largo)
            (long a, long b) longTuple = (5, 10);
            Console.WriteLine(left == longTuple); 

            // comparaciones realizadas en tuplas (largas, largas)
            (long a, int b) longFirst = (5, 10);
            (int a, long b) longSecond = (5, 10);
            Console.WriteLine(longFirst == longSecond);
        }
        static void PatronPosicional()
        {
           String[] pairs = { "Color1=red", "Color2=green", "Color3=blue",
                 "Title=Code Repository" };
            foreach (var pair in pairs) 
            {
                int position = pair.IndexOf("=");
                if (position < 0)
                    continue;
                Console.WriteLine("Key: {0}, Value: '{1}'", 
                            pair.Substring(0, position),
                            pair.Substring(position + 1)); 
            }
        }            
        static void DeclaracionUsing()
        {
            string manyLines=@"Esta es la primera linea
            Linea dos
            Esta el la linea tres
            La penultima linea, la linea cuatro
            Este es el fin de la linea.";

            using var reader = new StringReader(manyLines);
            string? item;
            do {
                item = reader.ReadLine();
                Console.WriteLine(item);
            } while(item != null);
        }
        static void FuncionLocEstatica()
        {
            double dub = -3.14;  
            Console.WriteLine(Math.Abs(dub));  
            Console.WriteLine(Math.Floor(dub));  
            Console.WriteLine(Math.Round(Math.Abs(dub)));  
  

        }
        static void IndiceRangos()
        {
            var jagged = new int[10][]
            {
            new int[10] { 0,  1, 2, 3, 4, 5, 6, 7, 8, 9},
            new int[10] { 10,11,12,13,14,15,16,17,18,19},
            new int[10] { 20,21,22,23,24,25,26,27,28,29},
            new int[10] { 30,31,32,33,34,35,36,37,38,39},
            new int[10] { 40,41,42,43,44,45,46,47,48,49},
            new int[10] { 50,51,52,53,54,55,56,57,58,59},
            new int[10] { 60,61,62,63,64,65,66,67,68,69},
            new int[10] { 70,71,72,73,74,75,76,77,78,79},
            new int[10] { 80,81,82,83,84,85,86,87,88,89},
            new int[10] { 90,91,92,93,94,95,96,97,98,99},
            };

            var selectedRows = jagged[3..^3];

            foreach (var row in selectedRows)
            {
                var selectedColumns = row[2..^2];
                foreach (var cell in selectedColumns)
                {
                    Console.Write($"{cell}, ");
                }
                Console.WriteLine();
            }    
        }
    }
}

