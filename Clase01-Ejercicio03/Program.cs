using System;

namespace Clase01_Ejercicio03
{
    /*
     * Mostrar por pantalla todos los números primos que haya hasta el número que ingrese el usuario por consola.

    Validar que el dato ingresado por el usuario sea un número.

    Volver a pedir el dato hasta que sea válido o el usuario ingrese "salir".

    Si ingresa "salir", cerrar la consola.

    Al finalizar, preguntar al usuario si desea volver a operar. Si la respuesta es afirmativa, iterar. De lo contrario, cerrar la consola.
    */
    internal class Program
    {
        static void Main(string[] args)
        {
            double numero;
            string numeroIngresado;
            string respuesta = "si";
            bool flag = true;
            int contador = 0;

            do
            {
                Console.WriteLine("Ingrese un numero: ");

                numeroIngresado = Console.ReadLine();

                flag = double.TryParse(numeroIngresado, out numero);
                while(!flag)
                {
                    Console.WriteLine("Error,vuelva a ingresar numero: ");

                    numeroIngresado = Console.ReadLine();

                    flag = double.TryParse(numeroIngresado, out numero);
                }

                if(numero > 1)
                {
                    for (int i = 2; i <= numero;i++)
                    {
                       contador = 0;
                      if(i % 2 == 0 || i % 3 == 0)
                      {
                            contador++;
                      }
                      if(contador == 2)
                      {
                          Console.WriteLine("{0}", i);
                      }
                      
                    }

                    Console.WriteLine("Escriba salir para terminar o pulse cualquier tecla para continuar");

                    respuesta = Console.ReadLine();
         
                }
               
            } while (respuesta != "salir");
            

            

           


        }
    }
}
