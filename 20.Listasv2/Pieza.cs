using System;

namespace _20.Listasv2
{
    class Pieza
    {
        public Pieza(int id, string nombre)=>(Id,Nombre)=(id,nombre);//constructor
        public int Id {get; set;}
        public string Nombre {get;set;}
        //sobrecargar el metodo ToString()
        public override string ToString() => $"{Id} - {Nombre}";
    }
}