using System;
using System.Drawing;
using System.Runtime.CompilerServices;

namespace Clase12EjerInterfaces
{
    public class Boligrafo : IAcciones
    {
        private ConsoleColor colorTinta;
        private float tinta;

        public Boligrafo(ConsoleColor colorTinta, float tinta)
        {
            this.colorTinta = colorTinta;
            this.tinta = tinta;
        }

        public ConsoleColor Color
        {
            get { return colorTinta; }
            set { colorTinta = value; }
        }

        public float UnidadesDeEscritura
        {
            get { return tinta; }
            set { tinta = value; }
        }

        public Boligrafo(int unidades, ConsoleColor color)
        {
            
        }

        public EscrituraWrapper Escribir(string texto) 
        {
            foreach(char c in texto)
            {
                this.tinta -= (float)0.3;
            }

        }




    }
}
