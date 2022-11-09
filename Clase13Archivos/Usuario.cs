using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase13Archivos
{
    public class Usuario
    {
        public string nombre;
        public int edad;
        public string descripcion;

        public Usuario()
        {

        }

        public Usuario(string nombre,int edad,string descripcion)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.descripcion = descripcion;
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public int Edad
        {
            get { return edad; }
            set { edad = value; }   
        }

    }
}
