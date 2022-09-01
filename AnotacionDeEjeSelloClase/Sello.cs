using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnotacionDeEjeSelloClase
{
    public class Sello
    {
        public static string mensaje;
        public static ConsoleColor color;

        public static string Imprimir()
        {
            return Sello.ArmarFormatoMensaje();
        }

        public static void Borrar()
        {
            Sello.mensaje = "";
        }

        public static void ImprimirEnColor()
        {
            Console.ForegroundColor = Sello.color;
            Console.WriteLine(Sello.Imprimir());
        }

        private static string ArmarFormatoMensaje()
        {
            StringBuilder sb = new StringBuilder("");
            foreach (char c in Sello.mensaje)
            {
                sb.Append("*");
            }
            sb.AppendLine("**");
            sb.AppendFormat("*" + Sello.mensaje + "*\n");
            foreach (char c in Sello.mensaje)
            {
                sb.Append("*");
            }
            sb.AppendLine("**");
            return sb.ToString();
        }


    }
}
