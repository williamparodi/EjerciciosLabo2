using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase14BaseDeDatos
{
    public class Empleado
    {
        public int id_puesto;
        public string nombre;
        public string aplellido;
        public double sueldo;


        public Empleado()
        {

        }

        public Empleado(string nombre,int id_puesto,double sueldo)
        {
            this.nombre = nombre;
            this.id_puesto = id_puesto;
            this.sueldo = sueldo;
        }

    }
}
