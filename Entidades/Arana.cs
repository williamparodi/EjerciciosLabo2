using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Arana : ICazador
    {
        public string Cazador()
        {
            return "Estoy esperando que la presa caiga";
        }
    }
}
