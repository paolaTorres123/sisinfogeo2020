using System;
namespace ej1
{
    class empleado
    {
        //Miebros de la clase
        private string nombre;
        private int edad;

        //Constructor(es)
        public empleado()
        {
            
        }
        public empleado(string nombre, int edad)
        {
            this.nombre=nombre;
            this.edad=edad;
        }

        //Propiedades e las clases utiles para enviar y resivir valores
        public string Nombre
        {
            get{return nombre;}
            set{nombre=value;}
        }

        public int Edad
        {
            get{return edad;}
            set{edad=value;}
        }
        //Metodos de la clase
        public string Vacaciones(DateTime ini,int dias)
        {
            DateTime fin;
            fin = ini.AddDays(dias);
            return fin.ToString("dd/MM/yy");
        }
        /*Sobrecargamos el metodo ToString heredado de la clase base (Object)*/
        public override string ToString()
        {
            return $"Nombre: {nombre} Edad: {edad}";
        }
        
    }
}