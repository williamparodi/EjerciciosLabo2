using Entidades;
using System;

namespace Clase13_Interfaz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ya no estoy atado a la herencia
            Persona2cs p = new Persona2cs(); 
            Leon l =  new Leon();
            Arana a = new Arana();
            string comida = "hamburguesa";

            Console.WriteLine(p.Cazador());
            Console.WriteLine(l.Cazador());
            Console.WriteLine(a.Cazador());

            Console.WriteLine(((ICarnivoro) l).Cazador());
            Console.WriteLine(l.Comer(comida));



        }
    }
}
