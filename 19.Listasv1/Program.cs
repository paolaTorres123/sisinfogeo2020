using System;
using System.Collections.Generic;

namespace _19.Listasv1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Definir una lista con valores iniciales
            List<string> materias = new List<string>(){
                "Calculo I",
                "Redaccion Avanzada",
                "Introduccion a la Ingenieria"
            };

            //Agregar elementos a la lista
            materias.Add("Matematicas Discretas");
            materias.Add("Compiladores e Interpretadores");
            Imprime(materias);

            //Agregar un rango de materias
            string[] optativas = {
                "Sistemas de Informacion Geograficos(op)",
                "Seguridad en redes (op)",
                "Topicos Selectos de Redes (op)"
            };
            materias.AddRange(optativas);
            Imprime(materias);

            //Invertir los elementos de la lista
            materias.Reverse();
            Imprime(materias);

            //Ordenar la lista
            materias.Sort();
            Imprime(materias);

            //Buscar un elemento en la lista en base a una condicion
            Console.WriteLine("Buscar una materia que tenga la palabra discretas");
            string materia = materias.Find(x=> x.Contains("Discretas"));//x variable de control
            Console.WriteLine(materia);

            //Buscar todas las ocurrencias en la lista, en base a una condicion
            Console.WriteLine("Buscar todas las materias que tengan la palabra (op)");
            var ms = materias.FindAll(x=> x.Contains("(op)"));//x variable de control
            Imprime(ms);
        }
        static void Imprime(List<string> lista){
            Console.WriteLine("///////////////////////////////////////////");
            Console.WriteLine("\n");
            foreach (string m in lista)
            {
                Console.WriteLine(m);
            }
            Console.WriteLine(lista.Count);
        }
    }
}
