using System;
using System.Collections.Generic;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Ejercicio_1
{
    public class UsuarioStreaming
    {
        //Propiedades
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string email { get; set; }
        public string DNI { get; set; }

        public DateTime fechaSuscripcion
        {
            get {  return field; }
            set
            {
                if (value >= DateTime.Now)
                {
                    throw new ArgumentException("La fecha de suscripcion no puede ser mayor a fecha actual");
                }
                else
                {
                    field = value;
                }
            }
        }

        //{ get; set; } significa que deja de ser variable y pasa a ser un metodo
        //no debe ser necesariamente publico
        //cuando es privado, solo se accede desde clase
        //publico accede desde programa

        /*public void SetNombre(string nombre)
        {
            nombre = nombre;
        }
        string GetNombre()
        {
            return nombre; 
        }*/

        //Metodos o Funciones
        //Metodos(void) -- Funcion (int, str,...), debe tener return
        public void mostrarInformacion()
        {
            Console.WriteLine("Nombre: " + nombre);
            Console.WriteLine("Apellido: " + apellido);
            Console.WriteLine("Email: " + email);
            Console.WriteLine("Fecha de Suscripcion: " + fechaSuscripcion);
        }

        public override bool Equals(object obj)
        {
            if (obj is UsuarioStreaming otroUsuario)
            {
                return
                    this.DNI == otroUsuario.DNI;
            }
            return false;
        }
        public override int GetHashCode()
        {
            return DNI.GetHashCode();
        }
        public static bool operator ==(UsuarioStreaming usuario1, UsuarioStreaming usuario2)
        {
            if (ReferenceEquals(usuario1, null) && ReferenceEquals(usuario2, null))
            {
                return true;
            }
            if (ReferenceEquals(usuario1, null) || ReferenceEquals(usuario2, null))
            {
                return false;
            }
            return usuario1.Equals(usuario2);
        }

        public static bool operator !=(UsuarioStreaming usuario1, UsuarioStreaming usuario2)
        {
            return !(usuario1 == usuario2);
        }
    }
}
