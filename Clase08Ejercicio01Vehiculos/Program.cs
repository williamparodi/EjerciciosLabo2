using System;
using Clase08Ejercicio01Herencia;

namespace Clase08Ejercicio01Vehiculos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Camion camion = new Camion(8, 2, EColores.Rojo,5,65555);
            Moto moto = new Moto(2,0,EColores.Azul,150);
            Automovil auto = new Automovil(4, 5, EColores.Gris, 6, 5);

            Console.WriteLine(camion.MostrarCamion());
            //Console.WriteLine($"El camion: Cantidad de ruedas{}, Cantidad de puertas {}, Color{},Cantidad de Marchas{},Peso {}");
        }
    }
}
