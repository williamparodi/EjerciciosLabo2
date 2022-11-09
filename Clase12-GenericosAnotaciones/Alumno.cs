using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase12_GenericosAnotaciones
{
    public class Alumno : Persona
    {
        public int legajo;
        private string materiaFavorita;

        public Alumno(int legajo, string materiaFavorita)        {
            this.legajo = legajo;
            this.materiaFavorita = materiaFavorita;
        }
    }
}
