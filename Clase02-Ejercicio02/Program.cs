using System;

/*
 * Realizar un programa que sume números enteros hasta que el usuario lo determine por medio de un mensaje "¿Desea continuar? (S/N)".

Crear la clase Validador y el método estático ValidarRespuesta, que validará el ingreso de respuestas.

El método devolverá un valor de tipo booleano, TRUE si se ingresó una 'S' y FALSE si se ingresó cualquier otro valor.*/

namespace Clase02_Ejercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            string numeroIngresado;
            bool flag = false;
            bool flagRespuesta = true;
            int acumulador = 0;
            string respuesta;


            do
            {
                Console.WriteLine("Ingrese numeros a sumar: ");

                numeroIngresado = Console.ReadLine();

                flag = int.TryParse(numeroIngresado, out numero);

                while (!flag)
                {
                    Console.WriteLine("Error,Ingrese un numero entre 1 y 10: ");

                    numeroIngresado = Console.ReadLine();

                    flag = int.TryParse(numeroIngresado, out numero);

                }
                acumulador += numero;

                Console.WriteLine("Desea continuar? s/n");

                respuesta = Console.ReadLine();

                flagRespuesta = Validador.ValidarRespuesta(respuesta);

            } while (flagRespuesta);

            Console.WriteLine("Suma total : {0}", acumulador);
        }
    }
}