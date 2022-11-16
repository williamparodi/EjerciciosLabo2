using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaEjercicioClase12
{
    public abstract class Equipo
    {
        public string nombre;
        public DateTime fechaDeCreacion;

        public Equipo(string nombre,DateTime fechaDeCreacion)
        {
            this.nombre = nombre;
            this.fechaDeCreacion = fechaDeCreacion; 
        }
        public static bool operator ==(Equipo e1, Equipo e2)
        {
            bool retotno = false;
            if (e1.nombre == e2.nombre && e1.fechaDeCreacion == e2.fechaDeCreacion)
            {
                retotno = true;
            }

            return retotno;
        }

        public static bool operator !=(Equipo e1, Equipo e2)
        {
            return !(e1 == e2);
        }

        public string Ficha(Equipo equipo)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{this.nombre} fundado el {this.fechaDeCreacion}");
            return sb.ToString();
        }





    }
}
