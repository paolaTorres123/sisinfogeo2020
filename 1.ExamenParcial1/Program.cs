using System;

namespace _1.ExamenParcial1
{
    class Program
    {
        static void Main()
        {
            //Creamos los objetos tipo red
            Console.WriteLine("---------------Datos Generales de la red----------------------------\n"); 
            Red r1 = new Red("Red Patito , S.A. de C.V.","Mr. Pato  Macdonald","Av.Princenton 123,Orlando Florida"); 
            Console.WriteLine($"Empresa : {r1.Empresa}");
            Console.WriteLine($"Propietario: {r1.Propietario}");
            Console.WriteLine($"Domicilio: {r1.Domicilio}\n");
            Console.WriteLine("----------------------------------------------------------------------\n"); 
          
            //Agregando un nodo
            
            r1.AgregarNodo(new Nodo("192.168.0.13","servidor     ","5 ",10," linux"));
            r1.AgregarNodo(new Nodo("192.168.0.12","equipoactivo ","2 ",12," ios"));
            r1.AgregarNodo(new Nodo("192.168.0.20","computadora  ","8 ",5 ," window"));
            r1.AgregarNodo(new Nodo("192.168.0.15","servidor     ","10",22," linux"));

            //Agregando vulnerbiidades

            r1.Nodos[0].AgregarVulnerabilidad(new Vulnerabilidad("CVE-2015-1635","microsoft",
                                        "HTTP syst permite al atacante ejecutar codigo arbitrario","remota",DateTime.Parse("04/12/2015")));
            r1.Nodos[0].AgregarVulnerabilidad(new Vulnerabilidad("VE-2017-0004","cisco",
                                        "Cisco Firepower Management CenterXSS","remota",DateTime.Parse("04/05/2011")));
            r1.Nodos[1].AgregarVulnerabilidad(new Vulnerabilidad("VE-2017-0004","CPU",
                                        "Cisco Firepower Management CenterXSS","remota",DateTime.Parse("04/04/2015")));
            



            Console.WriteLine($"Total de nodos de la red: {r1.Nodos.Count}");
            int suma = 0;
            foreach(Nodo n1 in r1.Nodos) {
                suma += n1.Vulnerabilidad.Count;
            }
            Console.WriteLine($"Total de vulnerabilidades: {suma}\n");
            Console.WriteLine($"----------------------Datos generales de los nodos:--------------------------------- \n");

            foreach(Nodo n1 in r1.Nodos) {
                
                Console.WriteLine($"IP : {n1.Ip },    Tipo: {n1.Tipo },  Puerto : {n1.Puerto },      Saltos : {n1.Saltos },    So : { n1.So}\n");
            }
            Console.WriteLine($"Mayor numero de saltos {r1.mayor()}");
            Console.WriteLine($"Menor numero de saltos {r1.menor()}");
            Console.WriteLine($"---------------------------------------------------------------------------------- \n");


           //Calculando numero mayor.
        
            Console.WriteLine("---------------------Vulnerabilidades por nodo:---------------------------------- \n");
            
            foreach(Nodo n1 in r1.Nodos) {

                Console.WriteLine($"> IP : {n1.Ip} Tipo : {n1.Tipo}\n");
            
                int contador =0;
                foreach(Vulnerabilidad v1 in n1.Vulnerabilidad) {
                    Console.WriteLine(v1) ;
                    Console.WriteLine("Antiguedad "+v1.calcularAntiguedad());
                    contador++;
                    
                }
                Console.WriteLine($"Total de vulnerabilidades es: {contador}");
            }
        }
    }
}












































































































































































































































































































