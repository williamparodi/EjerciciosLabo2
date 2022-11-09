using System.Collections.Generic;
using System.Text;

namespace BibliotecaEjercicioClase12
{

    public class Torneo<T> where T : Equipo
    {
        public List<T> equipos;
        public string nombre;


        public static bool operator ==(Torneo<T> torneo, T equipo)
        {
            bool retorno = false;
            foreach (T item in torneo.equipos)
            {
                if (item == equipo)
                {
                    retorno = true;
                }
            }

            return retorno;
        }

        public static bool operator !=(Torneo<T> torneo, T equipo)
        {
            return !(torneo == equipo);
        }

        public static bool operator +(Torneo<T> torneo, T equipo)
        {
            bool retorno = false;

            if (torneo != equipo)
            {
                torneo.equipos.Add(equipo);
                retorno = true;
            }

            return retorno;

        }

        public string Mostrar(Torneo<T> torneo)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre del Torneo: ");

            foreach(T item in torneo.equipos)
            {
              
            }
        }

    }
}
