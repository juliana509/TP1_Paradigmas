using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_1
{
    public class Guerrero : Personaje
    {
        public string Arma { get; set; }
        public decimal Fuerza { get; set; }
        override public string MostrarInformación()
        {
            return base.MostrarInformación() + $", Arma: {Arma}, Fuerza: {Fuerza}";
        }
        #region Constructores
        public Guerrero(string nombre, int nivel, string arma, decimal fuerza) : base(nombre, nivel)
        {
            // Arma = arma;
            // Fuerza = fuerza;
        }
        #endregion
    }
}
