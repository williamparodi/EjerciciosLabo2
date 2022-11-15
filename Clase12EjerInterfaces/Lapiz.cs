using Clase12EjerInterfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase12EjerInterfaces
{
    public class Lapiz : IAcciones
    {
        private float tamanioMina;
        public Lapiz(float tamanioMina)
        {
            this.tamanioMina = tamanioMina;

        }

        ConsoleColor IAcciones.Color
        {
            get { return ConsoleColor.Gray; }
            set { throw new NotImplementedException(); }
        }

        float IAcciones.UnidadesDeEscritura
        {
            get { return tamanioMina; }
            set { tamanioMina = value; }
        }

        EscrituraWrapper IAcciones.Escribir(string texto)
        {
            foreach (char c in texto)
            {
                this.tamanioMina -= (float)0.1;
            }
            ((IAcciones)this).UnidadesDeEscritura = tamanioMina;
            EscrituraWrapper escrituraWrapper = new EscrituraWrapper(texto, ((IAcciones)this).Color);
            return escrituraWrapper;
        }

        bool IAcciones.Recargar(int unidades)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder("");
            sb.AppendLine("Es un lapiz");
            sb.AppendLine(((IAcciones)this).Color.ToString());
            sb.AppendLine($"La tamanio de mina es :{this.tamanioMina} ");
            return sb.ToString();
        }






    }
}