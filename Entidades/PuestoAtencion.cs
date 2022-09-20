using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

/*Clase PuestoAtencion
    El atributo numeroActual es estático y privado. Se inicializará en el constructor de clase (estático) con valor 0.
    El método Atender simulará un tiempo de atención a un cliente: recibirá un cliente, simulará un tiempo de atención mediante el método Sleep de la clase Thread (perteneciente al espacio de nombre System.Threading) 
    y retornará true para indicar el final de la atención.
    La propiedad estática NumeroActual es la encargada de incrementar en 1 al atributo numeroActual y luego retornarlo.
 */
namespace Entidades
{
   
    public class PuestoAtencion
    {
        private static int numeroActual;
        private EPuesto Puesto;

        private PuestoAtencion()
        {
            numeroActual = 0;
        }

        public PuestoAtencion(EPuesto puesto)
        {
            Puesto = puesto;
        }

        public static int NumeroActual//Propiedad
        {
            get
            {
                numeroActual++;
                return numeroActual;
            }
        }

        public bool Atender(Cliente cli)
        {
            bool retorno = false;

            if(cli != null)
            {
                Thread.Sleep(2000);
                retorno = true;
            }

            return retorno;
        }



    }
}
