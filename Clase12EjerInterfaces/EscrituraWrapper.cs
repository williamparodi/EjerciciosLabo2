using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase12EjerInterfaces
{
    public class EscrituraWrapper
    {
        private ConsoleColor color;
        private string texto;

        public EscrituraWrapper(string texto,ConsoleColor color)
        {
            this.color = color;
            this.texto = texto;
        }
    }
}
