using System;

namespace Clase09_Ejercicio01_Polimorfismo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Parte1
            Console.Title = "Ejercicio Sobre-Sobrescrito";
            Sobrescrito objetoSobrescrito = new Sobrescrito();
           
            Console.WriteLine(objetoSobrescrito.ToString());

            string objeto = "¡Este es mi método ToString sobrescrito!";

            Console.WriteLine("----------------------------------------------");
            Console.Write("Comparación Sobrecargas con String: ");
            Console.WriteLine(objetoSobrescrito.Equals(objeto));

            Console.WriteLine("----------------------------------------------");
            Console.WriteLine(objetoSobrescrito.GetHashCode());

            Console.ReadKey();
            */

            //Parte 2 
            Console.Title = "Ejercicio Sobre-Sobrescrito";
            Sobrescrito objetoSobrescrito = new SobreSobrescrito();

            Console.WriteLine(objetoSobrescrito.MiMetodo());

            string objeto = "¡Este es mi método ToString sobrescrito!";

            Console.WriteLine("----------------------------------------------");
            Console.Write("Comparación Sobrecargas con String: ");
            Console.WriteLine(objetoSobrescrito.Equals(objeto));

            Console.WriteLine("----------------------------------------------");
            Console.WriteLine(objetoSobrescrito.GetHashCode());

            Console.ReadKey();


        }
    }
}
