using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_1
{
    public class Personaje
    {
        public string Nombre { get; set; }
        public int Nivel { get; set; }
        public Personaje(string nombre, int nivel)
        {
            Nombre = nombre;
            Nivel = nivel;
        }
        public virtual string MostrarInformación()
        {
            return $"Nombre: {Nombre}, Nivel: {Nivel}";
            //return "Nombre: " + Nombre + ", Nivel: " + Nivel; "
        }
    }
}
