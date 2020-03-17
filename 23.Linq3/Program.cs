using System;
using System.Collections.Generic;
using System.Linq;


namespace _23.Linq3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Estudiante> grupo = new List<Estudiante>(); 
            grupo.Add(new Estudiante {Id=1234,Nombre="Jose",Ciudad="Zacatecas",
                Calle="1 de Mayo",
                Cals= new List<int> {90,80,70,60}
                }
            );
            grupo.Add(new Estudiante {Id=4567,Nombre="Maria",Ciudad="Fresnillo",
                Calle="Benito Juarez",
                Cals= new List<int> {90,50,60,60}
                }
            );
            grupo.Add(new Estudiante {Id=7891,Nombre="Miguel",Ciudad="Jerez",
                Calle="Garcia Salinas",
                Cals= new List<int> {50,50,50,40}
                }
            );
            grupo.Add(new Estudiante {Id=6666,Nombre="Lourdes",Ciudad="Zacatecas",
                Calle="El Vergel",
                Cals= new List<int> {100,100,100,90}
                }
            );
            //iMPRIMIR DATOS
            Console.WriteLine("\n Todo de todo");
            grupo.ForEach(est=>Console.WriteLine(est.ToString()));

            //Todos ordenados por nombre
            var q1 = 
                (from est in grupo orderby est.Nombre
                select est).ToList();
                Console.WriteLine("\n Ordenado por nombre");
            q1.ForEach(est=>Console.WriteLine(est.ToString()));

            //Solo Zacatecas
            var q2 = 
                (from est in grupo
                where est.Ciudad=="Zacatecas"
                select est).ToList();
                Console.WriteLine("\n Solo Zacatecas");
            q2.ForEach(est=>Console.WriteLine(est.ToString()));
                
            //El nombre de estudiantes con promedio arriba de 80
            var q3= 
                (from est in grupo 
                where est.Cals.Average()>70
                select new {nombre=est.Nombre, promedio=est.Cals.Average()}).ToList();
                //where promedio>80
                //select est
            Console.WriteLine("\n Nombre y Promedio de los mayores a 70");
            q3.ForEach(est=>Console.WriteLine($"Nombre:{est.nombre}, Promedio:{est.promedio}"));

            //Agrupar por ciudad
            var q4= 
                from est in grupo group est by est.Ciudad;
            Console.WriteLine("\n Estudiantes agrupados por Ciudad");
            foreach (var ciudad in q4)
            {
                Console.WriteLine(ciudad.Key);
                foreach (var est in ciudad)
                {
                    Console.WriteLine(est.ToString());
                }
            }

        }
    }
}
