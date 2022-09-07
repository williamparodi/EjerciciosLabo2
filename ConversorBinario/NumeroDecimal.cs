using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorBinario
{
    public class NumeroDecimal
    {
        public double numero;

        private NumeroDecimal(double numero)
        {
            this.numero = numero;
        }

        public double GetNumeroDecimal()
        {
            return this.numero;
        }

        public string ConvertirDecimalABinario(double numeroEntero)
        {

            string numeroBinario = "";

            for (int i = 0; numeroEntero > 0; i++)
            {
                if (numeroEntero % 2 != 0)
                {
                    numeroBinario = numeroBinario + "1";
                }
                else
                {
                    numeroBinario = numeroBinario + "0";

                }
                numeroEntero = numeroEntero / 2;
            }

            numeroBinario = InvierteTexto(numeroBinario);

            return numeroBinario;
        }

        private static string InvierteTexto(string texto)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = texto.Length - 1; i >= 0; i--)
            {
                sb.Append(texto[i]);
            }

            return sb.ToString();
        }

        public static implicit operator NumeroDecimal(double d)
        {
            return new NumeroDecimal(d);
        }

        public static explicit operator double (NumeroDecimal d)
        {
            return d.numero;
        }

        public static explicit operator NumeroBinario(NumeroDecimal d)
        {
            return (NumeroBinario)d.ConvertirDecimalABinario(d.numero);
        }

        public static bool operator == (NumeroDecimal d, NumeroBinario b)
        {
            return d.numero == ((NumeroDecimal)b).numero;
        }

        public static bool operator !=(NumeroDecimal d, NumeroBinario b)
        {
            return !(d.numero == ((NumeroDecimal)b).numero);
        }

        public static double operator +(NumeroDecimal d, NumeroBinario b)
        {
            return d.numero + ((NumeroDecimal)b).numero;
        }

        public static double operator -(NumeroDecimal d, NumeroBinario b)
        {
            return d.numero - ((NumeroDecimal)b).numero;
        }
    }
}
