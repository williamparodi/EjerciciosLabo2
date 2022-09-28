using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalClase08
{
    public class Gato : Mascota
    {
        private int vidas;

        public Gato(string nombre,int edad,string sexo) : base(nombre,edad,sexo)
        {
            this.vidas = 0;
        }

        public Gato(string nombre, int edad, string sexo,int vidas) : base(nombre, edad, sexo)
        {
            this.vidas = vidas;
        }
    }
}
