using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace clase10_Ejer02_Exception
{
    public class MisExceptions : Exception
    {
        
        public MisExceptions(string mensaje) :base(mensaje)
        {
             
        }
        
        public MisExceptions(string mensaje,Exception innerException) :base(mensaje,innerException)
        {

        }

    }
}
