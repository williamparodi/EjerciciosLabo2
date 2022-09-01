using System;

namespace Ejercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int numero1 = 2;
            float numero2;
            string palabra;// "hola"
            string palabra1 = "hola mundo";
            bool flag = false;// o true
            double numeroGrande = 20;
            int[] numeros = new int[5]; //Array o a mano [1,2,3] 

            foreach(char item in palabra1) // recorre el string
            {
                Console.WriteLine(item);
                break;
            }
            /*
            Console.WriteLine("Ingrese una palabra: ");// muestra mensaje

            palabra = Console.ReadLine(); // levanto dato 

            Console.WriteLine("La palabra es : {0} ",palabra); //imprimo, {0} indica la posicion de la variable a printiar
            */

            //numero = int.Parse(palabra); casteo un string a un entero
         
        }
    }
}
