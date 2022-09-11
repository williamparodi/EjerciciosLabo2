using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Ingresante
    {
        private string[] cursos;
        private string direccion;
        private int edad;
        private string genero;
        private string nombre;
        private string pais;

        public Ingresante(string nombre,string direccion,string genero,string pais,string[] cursos,int edad)
        { 
            this.nombre = nombre;
            this.direccion = direccion;
            this.genero = genero;
            this.pais = pais;
            this.cursos = cursos;
            this.edad = edad;
        }

        public string Mostrar() 
        {
            StringBuilder sb = new StringBuilder();
            int contador = 0;
            sb.AppendLine($"Nombre: {this.nombre} ");
            sb.AppendLine($"Dirección: {this.direccion} ");
            sb.AppendLine($"Edad: {this.edad} ");
            sb.AppendLine($"Genero: {this.genero}");
            sb.AppendLine($"País: {this.pais} ");
            sb.AppendLine($"Curso/s:");

            foreach(string curso in cursos)
            {
                if(curso != "")
                {
                    sb.AppendLine($"{curso}");
                    contador++;
                }
            }
            if(contador == 0)
            {
                sb.AppendLine("Ninguno");
            }
           
            return sb.ToString();
        }
    }
}
