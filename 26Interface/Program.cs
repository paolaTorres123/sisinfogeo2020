using System;

namespace _26Interface
{
    public class Organismo
    {
        public void Respiracion()
        {
            Console.WriteLine("Respracion");
        }
        public void Movimiento()
        {
            Console.WriteLine("Movimiento");
        }
        public void Crecimiento()
        {
            Console.WriteLine("Crecimiento");
        }
    }
    public interface IAnimales
    {
        void MultiCelular();
        void SangreCaliente();
    }
    public interface ICanino : IAnimales
    {
        void Corre();
        void Cuatropatas();
    }
    public interface IPajaro : IAnimales
    {
        void Vuela();
        void Dospatas();
    }
    public class Perro : Organismo, ICanino 
    {
        public void MultiCelular() => Console.WriteLine("Multicelular");
        public void SangreCaliente() => Console.WriteLine("Sangre caliente");
        public void Corre() => Console.WriteLine("Corre");
        public void Cuatropatas() => Console.WriteLine("Cuatro Patas");
    }
    public class Perico : Organismo, IPajaro
    {
        public void MultiCelular() => Console.WriteLine("Multicelular");
        public void SangreCaliente() => Console.WriteLine("Sangre caliente");
        public void Vuela() => Console.WriteLine("Vuela");
        public void Dospatas() => Console.WriteLine("Dos patas");
    }
    class Program
    {
        
        static void Main(string[] args)
        {
            Perro perro =new Perro();
            Console.WriteLine("\n Caracteristicas del Perro \n");
            perro.Respiracion();
            perro.Movimiento();
            perro.Crecimiento();
            perro.Corre();
            perro.Cuatropatas();

            Perico perico =new Perico();
            Console.WriteLine("Caracteristicas del Perico \n");
            perico.Respiracion();
            perico.Movimiento();
            perico.Crecimiento();
            perico.Vuela();
            perico.Dospatas();
        }
    }
}
