using System;
using Entidades;

namespace AnotacionesClase07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hola h1 = new Hola();

            h1[2] = "jajaj";// piso el valor que tenia en el indice 2

            //h1[5] = "121"; no existe y por eso tira out of range

            Console.WriteLine(h1[0]);//Muestra "Buen Dia"
        }
    }
}
