using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cliente
    {
        private string nombre;
        private int numero;

        public Cliente(int numero)
        {
            this.numero = numero;
        }

        public Cliente(int numero, string nombre) :this(numero)
        {
            this.nombre = nombre;
        }

        public int Numero//Propiedad
        {
            get
            {
                return numero;
            }
        }

        public string Nombre//Propiedad 
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
            }
        }

        public static bool operator ==(Cliente c1, Cliente c2)
        {
            return c1.numero == c2.numero;
        }

        public static bool operator !=(Cliente c1, Cliente c2)
        {
            return !(c1 == c2);
        }

        

    }
}
