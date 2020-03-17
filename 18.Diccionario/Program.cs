using System;
using System.Collections.Generic;

namespace _18.Diccionario
{
    class Program
    {
        static void Main(string[] args)
        {
            //Definimos el diccionario y reservamos espacio en memoria para el
            SortedDictionary <string,string> midic = new SortedDictionary<string,string>();
            //txt es la la llave despues viene la descripcion
            //Agregar entradas al diccionario
            midic.Add("txt","archivo de texto");
            midic.Add("jpg","Archivo de imagen");
            midic.Add("mp3","Archivo de sonido");
            midic.Add("htm","Archivo HTML");
            midic.Add("exe","Archivo ejecutable de Windows");
            midic.Add("lll","Archivo de tipo desconocido");

            //Acceder a un elemento en base a la llave, en base a la llave se accede al valor del campo(descrpcion)
            Console.WriteLine(midic["htm"]);

            //Verificar si una llave existe, si no agregarla
            if (midic.ContainsKey("elf"))
            {
                Console.WriteLine("La llave ya existe");
            }else
            {
                midic.Add("elf","Archivo ejecutable de linux");
            }

            //Borrar una entrada si la llave exite
            if (midic.ContainsKey("lll"))
            {
                midic.Remove("lll");
            }
            //Modificar un valor del diccionario en base a a llave
            midic["htm"]="Archivo de texto HTML";


            //Recorrer el diccionario e Imprimir la llave y su valor
            foreach (KeyValuePair <string,string> val in midic)
            {
                Console.WriteLine($"{val.Key} - {val.Value}");
            }
            //Imprimir solo las llaves del diccionario
            foreach (string llave in midic.Keys)
            {
                Console.WriteLine(llave);
            }
            //Imprimir solo los valores del diccionario
            foreach (string valor in midic.Values)
            {
                Console.WriteLine(valor);
            }
            //Borrar todas las entradas al diccionario

            midic.Clear();
            

        }
    }
}
