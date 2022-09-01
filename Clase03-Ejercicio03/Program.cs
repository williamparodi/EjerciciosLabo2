using System;
using Entidades;

namespace Clase03_Ejercicio03
{
    public class Program
    {
        static void Main(string[] args)
        {
            Estudiante estudiante1 = new Estudiante("Pablo", "Rizzotto", "12345");
            Estudiante estudiante2 = new Estudiante("Belen", "Mazzatari", "789345");
            Estudiante estudiante3 = new Estudiante("Lalo", "Ortiz", "56625");

            estudiante1.SetNotaPrimerParcial(6);
            estudiante1.SetNotaSegundoParcial(10);
            estudiante2.SetNotaPrimerParcial(8);
            estudiante2.SetNotaSegundoParcial(9);
            estudiante3.SetNotaPrimerParcial(4);
            estudiante3.SetNotaSegundoParcial(3);

            Console.WriteLine(estudiante1.Mostrar());
            Console.WriteLine(estudiante2.Mostrar());
            Console.WriteLine(estudiante3.Mostrar());
        }   
    }
}
