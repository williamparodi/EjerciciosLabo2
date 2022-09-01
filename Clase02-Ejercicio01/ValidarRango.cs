using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase02_Ejercicio01
{
    public static class ValidarRango
    {
        public static bool Validar (int valor, int min, int max)
        {
            bool retorno = false;

            if(valor >= min && valor <= max)
            {
                retorno = true;
            }

            return retorno;
        }
    }
}
