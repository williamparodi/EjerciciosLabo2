using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Persona
    {
        public string nombre;
        public string fechaNacimiento;
        public double dni;
        public static int edad;//Atributo estatico
        public Persona()
        {
            this.nombre = "Sin Nombre";
            this.fechaNacimiento = "dd/mm/aaaa";
            this.dni = 0.00;
        }
        static Persona()
        {
            Persona.edad = 0;
        }
        public Persona(string nombre, string fechaNacimiento,double dni)
        {
            this.nombre = nombre;
            this.fechaNacimiento = fechaNacimiento;
            this.dni = dni;
        }

        public string GetNombre()
        {
            return this.nombre;
        }

        public string GetFechaNacimiento()
        {
            return this.fechaNacimiento;
        }

        public double GetDni()
        {
            return this.dni;
        }

        private int CalcularEdad()
        {
            DateTime fechaNacimientoDate = DateTime.ParseExact(this.fechaNacimiento, "dd/MM/yyyy", null);// creo un datatime y parseo la fecha de nacimiento al formato indicado

            DateTime fechaActual = DateTime.Now; //consigo la fecha actual

            Persona.edad = fechaActual.Year - fechaNacimientoDate.Year;// resto la fecha actual con la fecha de nacimiento

            return Persona.edad;
        }

        public string Mostrar()
        {
            /*
            StringBuilder sb = new StringBuilder();
            Persona.edad = CalcularEdad();
            string nombre = GetNombre();
            string fechaNacimiento = GetFechaNacimiento();
            double dni = GetDni();
            sb.Append("Nombre: ");
            sb.AppendLine(this.nombre);
            sb.Append("Fecha de nacimiento: ");
            sb.AppendLine(this.fechaNacimiento);
            sb.Append("Dni: ");
            sb.AppendLine(this.dni.ToString());
            sb.Append("Edad actual:");
            sb.AppendLine(Persona.edad.ToString());
            return sb.ToString();
            */

            StringBuilder sb = new StringBuilder();
            Persona.edad = CalcularEdad();
            string nombre = GetNombre();
            string fechaNacimiento = GetFechaNacimiento();
            double dni = GetDni();
            sb.Append("Nombre: ");
            sb.AppendLine(nombre);
            sb.Append("Fecha de nacimiento: ");
            sb.AppendLine(fechaNacimiento);
            sb.Append("Dni: ");
            sb.AppendLine(dni.ToString());
            sb.Append("Edad actual:");
            sb.AppendLine(Persona.edad.ToString());
            return sb.ToString();
        }

        public string EsMayorDeEdad()
        {
            string mayorOmenor;
            if (Persona.edad > 17)
            {
                mayorOmenor = "Es mayor";
            }
            else
            {
                mayorOmenor = "Es menor";
            }
            return mayorOmenor;
        }
    }
}
