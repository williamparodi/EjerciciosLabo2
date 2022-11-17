using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaEjercicioIntergrador;

namespace Pruebas
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            List<string> listaPersonas = new List<string>();
            string nombrePersona1 = "Pepe";
            string nombrePersona2 = "Alberto";
            string nombrePersona3 = "Morrissey";
            string nombrePersona4 = "Pablo";
            
            listaPersonas.Add(nombrePersona1);
            listaPersonas.Add(nombrePersona2);
            listaPersonas.Add(nombrePersona3);
            listaPersonas.Add(nombrePersona4);

            if(listaPersonas.Count > 0)
            {
                if(listaPersonas.Contains("Morrissey"))
                {
                    Console.WriteLine("Hay un famoso groso");
                }
                else
                {
                    Console.WriteLine("Morrissey no aparace");
                }

              
            }
            // Parar saber sistema operativo y caracteristicas
            Console.WriteLine("Cantidad de procesadores lógicos: {0}", Environment.ProcessorCount);
            Console.WriteLine("¿Tiene arquitectura de 64 bits?: {0}", Environment.Is64BitOperatingSystem);
            Console.WriteLine("Usuario: {0}", Environment.UserName);
            Console.WriteLine("Primera línea {0} Segunda Línea", Environment.NewLine);
            Console.WriteLine("OSVersion: {0}", Environment.OSVersion);
            Console.WriteLine("OSVersion.Platform: {0}", Environment.OSVersion.Platform);
            Console.WriteLine("OSVersion.Version: {0}", Environment.OSVersion.Version);

        }


    }
}
