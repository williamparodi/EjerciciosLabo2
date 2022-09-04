using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Dolar
    {
        private double cantidad;
        private static double cotzRespectoDolar;

        private Dolar()
        {
            Dolar.cotzRespectoDolar = 1;
        }

        public Dolar(double cantidad) : this()
        {
            this.cantidad = cantidad;
        }

        public Dolar(double cantidad, double cotizacion) :this(cantidad)
        {
            Dolar.cotzRespectoDolar = cotizacion;
        }
        public double GetCantidad()
        {
            return this.cantidad;
        }

        public static double GetCotizacion()
        {
            return Dolar.cotzRespectoDolar;
        }

        //Sobrecarga implicitas
        public static implicit operator Dolar(double d)
        {
            return new Dolar (d);
        }

        // Sobrecargas Explicitas para Peso y Euro
        public static explicit operator Euro(Dolar d)
        {
            return new Euro(d.cantidad * Euro.GetCotizacion());
        }

        public static explicit operator Peso(Dolar d)
        {
            return new Peso(d.cantidad * Peso.GetCotizacion());
        }
        
        //Sobrecarga de operadores
        public static bool operator ==(Dolar d1, Dolar d2)
        {
            return (d1.cantidad == d2.cantidad);
        }

        public static bool operator !=(Dolar d1, Dolar d2)
        {
            return !(d1 == d2);// reutilzamos anterior
        }

        public static bool operator ==(Dolar d, Euro e)
        {
            return (d.cantidad == (Dolar)e.GetCantidad());// la cantidad de e la tranformo a Dolar y la comparo.
        }
        public static bool operator !=(Dolar d, Euro e)
        {
            return !(d == e);
        }

        public static bool operator ==(Dolar d, Peso p)
        {
            return (d.cantidad == (Dolar)p.GetCantidad());
        }

        public static bool operator !=(Dolar d, Peso p)
        {
            return !(d == p);
        }

        public static Dolar operator -(Dolar d , Euro e)
        {
            return new Dolar(d.cantidad - e.GetCantidad());
        }

        public static Dolar operator -(Dolar d, Peso p)
        {
            return new Dolar(d.cantidad - p.GetCantidad());
        }

        public static Dolar operator +(Dolar d, Euro e)
        {
            return new Dolar(d.cantidad + e.GetCantidad());
        }

        public static Dolar operator +(Dolar d, Peso p)
        {
            return new Dolar(d.cantidad + p.GetCantidad());
        }

    }
}
