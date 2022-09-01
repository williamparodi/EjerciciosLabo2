using System;
using Entidades;
/*
    Crear una aplicación de consola y una biblioteca de clases que contenga la clase Persona.

    Deberá tener los atributos:

    nombre
    fechaDeNacimiento
    dni
    Deberá tener un constructor que inicialice todos los atributos.

    Construir los siguientes métodos para la clase:

    Setter y getter para cada uno de los atributos.
    CalcularEdad será privado y retornará la edad de la persona calculándola a partir de la fecha de nacimiento.
    Mostrar retornará una cadena de texto con todos los datos de la persona, incluyendo la edad actual.
    EsMayorDeEdad si es mayor de edad devuelve el valor “Es mayor de edad", sino devuelve “es menor”.
    Instanciar 3 objetos de tipo Persona en el método Main.
    Mostrar quiénes son mayores de edad y quiénes no.
*/
namespace Clase03_Ejercicio02
{
    internal class Program
    {

        public static void Main(string[] args)
        {   
            Persona persona1 = new Persona("Pepe","23/05/1955",5698844);
            Persona persona2 = new Persona("Norberto","05/06/2015",45666666);
            Persona persona3 = new Persona("Laura","03/08/2000",9862221);

            Console.WriteLine(persona1.Mostrar());
            Console.WriteLine(persona1.EsMayorDeEdad());
            Console.WriteLine(persona2.Mostrar());
            Console.WriteLine(persona2.EsMayorDeEdad());
            Console.WriteLine(persona3.Mostrar());
            Console.WriteLine(persona3.EsMayorDeEdad());
        }
    }
}
