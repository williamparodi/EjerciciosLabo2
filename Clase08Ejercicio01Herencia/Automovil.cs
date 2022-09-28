using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase08Ejercicio01Herencia
{
    public class Automovil : VehiculoTerrestre
    {
        private int cantidadPasajeros;
        private short cantidadMarchas;
        public Automovil(short cantidadDeRuedas, short cantidadPuertas, EColores color) : base(cantidadDeRuedas, cantidadPuertas, color)
        {
            this.cantidadPasajeros = 0; 
        }

        public Automovil(short cantidadDeRuedas, short cantidadPuertas, EColores color,short cantidadDeMarchas,int cantidadPasajeros) : base(cantidadDeRuedas, cantidadPuertas, color)
        {
            this.cantidadMarchas = cantidadDeMarchas;
            this.cantidadPasajeros = cantidadPasajeros;
        }


    }
}
