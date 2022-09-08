using System;
using Entidades;

namespace AnotacionesClase05_Repaso
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Empleado e1 = new Empleado("Pepe");
            Empleado e2 = new Empleado("Marcelo",1234,45320);
            

            Console.WriteLine(e1.Saludar(3));
            Console.WriteLine(e2 == e1);

        }

    }
}
