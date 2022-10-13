using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase09_Ejercicio01_Polimorfismo
{
    public class SobreSobrescrito : Sobrescrito
    {
        public override string MiPropiedad
        {
            get { return this.miAtributo; }
        }

        public override string MiMetodo()
        {
            return MiPropiedad;
        }
    }
}
