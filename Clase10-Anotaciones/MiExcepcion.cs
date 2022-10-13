using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase10_Anotaciones
{
    public class MiExcepcion : Exception
    {
        public MiExcepcion() : base("Lanzaste mi excepcion por defecto")
        {

        }

        public MiExcepcion(string message) : base(message)//usar este
        {

        }

        public MiExcepcion(string message, Exception innerException) : base(message, innerException) // no uso inner   
        {

        }
    }
}
