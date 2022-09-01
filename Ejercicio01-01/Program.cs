using System;

namespace Ejercicio01_01
{

    /*
     * Ingresar 5 números por consola, guardándolos en una variable escalar. Luego calcular y mostrar: el valor máximo, el valor mínimo y el promedio.
     * */

    internal class Program
    {
        static void Main(string[] args)
        {
            string numeroIngresado;
            int numero = 0;
            int numeroMaximo; // puedo inicializar los maximos y minimo para que me lo tome en el for
            int numeroMinimo;
            int acumulador = 0;
            float promedio;

            numeroMaximo = numero;
            numeroMinimo = numero;

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ingrese un numero: ");

                numeroIngresado = Console.ReadLine();

                numero = int.Parse(numeroIngresado);
                if (i == 0)
                {
                    numeroMaximo = numero;
                    numeroMinimo = numero;
                }
                else if (numero > numeroMaximo)
                {
                    numeroMaximo = numero;
                }
                else if (numero < numeroMinimo)
                {
                    numeroMinimo = numero;
                }

                acumulador += numero;
            }

            promedio = (float)acumulador / 5;

            Console.WriteLine("El numero maximo es : {0} , el numero minimo {1} y el promedio {2}", numeroMaximo, numeroMinimo, promedio);
        }
    }
}
