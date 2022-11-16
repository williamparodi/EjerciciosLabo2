using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotecaEjercicioClase12
{

    public class Torneo<T> where T : Equipo //aca restrinjo para que solo sea de tipo Equipo
    {
        public List<T> equipos;
        public string nombre;

        public Torneo()
        {
            this.equipos = new List<T>();
        }
        public Torneo(List<T> equipos, string nombre) : this()
        {
            this.equipos = equipos;
            this.nombre = nombre;
        }

        
      
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
            sb.AppendLine("Nombre del Torneo: ");
            sb.AppendLine($"{torneo.nombre}");
            sb.AppendLine("Equipos :");

            foreach(T item in torneo.equipos)
            {
                sb.AppendLine(item.Ficha(item));
               //poner datos equipo  
            }

            return sb.ToString();
        }

        private string CalcularPartido<U>(U equipo1,U equipo2) where U : Equipo
        {
            StringBuilder sb = new StringBuilder("");
            Random random = new Random();
            int resultado1 = random.Next(0, 8);
            int resultado2 = random.Next(0, 8);
            sb.AppendLine("Resultado: ");
            sb.AppendLine($"{equipo1.nombre} {resultado1} -{equipo2.nombre} {resultado2}");
            return sb.ToString();
        }

        public string JugarPartido
        {
            get
            {
                Random random = new Random();
               
                T equipo1;
                T equipo2;
                do
                {
                    equipo1 = this.equipos[random.Next(0, this.equipos.Count)];//elijo un equipo al azar
                    equipo2 = this.equipos[random.Next(0, this.equipos.Count)];

                }while(equipo1 == equipo2);
                
                return CalcularPartido(equipo1,equipo2);
            }
        }

    }
}
