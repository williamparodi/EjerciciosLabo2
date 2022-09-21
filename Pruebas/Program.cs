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

        }


    }
}
