using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_1
{
    public class CalculadoraDanio
    {
        public decimal Danio { get; set; }
        public decimal Defensa { get; set; }
        public decimal PorcentajeBonificacion { get; set; }
        public CalculadoraDanio(decimal danio, decimal defensa, decimal porcentajeBonificacion)
        {
            Danio = danio;
            Defensa = defensa;
            PorcentajeBonificacion = porcentajeBonificacion;
        }
        public decimal Calcular(decimal danio)
        {
            decimal danioFinal = Danio - Defensa;
            if (danioFinal < 0)
            {
                danioFinal = 0;
            }
            return danioFinal;
        }
        public decimal Calcular(decimal danio, decimal defensa, decimal porcentaje)
        {
            decimal danioFinal = (danio - defensa)*porcentaje;
            if (danioFinal < 0)
            {
                danioFinal = 0;
            }
            return danioFinal;
        }
    }
}
