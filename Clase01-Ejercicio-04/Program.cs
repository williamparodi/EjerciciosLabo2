using System;
/*
Un número perfecto es un entero positivo, que es igual a la suma de todos los enteros positivos (excluido el mismo) que son divisores del número.

El primer número perfecto es 6, ya que los divisores de 6 son 1, 2 y 3; y 1 + 2 + 3 = 6.

Escribir una aplicación que encuentre los 4 primeros números perfectos.
*/

namespace Clase01_Ejercicio04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int acumulador = 0;
            int contador = 0;

            for (numero = 1; contador != 4; numero++)
            {
                for (int j = 1; j < numero; j++)
                {
                    if (numero % j == 0)// mientras sea divisible se suman
                    {
                        acumulador += j;
                    }
                   
                }
                if (acumulador == numero)
                {
                    Console.WriteLine("Es numero perfecto {0}", numero);
                    contador++;
                }
                acumulador = 0;
            }

        }
    }
}
