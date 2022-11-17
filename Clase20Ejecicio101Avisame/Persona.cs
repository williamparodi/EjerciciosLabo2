using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase20Ejecicio101Avisame
{
    public delegate void DelegadoString(string str);// des esta manera estoy en el namespace y lo puedo llamar de todos lados
    
    public class Persona
    {
        private string nombre;
        private string apellido;
        public event DelegadoString EventoString;
        public Persona()
        {
            this.nombre = "";
            this.apellido = "";
        }

        public string Nombre
        {
            get { return nombre; }
            set 
            {
                if(EventoString is not null)
                {
                    nombre = value;
                    EventoString("Se cambio el nombre a : " + nombre);// llamo al evento para informar q se cambio 
                }
             
            }
        }

        public string Apellido
        {
            get { return apellido; }
            set
            {
                if(EventoString is not null)
                {
                    apellido = value;
                    EventoString("Se cambio el nombre a : " + apellido);
                }
            }
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{nombre} {apellido}");
            return sb.ToString();
        }


        

    }
}
