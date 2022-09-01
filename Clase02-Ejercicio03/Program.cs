using System;

/*Desarollar una clase llamada Conversor que posea dos métodos de clase (estáticos):

El método ConvertirDecimalABinario que convierte un número entero del sistema decimal al sistema binario.

public string ConvertirDecimalABinario(int numeroEntero) {}

El método ConvertirBinarioADecimal que convierte un número entero del sistema binario al sistema decimal.

public int ConvertirBinarioADecimal(int numeroEntero) {}
*/

namespace Clase02_Ejercicio03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string numeroIngresado;
            int numero;
            bool flag = false;
            string numeroBinario;

            Console.WriteLine("Ingrese un numero:");

            numeroIngresado = Console.ReadLine();

            flag = int.TryParse(numeroIngresado, out numero);

            while(!flag)
            {
                Console.WriteLine("Error,Ingrese un numero:");

                numeroIngresado = Console.ReadLine();

                flag = int.TryParse(numeroIngresado, out numero);
            }

            numeroBinario = Conversor.ConvertirDecimalABinario(numero);

            Console.WriteLine("El numero ingresado {0} pasado a binario es: {1}",numero, numeroBinario);
        }
    }
}
