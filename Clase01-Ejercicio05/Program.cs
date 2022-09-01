using System;
/*
 * Un centro numérico es un número que separa una lista de números enteros (comenzando en 1) en dos grupos de números, cuyas sumas son iguales.

El primer centro numérico es el 6, el cual separa la lista (1 a 8) en los grupos: (1; 2; 3; 4; 5) y (7; 8) cuyas sumas son ambas iguales a 15. El segundo centro numérico es el 35, 
el cual separa la lista (1 a 49) en los grupos: (1 a 34) y (36 a 49) cuyas sumas son ambas iguales a 595.

Se pide elaborar una aplicación que calcule los centros numéricos entre 1 y el número que el usuario ingrese por consola.
*/

namespace Clase01_Ejercicio05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            string? numeroIngresado;
            int acumulador1 = 0;
            int acumulador2 = 0;
            bool flag = false;

            Console.WriteLine("Ingrese un numero mayor a 1: ");

            numeroIngresado = Console.ReadLine();

            flag = int.TryParse(numeroIngresado, out numero);

            while (!flag && numero < 2)
            {
                Console.WriteLine("Error,Ingrese un numero: ");

                numeroIngresado = Console.ReadLine();

                flag = int.TryParse(numeroIngresado, out numero);
            }

            for(int i = 1;i < numero;i++)
            {
                acumulador1+=i;

                for(int j = numero;j>= 1;j--)
                {
                    acumulador2 += j;
                    numero--;
                }
               
                    
                
            }

        }

    }
}
