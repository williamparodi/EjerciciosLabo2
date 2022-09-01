using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase02_EjercicioSello2
{
    public static string mensaje;
    public static ConsoleColor color;
    private static 
    public static class Sello
    {
        public static string Imprimir()
        {
            return Sello.mensaje;
        }

        public static void ImprimirEnColor()
        {
            Console.ForegroundColor = Sello.color;
            Console.WriteLine(Sello.Imprimir());
            Console.ResetColor();
        }


    }
}
