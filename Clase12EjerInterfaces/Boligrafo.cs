using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text;

namespace Clase12EjerInterfaces
{
    public class Boligrafo : IAcciones
    {
        private ConsoleColor colorTinta;
        private float tinta;


        public Boligrafo(float tinta, ConsoleColor color)
        {
            this.colorTinta = color;
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



        public EscrituraWrapper Escribir(string texto)
        {
            EscrituraWrapper escritura = new EscrituraWrapper(texto, Color);

            foreach (char c in texto)
            {
                this.tinta -= (float)0.3;
            }

            return escritura;
        }

        public bool Recargar(int unidades)
        {
            bool ret = false;

            if (unidades > 0)
            {
                this.tinta += unidades;
                ret = true;
            }

            return ret;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder("");
            sb.AppendLine("Esta escribiendo con un boligrafo");
            sb.AppendLine(this.colorTinta.ToString());
            sb.AppendLine($"El nivel de tinta es de {this.tinta}");
            return sb.ToString();
        }




    }
}
