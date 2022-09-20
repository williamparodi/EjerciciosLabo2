using System;
using System.Collections.Generic;

namespace Clase06Ejercicio02
{
    /*Crear una aplicación de consola que cargue en una Lista, Pila(stack) y Cola(Queue) 20 números enteros (positivos y negativos) distintos de cero de forma aleatoria utilizando la clase Random.

    Mostrar la colección tal como fue cargada.
    Luego mostrar los positivos ordenados en forma decreciente.
    Por último, mostrar los negativos ordenados en forma creciente.
    */
    internal class Program
    {
        static void Main(string[] args)
        {
            //Lista
            List<int> listaEnteros = new List<int>();
            List<int> listaPositivos = new List<int>();
            List<int> listaNegativos = new List<int>();
            //Cola
            Queue<int> colaNumerosPositivos = new Queue<int>();
            Queue<int> colaNumerosNegativos = new Queue<int>();
            //Pila
            Stack<int> stackNumerosPositivos = new Stack<int>();
            Stack<int> stackNumerosNegativos = new Stack<int>();

            int numeroRamdom = 0;
            Random rnd = new Random();

            Console.WriteLine($" Lista numeros Ingresados: ");
            
            for (int i = 0;i< 20; i++)
            {
               numeroRamdom = rnd.Next(-100,100);
               listaEnteros.Add(numeroRamdom); 
            }
           
            foreach(int num in listaEnteros)
            {
                Console.WriteLine(num);
            }
            //Añado datos a la lista Positiva
            foreach (int numeroPostivo in listaEnteros)
            {
                if(numeroPostivo >0)
                {
                    listaPositivos.Add(numeroPostivo);
                }
            }

            Console.WriteLine("Numeros Positivos Lista: ");
            listaPositivos.Sort(ComparaNumeros);

            foreach (int num in listaPositivos)
            {
                Console.WriteLine(num);
                colaNumerosPositivos.Enqueue(num);
                stackNumerosPositivos.Push(num);
            }
            
            //Añado datos a la lista negativa
            foreach (int numeroNegativo in listaEnteros)
            {
                if (numeroNegativo < 0)
                {
                    listaNegativos.Add(numeroNegativo);
                }
            }

            Console.WriteLine("Numeros Negativos Lista");
            listaNegativos.Sort(ComparaNumeros);

            foreach (int num in listaNegativos)
            {
                Console.WriteLine(num);
                colaNumerosNegativos.Enqueue(num);
                stackNumerosNegativos.Push(num);
            }
            ///Cola de numeros positivo
            Console.WriteLine("Numeros positivos Cola : ");
            foreach(int num in colaNumerosPositivos)
            {
                Console.WriteLine(num);
            }
            //Cola de numeros negativos
            Console.WriteLine("Numeros negativos Cola : ");
            foreach (int num in colaNumerosNegativos)
            {
                Console.WriteLine(num);
            }
            //Stack de numeros postivos
            Console.WriteLine("Numeros positivos Stack : ");
            foreach (int num in stackNumerosPositivos)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine("Numeros negativos Stack : ");
            foreach (int num in stackNumerosNegativos)
            {
                Console.WriteLine(num);
            }


        }

        //Comparo y se lo paso al sort
        public static int ComparaNumeros(int numero1,int numero2)
        {
            int retorno = 0;

            if(numero1 > numero2)
            {
                retorno = -1;
            }
            else if(numero2 > numero1)
            {
                retorno = 0;
            }
            return retorno;
        }
    }
}
