using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Hola
    {
        private string[] saludo;
        private string[] variantes = { "Buenos Dias", "Que tal", "Chau" };

        public string this[int index]
        {
            get
            {
                return this.variantes[index];
            }
            set
            {
                this.variantes[index] = value;
            }
        }
    }
}
