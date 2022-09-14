using System;

namespace Clase06_Ejercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arrayNumeros = new int[20];
            Random rnd = new Random();

            for(int i = 0; i < arrayNumeros.Length; i++)
            {
                arrayNumeros[i] = rnd.Next(-100,100);
                Console.WriteLine($"Numeros orignales : {arrayNumeros[i]}");
            }


            

            
            
        }

    
    }
}
