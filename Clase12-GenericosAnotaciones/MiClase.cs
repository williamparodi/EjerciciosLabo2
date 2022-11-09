using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase12_GenericosAnotaciones
{
    /*
    public class MiClase <T>//se reemplaza por el tipo de dato q le pase
    {
        public int entero;
        public T miDato;

        public MiClase(int entero, T miDato)
        {
            this.entero = entero;
            this.miDato = miDato;
        }

        public T MostrarT()
        {
            return this.miDato;
        }
    }
    */
    public class MiClase<T>  where T : class //se reemplaza por el tipo de dato q le pase
    {
        public int entero;
        public T miDato;

        public MiClase(int entero, T miDato)
        {
            this.entero = entero;
            this.miDato = miDato;
        }

        public T MostrarT()
        {
            return this.miDato;
        }
    }
}
