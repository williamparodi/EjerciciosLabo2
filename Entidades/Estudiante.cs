using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Estudiante
    {
        public string nombre;
        public string apellido; 
        public string legajo;
        public int notaPrimerParcial;
        public int notaSegundoParcial;
        public static Random random;

        static Estudiante()
        {
            Estudiante.random = new Random(); // constructor de instancia
        }

        public Estudiante(string nombre, string apellido, string legajo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.legajo = legajo;
        }

        public void SetNotaPrimerParcial(int nota)
        {
            this.notaPrimerParcial = nota;
        }

        public void SetNotaSegundoParcial(int nota)
        {
            this.notaSegundoParcial = nota;
        }

        private float CalcularPromedio()
        {
            float promedio = 0;
            promedio = (this.notaSegundoParcial + this.notaPrimerParcial) / 2;
            return promedio;
        }

        public double CalcularNotaFinal()
        {
            double notaFinal = -1;

            if(this.notaPrimerParcial >= 4 && this.notaSegundoParcial >= 4)
            {
                notaFinal = Estudiante.random.Next(6, 10);
            }

            return notaFinal;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            float promedio = CalcularPromedio();
            double notaFinal = CalcularNotaFinal();
            sb.Append("Nombre: ");
            sb.AppendLine(this.nombre);
            sb.Append("Apellido: ");
            sb.AppendLine(this.apellido);
            sb.Append("Legajo : ");
            sb.AppendLine(this.legajo);
            sb.Append("Nota primer parcial: ");
            sb.AppendLine(this.notaPrimerParcial.ToString());
            sb.Append("Nota segundo Parcial: ");
            sb.AppendLine(this.notaSegundoParcial.ToString());
            sb.Append("Promedio : ");
            sb.AppendLine(promedio.ToString());

            if(notaFinal != -1)
            {
                sb.Append("Nota Final: ");
                sb.AppendLine(notaFinal.ToString());
            }
            else
            {
                sb.Append("Almunno desaprobado");
            }

            return sb.ToString();
        }


    }
}
