using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Clase02_EjercicioSello
{
    public static class Sello
    {
        public static string mensaje;
        public static ConsoleColor color;
        
        public static string Imprimir()
        {
            //return Sello.mensaje;
            return Sello.ArmarFormatoMensaje();
        }

        public static string Borrar()
        {
            Sello.mensaje = " ";
            return mensaje;
        }

        public static void ImprimirEnColor()
        {
            Console.ForegroundColor = Sello.color;
            Console.WriteLine(Sello.Imprimir());
            Console.ResetColor();
        }

        private static string ArmarFormatoMensaje()
        {
            string asterisco = "";

            for (int i = 0; i < Sello.mensaje.Length; i++)
            {
                asterisco = asterisco + "*";
            }
            return asterisco + "\n" + Sello.mensaje + "\n" + asterisco;
        }
    }
}
