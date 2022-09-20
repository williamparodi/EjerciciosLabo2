using System;

namespace Clase06_Ejercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Crear una aplicación de consola que cargue 20 números enteros(positivos y negativos) distintos de cero de forma aleatoria utilizando la clase Random.

            Mostrar el vector tal como fue ingresado.
            Luego mostrar los positivos ordenados en forma decreciente.
            Por último, mostrar los negativos ordenados en forma creciente.*/

            //Forma 1:

            int[] arrayNumeros = new int[20];
            Random rnd = new Random();

            Console.WriteLine($"Numeros orignales: ");
            for (int i = 0; i < arrayNumeros.Length; i++)
            {
                arrayNumeros[i] = rnd.Next(-100,100);
                Console.WriteLine(arrayNumeros[i]);
            }

            SortDecreciente(arrayNumeros);
            Console.WriteLine("Numeros positivos en forma decreciente:");
            for(int i = 0;i< arrayNumeros.Length;i++)
            {
                if (arrayNumeros[i] > 0)
                {
                    Console.WriteLine(arrayNumeros[i]);
                }
            }

            SortDecreciente(arrayNumeros);//al ser negativos los muestra en forma creciente
            Console.WriteLine("Numeros negativos en forma Creciente:");
            for (int i = 0; i < arrayNumeros.Length; i++)
            {
                if (arrayNumeros[i] < 0)
                {
                    Console.WriteLine(arrayNumeros[i]);
                }
            }

        }

        public static int[] SortDecreciente(int[] array)
        {
            int[] arrayOrdenado = new int[array.Length];

            for(int i = 0;i< array.Length -1;i++)
            {
                for(int j = i+1;j < array.Length;j++)
                {
                    if (array[i] < array[j])
                    {
                        arrayOrdenado[i] = array[i];
                        array[i] = array[j];
                        array[j] = arrayOrdenado[i];
                    }
                }
            }
            return arrayOrdenado;
        }

        public static int[] SortCreciente(int[] array)
        {
            int[] arrayOrdenado = new int[array.Length];

            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        arrayOrdenado[i] = array[i];
                        array[i] = array[j];
                        array[j] = arrayOrdenado[i];
                    }
                }
            }
            return arrayOrdenado;
        }


    }
}
