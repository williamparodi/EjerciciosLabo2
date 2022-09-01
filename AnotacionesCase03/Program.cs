using System;

namespace AnotacionesCase03
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //NombreClase.Metodo al ser estatica
            string nombre;
            //Crear un objeto
            Animal animal1;
             animal1 = new Animal("Pepe",10,"Perro"); //Intacio una clase -> reservo espacio en memoria, siempre es en el Program
            //mucho mas seguro con parametros.
            Animal animal2;
            animal2 = new Animal();

            animal2.nombre = "Juana";
            animal1.edad = 8;
            animal2.tipoDeAnimal = "Gato";

            Console.WriteLine(animal1.Hablar());// de esta manera uso el metodo de la clase
            Console.WriteLine(animal2.Hablar());

            Console.WriteLine(animal1.edad);
            Console.WriteLine(Animal.contadorDeAnimales);// estatico 
            
        }
    }
}
