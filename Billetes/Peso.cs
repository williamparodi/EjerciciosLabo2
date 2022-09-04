using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Peso
    {
        private double cantidad;
        private static double cotzRespectoDolar;

        private Peso()
        {
            Peso.cotzRespectoDolar = 102.65;
        }

        public Peso(double cantidad) : this()
        { 
            this.cantidad = cantidad;
        }

        public Peso(double cantidad, double cotizacion) : this(cantidad)
        {
            Peso.cotzRespectoDolar = cotizacion;
        }

        public double GetCantidad()
        {
            return this.cantidad;
        }

        public static double GetCotizacion()
        {
            return Peso.cotzRespectoDolar;
        }

        public static implicit operator Peso(double p)
        {
            return new Peso(p);
        }
        // Sobrecarga explicita de Euro y Dolar
        public static explicit operator Dolar(Peso p)
        {
            return new Dolar(p.cantidad / Peso.GetCotizacion());
        }

        public static explicit operator Euro(Peso p)
        {
            return (Euro)((Dolar)p);// reutilizo la conversion anterior, De peso a dolar y este resultado a Euro
        }

        public static bool operator == (Peso p1, Peso p2)
        {
            return (p1.cantidad == p2.cantidad);
        }

        public static bool operator !=(Peso p1, Peso p2)
        {
            return !(p1.cantidad == p2.cantidad);
        }

        public static bool operator ==(Peso p, Euro e)
        {
            return (p.cantidad == (Peso)e.GetCantidad());
        }
        public static bool operator !=(Peso p, Euro e)
        {
            return !(p.cantidad == (Peso)e.GetCantidad());
        }

        public static bool operator ==(Peso p, Dolar d)
        {   
            return (p.cantidad == (Peso)d.GetCantidad());
        }

        public static bool operator !=(Peso p, Dolar d)
        {
            return !(p.cantidad == (Peso)d.GetCantidad());
        }

        public static Peso operator +(Peso p, Euro e)
        {
            return new Peso(p.cantidad + e.GetCantidad());
        }

        public static Peso operator +(Peso p, Dolar d)
        {
            return new Peso(p.cantidad + d.GetCantidad());
        }

        public static Peso operator -(Peso p, Euro e)
        {
            return new Peso(p.cantidad - e.GetCantidad());
        }

        public static Peso operator -(Peso p, Dolar d)
        {
            return new Peso(p.cantidad - d.GetCantidad());
        }
    }
}
