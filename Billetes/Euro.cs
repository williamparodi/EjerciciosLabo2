using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Euro
    {
        private double cantidad;
        private static double cotzRespectoDolar;

        private Euro()
        {
            Euro.cotzRespectoDolar = 1.17;
        }

        public Euro(double cantidad) : this()
        {
            this.cantidad = cantidad;
        }

        public Euro(double cantidad,double cotizacion) : this (cantidad)
        {
            Euro.cotzRespectoDolar = cotizacion;
        }

        public double GetCantidad()
        {
            return this.cantidad;
        }

        public static double GetCotizacion()
        {
            return Euro.cotzRespectoDolar;
        }

        public static implicit operator Euro(double e)
        {
            return new Euro(e); 
        }

        public static explicit operator Dolar(Euro e)
        {
            return new Dolar(e.cantidad / Euro.GetCotizacion());
        }

        public static explicit operator Peso(Euro e)
        {
            return (Peso)((Dolar)e);// reutilizo las anteriores conversion anterior hace lo mismo pero pasa Peso
        }

        public static bool operator !=(Euro e1,Euro e2)
        {
            return !(e1 == e2);
        }

        public static bool operator ==(Euro e1, Euro e2)
        {
            return (e1.cantidad == e2.cantidad);
        }

        public static bool operator !=(Euro e,Dolar d)
        {
            return !(e == d);
        }

        public static bool operator ==(Euro e, Dolar d)
        {
            return (e.cantidad == (Euro)d.GetCantidad());
        }

        public static bool operator !=(Euro e, Peso p)
        {
            return !(e == p);
        }

        public static bool operator ==(Euro e, Peso p)
        {
            return (e.cantidad == (Euro)p.GetCantidad());
        }

        public static Euro operator +(Euro e, Dolar d)
        {
            return new Euro(e.cantidad + d.GetCantidad());
        }

        public static Euro operator +(Euro e, Peso p)
        {
            return new Euro(e.cantidad + p.GetCantidad());
        }

        public static Euro operator -(Euro e, Dolar d)
        {
            return new Euro(e.cantidad - d.GetCantidad());
        }

        public static Euro operator -(Euro e, Peso p)
        {
            return new Euro(e.cantidad - p.GetCantidad());
        }







    }
}
