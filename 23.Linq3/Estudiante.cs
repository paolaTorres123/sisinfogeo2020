using System;
using System.Collections.Generic;

namespace _23.Linq3
{
    class Estudiante
    {
        public int Id {get; set;}
        public string Nombre{get; set;}
        public string Ciudad {get; set;}
        public string Calle {get; set;}
        public List<int> Cals;
        public override string ToString()=> $"Id:{Id}, Nombre: {Nombre}, Ciudad: {Ciudad}, Calle: {Calle},  Calificaciones: {string.Join(",",Cals)}";
    }
}