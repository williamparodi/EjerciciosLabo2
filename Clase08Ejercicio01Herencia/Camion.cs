using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase08Ejercicio01Herencia
{
    public class Camion : VehiculoTerrestre
    {
        private short cantidadMarchas;
        private int pesoCarga;

        public Camion(short cantidadDeRuedas, short cantidadPuertas, EColores color) : base(cantidadDeRuedas, cantidadPuertas, color)
        {
            this.cantidadMarchas = 0;
            this.pesoCarga = 0;
        }

        public Camion(short cantidadDeRuedas, short cantidadPuertas, EColores color,short cantidadMarchas,int pesoCarga) : base(cantidadDeRuedas, cantidadPuertas, color)
        {
            this.cantidadMarchas = cantidadMarchas;
            this.pesoCarga = pesoCarga;
        }
        
        public string MostrarCamion()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Cantidad de ruedas: {this.cantidadDeRuedas}");
            sb.AppendLine($"Cantidad de puertas: {this.cantidadPuertas}");
            sb.AppendLine($"Color: {this.color}");
            sb.AppendLine($"Cantidad de marcas: {this.cantidadMarchas}");
            sb.AppendLine($"Peso de Carga: {this.pesoCarga}");
            return sb.ToString();
        }


    }
}
