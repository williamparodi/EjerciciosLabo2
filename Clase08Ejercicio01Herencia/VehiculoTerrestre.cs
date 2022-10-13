using System;

namespace Clase08Ejercicio01Herencia
{
    public abstract class VehiculoTerrestre
    {
        protected short cantidadDeRuedas;
        protected short cantidadPuertas;
        protected EColores color;

        public VehiculoTerrestre(short cantidadDeRuedas, short cantidadPuertas, EColores color)
        {
            this.cantidadDeRuedas = cantidadDeRuedas;
            this.cantidadPuertas = cantidadPuertas;
            this.color = color; 
        }


    }
}
