using BibliotecaEjercicioClase12;
using System;
using System.Collections.Generic;

namespace Clase12EjercicioTorneo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EquipoFutbol equipoFutbol1 = new EquipoFutbol("Gamorra",DateTime.Now);
            EquipoFutbol equipoFutbol2 = new EquipoFutbol("Los Pepe", DateTime.Now);
            EquipoFutbol equipoFutbol3 = new EquipoFutbol("Los Lambda", DateTime.Now);
            EquipoFutbol equipoFutbol4 = new EquipoFutbol("Chelsea", DateTime.Now);

            EquipoBasquet equipoBasquet1 = new EquipoBasquet("Lakers", DateTime.Now);
            EquipoBasquet equipoBasquet2 = new EquipoBasquet("NBA JAM", DateTime.Now);
            EquipoBasquet equipoBasquet3 = new EquipoBasquet("Los Altos", DateTime.Now);
            EquipoBasquet equipoBasquet4 = new EquipoBasquet("Los Donald Thrump", DateTime.Now);

            List<EquipoBasquet> listaEquiposBasquet = new List<EquipoBasquet>();
            List<EquipoFutbol> listaEquiposFutbol = new List<EquipoFutbol>();

            listaEquiposBasquet.Add(equipoBasquet1);
            listaEquiposBasquet.Add(equipoBasquet2);
            listaEquiposBasquet.Add(equipoBasquet3);
            listaEquiposBasquet.Add(equipoBasquet4);

            listaEquiposFutbol.Add(equipoFutbol1);
            listaEquiposFutbol.Add(equipoFutbol2);
            listaEquiposFutbol.Add(equipoFutbol3);
            listaEquiposFutbol.Add(equipoFutbol4);

            Torneo<EquipoBasquet> torneoBasquet = new Torneo<EquipoBasquet>(listaEquiposBasquet, "Torneo 2022 de Basquet");
            Torneo<EquipoFutbol> torneoFutbol = new Torneo<EquipoFutbol>(listaEquiposFutbol, "Tornedo 2022 de Futbol");

            Console.WriteLine(torneoBasquet.Mostrar(torneoBasquet));
            Console.WriteLine(torneoBasquet.JugarPartido);
            Console.WriteLine(torneoBasquet.JugarPartido);
            Console.WriteLine(torneoBasquet.JugarPartido);


            Console.WriteLine(torneoFutbol.Mostrar(torneoFutbol));
            Console.WriteLine(torneoFutbol.JugarPartido);
            Console.WriteLine(torneoFutbol.JugarPartido);
            Console.WriteLine(torneoFutbol.JugarPartido);
            Console.WriteLine(torneoFutbol.JugarPartido);

        }
    }
}
