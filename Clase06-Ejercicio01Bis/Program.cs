using System;

namespace Clase06_Ejercicio01Bis
{
    internal class Program
    {
        /*Crear una aplicación de consola que cargue 20 números enteros(positivos y negativos) distintos de cero de forma aleatoria utilizando la clase Random.
            Mostrar el vector tal como fue ingresado.
            Luego mostrar los positivos ordenados en forma decreciente.
            Por último, mostrar los negativos ordenados en forma creciente.*/
        //Forma 2:
        static void Main(string[] args)
        {
            int[] arrayNumeros = new int[20];
            Random rnd = new Random();

            Console.WriteLine($"Numeros orignales: ");
            for (int i = 0; i < arrayNumeros.Length; i++)
            {
                arrayNumeros[i] = rnd.Next(-100, 100);
                Console.WriteLine(arrayNumeros[i]);
            }

            Array.Sort(arrayNumeros);//Los muestro de menor a mayor Ejemplo : -12 es menor que -5
            Console.WriteLine($"Numeros negativos ordendos crecientemente:");
            for(int i = 0; i < arrayNumeros.Length; i++)
            {
                if(arrayNumeros[i] < 0)
                {
                    Console.WriteLine(arrayNumeros[i]);
                }
            }

            Array.Reverse(arrayNumeros);
            Console.WriteLine($"Numeros positivos ordendos decrecientemente:");
            for (int i = 0; i < arrayNumeros.Length; i++)
            {
                if (arrayNumeros[i] > 0)
                {
                    Console.WriteLine(arrayNumeros[i]);
                }
            }

        }
    }
}
