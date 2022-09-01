using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cuenta
    {
        public string titular;
        public int cantidad;

        public Cuenta()
        {
            this.titular = "Sin razon social";
            this.cantidad = 0;
        }

        public Cuenta(string titular, int cantidad)
        {
            this.titular = titular;
            this.cantidad = cantidad;
        }


        //Getters
        public string GetterTitular()
        {
            return this.titular;
        }

        public int GetterCantidad()
        {
            return this.cantidad;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Nombre y razon social: ");
            sb.AppendLine(this.titular);
            sb.Append("Dinero en la cuenta: ");
            sb.AppendLine(this.cantidad.ToString());
            return sb.ToString();
        }

        public bool Ingresar(int cantidadIngresada)
        {
            bool retorno = false;
            int dineroEnCuenta = GetterCantidad();
            if(cantidad > 0)
            {
                dineroEnCuenta += cantidadIngresada;
                this.cantidad = dineroEnCuenta;
                retorno = true;
            }

            return retorno;
        }

        public bool Retirar(int montoAretirar)
        {
            bool retorno = false;
            int dineroEnCuenta = GetterCantidad();

            if (dineroEnCuenta > 0 && montoAretirar >0)
            {   
                dineroEnCuenta -= montoAretirar;
                this.cantidad = dineroEnCuenta;
                retorno = true;
            }

            return retorno;
        }

    }
}
