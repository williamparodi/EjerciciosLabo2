using System;

namespace AnotacionDeEjeSelloClase
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Sello.mensaje = "hola mundo";
            Sello.color = ConsoleColor.Red;
            Sello.ImprimirEnColor();
            Sello.Imprimir();
        }
    }
}
