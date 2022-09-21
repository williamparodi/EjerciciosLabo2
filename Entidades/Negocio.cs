using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Negocio
    {
        private PuestoAtencion caja;
        private Queue<Cliente> clientes;
        private string nombre;

        private Negocio()
        {
            this.caja = new PuestoAtencion(EPuesto.caja1);
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
                return this.clientes.Dequeue();///retorno el cliente a atender(osea el primero)
            }
            set
            {
               if(!this.clientes.Contains(Cliente))
               {
                  clientes.Enqueue(Cliente);  
               }
            }
            
        }

        public static bool operator ==(Negocio n, Cliente c)
        {
            bool retorno = false;
            foreach (Cliente item in n.clientes)
            {
                if (c == item)
                {
                    retorno = true;
                }
            }
            return retorno;
        }

        public static bool operator !=(Negocio n, Cliente c)
        {
            return !(n == c);
        }

        public static bool operator +(Negocio n,Cliente c)
        {
            bool retorno = false;
            
            if(n != c)
            {
                n.clientes.Enqueue(c);// si el cliente no esta lo agrega al final de la cola
                retorno = true;
            }

            return retorno;
        }

        public static bool operator ~(Negocio n)
        {
            bool retorno = false;

            if (n.clientes.Count >0)// Si hay mas clientes sigo atendiendo
            {
                retorno = n.caja.Atender(n.Cliente);
            }

            return retorno;
        }

        public int ClientesPendientes
        {
            get { return this.clientes.Count; }
        }

    }
}
