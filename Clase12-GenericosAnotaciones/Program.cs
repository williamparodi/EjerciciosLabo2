using System;

namespace Clase12_GenericosAnotaciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MiClase<string> miClase = new MiClase<string>();
            
            MiClase<float> miClase2 = new MiClase<float>();//el dato T va a ser flotante de la clase

            //ambas van a tener int de la clase y una un string y otra un float

            MiClase<MiClaseDato> miClase3 = new MiClase<MiClaseDato>();
        }
    }
}
