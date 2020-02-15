using System;

namespace ej1
{
    class Program
    {
        static void Main(string[] args)
        {
            empleado em1 =new empleado();

            empleado em2;
            em2 = new empleado();
            
            em1.Nombre = "Juan Perez";
            em1.Edad = 25;

            empleado em3 = new empleado("Maria",30);
            
            //Console.WriteLine($"Nombre:  {em1.Nombre}, Edad: {em1.Edad}");
            Console.WriteLine(em1.ToString());

            Console.WriteLine($"Te vas de vacasiones {DateTime.Now.ToString("dd/MM/yy")}");
            Console.WriteLine($"Regresas: {em1.Vacaciones(DateTime.Now,15)}");
        }
    }
}
