using System;

namespace Clase12EjerInterfaces
{

    public interface IAcciones
    {
        public ConsoleColor Color { get; set; }
        public float UnidadesDeEscritura { get; set; }

        public EscrituraWrapper Escribir(string texto);

        public bool Recargar(int unidades);
    }

}
