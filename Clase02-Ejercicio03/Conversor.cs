using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase02_Ejercicio03
{
    public static class Conversor
    {
        public static string ConvertirDecimalABinario(int numeroEntero)
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

        public static int ConvertirBinarioADecimal(int numeroEntero)
        {
            int numeroBinario = 0;
            string numeroBinarioIngresado = " ";

            numeroBinarioIngresado = numeroEntero.ToString();
            numeroBinarioIngresado = InvierteTexto(numeroBinarioIngresado);

            for(int i =0; i < numeroBinarioIngresado.Length;i++ )
            {
                if(numeroBinarioIngresado[i] == '1')
                {
                    numeroBinario +=(int)Math.Pow(2, i); 
                }
            }

            return numeroBinario;
        }

        private static string InvierteTexto(string texto)
        {
            StringBuilder sb = new StringBuilder();

            for(int i = texto.Length - 1; i >=0 ; i--)
            {
                sb.Append(texto[i]);
            }

            return sb.ToString();
        }
    }
}
