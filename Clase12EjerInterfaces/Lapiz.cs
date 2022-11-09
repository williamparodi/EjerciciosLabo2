using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase12EjerInterfaces
{
    public class Lapiz : Boligrafo,IAcciones
    {
        private float tamanioMina;

        public Lapiz(ConsoleColor color,float tinta, float tamanioMina) :base (color,tinta)
        {
            this.tamanioMina = tamanioMina;
        }

        ConsoleColor IAcciones.Color
        {
            get { return Color; }
            set { Color = value; }
        }

        float IAcciones.UnidadesDeEscritura
        {
            get { return UnidadesDeEscritura; }
            set { UnidadesDeEscritura = value; }
        }

        EscrituraWrapper IAcciones.Escribir(string texto)
        {
            foreach (char c in texto)
            {
                this.tamanioMina -= (float)0.3;
            }
            
            EscrituraWrapper escrituraWrapper = new EscrituraWrapper(texto,this.Color);
            return escrituraWrapper;
        }

    }
}
