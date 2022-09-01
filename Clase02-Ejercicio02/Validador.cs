using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase02_Ejercicio02
{
    public static class Validador
    {
        public static bool ValidarRespuesta(string respuesta)
        {
            bool retorno = false;

            if(respuesta == "s")
            {
                retorno = true;
            }

            return retorno;
        }
    }
}
