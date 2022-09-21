using System;
using System.Collections.Generic;
namespace AnotacionesClase05
{
    public class Program
    {
        static void Main(string[] args)
        {
            var numero = 5;// se le puede dar cualquier valor y lo encuentro en el foreach
            int[] arrayEnteros;
            arrayEnteros = new int[5];

            // Elementos 0,1,2,3,4,5

            arrayEnteros[0] = 15;

            int [,] arrayBidemensionales = new int[2,3];

            arrayBidemensionales[0, 0] = 5;// me refiero al primer casillero
            arrayBidemensionales [0, 1] = 5;
            arrayBidemensionales[1,0] = 5;
            arrayBidemensionales[1,1] = 5;

            foreach(int num in arrayBidemensionales)// Se utiliza para recorrer array o colecciones
            {
                Console.WriteLine(num);
            }

            //arrayBidimensionales[5,5] = 1; //esta fuera de rango

            List<int> listaEnteros;

            listaEnteros = new List<int>();

            Dictionary<int, int> diccionario = new Dictionary<string, Ingresante>();

            Queue<int> colaNumeros = new Queue<int>();// se agrega a lo ultimo

            colaNumeros.Enqueue(1);// agrega valor al final
            int numero = colaNumeros.Dequeue();//Remover el primero
            int ultimoElemento = colaNumeros.Last();

            Stack<int> miStack = new Stack<int>();

            miStack.Push(5);//empuja un elemnto al final
            miStack.CopyTo(arrayEnteros, 5);
            int ultimo = miStack.Pop();//Devuelve el ultimo elemento ingresado

            SortedList<int, string> miSorted = new SortedList<int, string>();

            miSorted.Add(3, "HOLA");
            miSorted.Add(50, "HOLA5");
            
            miSorted.Add(50, "HOLA2");// ordena como le indico con el int o con letras o string

            foreach(int num in miSorted)
            {
                Console.WriteLine(num.Value);
            }
        }
    }
}
