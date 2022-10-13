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
        private string mensaje;
        public MisExceptions() :base("Mi exception")
        {
            
        }

        public MisExceptions(string mensaje) :base(mensaje)
        {
             
        }


    }
}
