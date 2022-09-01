using System;

namespace Clase02_EjercicioSello2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Sello.mensaje = "hola mundo";


            Sello.color = ConsoleColor.Red;


            Sello.ImprimirEnColor();


            Sello.Imprimir();


            
        }
    }
}
