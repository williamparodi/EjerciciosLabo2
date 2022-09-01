using System;

namespace Ejercicio102
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double numero;
            double resultadoCuadrado;
            double resultadoCubo;
            string? numeroIngresado;//Net 6
            bool flag = false;

            Console.WriteLine("Ingrese numero: ");

            numeroIngresado = Console.ReadLine();

            flag = double.TryParse(numeroIngresado,out numero);
           
            if (numero <= 0 || flag == false)
            {
                Console.WriteLine("Numero erroneo");
            }
            else
            {
                resultadoCuadrado = Math.Pow(numero, 2);
                resultadoCubo = Math.Pow(numero, 3);

                Console.WriteLine("El numero ingresado al cuadrado es : {0} y el numero ingresado al Cubo es :{1}", resultadoCuadrado, resultadoCubo);
            }
        }
    }
}
