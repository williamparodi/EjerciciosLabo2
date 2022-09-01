using System;

namespace Clase02_Ejercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            string numeroIngresado;
            bool flag = false;
            bool numeroValido = false;
            int min = -100;
            int max = 100;
            int numeroMinimo = 0;
            int numeroMaximo = 0;
            int acumulador = 0;
            double promedio;


            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("Ingrese un numero entre -100 y 100: ");

                numeroIngresado = Console.ReadLine();

                flag = int.TryParse(numeroIngresado, out numero);

                numeroValido = ValidarRango.Validar(numero, min, max);

                while (!flag || !numeroValido)
                {
                    Console.WriteLine("Error,Ingrese un numero entre 1 y 10: ");

                    numeroIngresado = Console.ReadLine();

                    flag = int.TryParse(numeroIngresado, out numero);

                    numeroValido = ValidarRango.Validar(numero, min, max);
                }

                if(i == 0)
                {
                    numeroMinimo = numero;
                    numeroMaximo = numero;
                }

                if(numero > numeroMaximo)
                {
                    numeroMaximo = numero;
                }
                else if(numero < numeroMinimo)
                {
                    numeroMinimo = numero;
                }
                acumulador += numero;

            }

            promedio = acumulador / 10;

            Console.WriteLine("El numero menor es : {0}", numeroMinimo);
            Console.WriteLine("El numero maximo es : {0}", numeroMaximo);
            Console.WriteLine("El promedio es : {0}", numeroMinimo);
        }
    }
}
