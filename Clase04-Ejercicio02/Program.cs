using System;
using Billetes;

namespace Clase04_Ejercicio02
{
    //Cotizador
    public class Program
    {
        static void Main(string[] args)
        {
            Peso peso1 = 1;
            Euro euro1 = 1;
            Dolar dolar1 = 1;

            Peso dolaresConveritdosApesos = (Peso)dolar1;
            Euro dolaresConvertidosAeuros = (Euro)dolar1;
            Dolar pesosConvertidosAdolares = (Dolar)peso1;

            Dolar pesosMasEurosEndolares = (Dolar)peso1 + euro1;
            
            Console.WriteLine("Pesos: {0}",peso1.GetCantidad());
            Console.WriteLine("Euros: {0}", dolar1.GetCantidad());
            Console.WriteLine("Dolares: {0}", euro1.GetCantidad());
            Console.WriteLine("Cantidad de dolares convertidos a pesos: {0}",dolaresConveritdosApesos.GetCantidad());
            Console.WriteLine("Cantidad de dolares convertidos a euros: {0}", dolaresConvertidosAeuros.GetCantidad());
            Console.WriteLine("Cantidad de pesos convertidos a dolares: {0}", pesosConvertidosAdolares.GetCantidad());
            Console.Write("Suma de {0} pesos y {1} euros ", peso1.GetCantidad(), euro1.GetCantidad());
            Console.Write("Son: {0} Dolares", pesosMasEurosEndolares.GetCantidad());




        }
    }
}
