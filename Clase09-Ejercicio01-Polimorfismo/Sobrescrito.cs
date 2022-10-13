using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase09_Ejercicio01_Polimorfismo
{
    public abstract class Sobrescrito
    {
        protected string miAtributo;

        //Parte 1
        public override string ToString()
        {
            return "¡Este es mi método ToString sobrescrito!";
        }

        public override bool Equals(object obj)
        {
            Sobrescrito obj2 = obj as Sobrescrito;

            return (obj == obj2);
        }

        public override int GetHashCode()
        {
            return 1142510181;
        }
        
        //Parte 2

        public Sobrescrito()
        {
            this.miAtributo = "Probar abstractos";
        }

        //Propiedad Abstract
        public abstract string MiPropiedad
        {
            get;
        }

        //Metedo abstract 
        public abstract string MiMetodo();

       

    }
}
