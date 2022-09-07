using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConversorBinario
{
    public class NumeroBinario
    {
        public string numero;

        private NumeroBinario(string numero)
        {
            this.numero = numero;
        }

        public string GetBinario()
        {
            return this.numero;
        }

        public  double ConvertirBinarioADecimal(string numeroEntero)
        {
            double numeroBinario = 0;

            numeroEntero = InvierteTexto(numeroEntero);

            for (int i = 0; i < numeroEntero.Length; i++)
            {
                if (numeroEntero[i] == '1')
                {
                    numeroBinario += (int)Math.Pow(2, i);
                }
            }

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

        public static implicit operator NumeroBinario(string b)
        {
            return new NumeroBinario(b);
        }

        public static explicit operator string (NumeroBinario b)
        {
            return b.numero;
        }
        
        public static explicit operator NumeroDecimal(NumeroBinario b)
        {
            return (NumeroDecimal)b.ConvertirBinarioADecimal(b.numero);
        }

        public static bool operator ==(NumeroBinario b,NumeroDecimal d)
        {
            return (b.numero == ((NumeroBinario)d).numero);
        }

        public static bool operator !=(NumeroBinario b, NumeroDecimal d)
        {
            return !(b == d);
        }

        public static string operator +(NumeroBinario b, NumeroDecimal d)
        {
            return d.ConvertirDecimalABinario(((NumeroDecimal)b).numero + d.numero);
        }

        public static string operator -(NumeroBinario b, NumeroDecimal d)
        {
            return d.ConvertirDecimalABinario(((NumeroDecimal)b).numero - d.numero);
        }

    }
}
