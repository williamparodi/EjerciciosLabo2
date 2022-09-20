using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Negocio
    {
        private EPuesto caja;
        private Queue<Cliente> clientes;
        private string nombre;

        private Negocio()
        {
            this.caja = EPuesto.caja1;
            this.clientes = new Queue<Cliente>();
        }

        public Negocio(string nombre):this()
        {
            this.nombre = nombre;
        }

        public Cliente Cliente
        {
            get
            {
                return this.clientes.Peek();
            }
            set
            {
               if()
               {
                    
               }
            }
            
        }

        public static bool operator == (Negocio n,Cliente c)
        {
            bool retorno = false;
            foreach(Cliente item in n.clientes)
            {
                if(c == item)
                {
                    retorno = true;
                }
            }
            return retorno;
        }

        public static bool operator !=(Negocio n,Cliente c)
        {
            return !(n == c);
        }

        public static bool operator ~(Negocio n)
        {
            
        }


    }
}
