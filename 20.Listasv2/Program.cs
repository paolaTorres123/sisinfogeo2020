using System;
using System.Collections.Generic;

namespace _20.Listasv2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Crear una lista de tipo Pieza
            List<Pieza> mp = new List<Pieza>();

            //Agregar elemntos a la lista
            mp.Add(new Pieza(1234,"tuerca de rosca interior"));
            mp.Add(new Pieza(5678,"tornillo cabeza grande"));
            mp.Add(new Pieza(9101,"bateria de carro"));

            //Agregar un rango de elementos
            var proveedor = new List<Pieza>(){
                new Pieza(8888,"tornillo de cabeza pequena"),
                new Pieza(9999,"cables para pasar corriente"),
                new Pieza(9656,"tridente del diablo"),


            };
            mp.AddRange(proveedor);
            //Usar el metodo ForEach integrado  en la lista para imprimir su contenido
            mp.ForEach(p=>Console.WriteLine(p.ToString()));

            //Eliminar el ultimo elemento de la lista
            mp.RemoveAt(mp.Count-1);

            //Insertar un elemento en la segunda posicion
            Console.WriteLine("Insertar un elemento en la posicion 2");
            mp.Insert(1, new Pieza(2222,"Caja de 8 velocidades"));
            mp.ForEach(p=>Console.WriteLine(p.ToString()));

            //Buscar todas las piezas que tengan la palabra tornillo
            Console.WriteLine("Piezas que tienen tornillo");
            var t=mp.FindAll(x=> x.Nombre.Contains("tornillo"));
            t.ForEach(p=>Console.WriteLine(p.ToString()));

            //Buscar todas las piezas cuyo ID es menor que 5000
            Console.WriteLine("Piezas con id mayor que 5000");
            var t1=mp.FindAll(x=> x.Id >5000);
            t1.ForEach(p=>Console.WriteLine(p.ToString()));
        }
    }
}
