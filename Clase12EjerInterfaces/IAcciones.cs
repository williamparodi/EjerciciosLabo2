using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase12EjerInterfaces
{
    public interface IAcciones
    {
        public ConsoleColor Color{get; set;}
        public float UnidadesDeEscritura{get;set;}

        EscrituraWrapper Escribir(string texto);
        string Recargar(int unidades);
    }

}
