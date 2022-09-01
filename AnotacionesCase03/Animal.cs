using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnotacionesCase03
{
  
    public class Animal
    {
        //ATRIBUTOS (caracteristas-datos) lowercamelCase

        public string nombre;
        public int edad;
        public string tipoDeAnimal;
        public static int contadorDeAnimales; //atributo estatico
            
        //Contructor estatico                                     
        static Animal()
        {
            Animal.contadorDeAnimales = 0;
        }

        //Contructor no estaticos
        public Animal() // para asignarle valores por defecto 
        {
            Animal.contadorDeAnimales++;//No se hace con this porque es static
            this.nombre = "Sin nombre";
            this.edad = 0;
            this.tipoDeAnimal = "Desconocido";
        }
       
        //Contruccion con param
        public Animal(string nombre,int edad,string tipoDeAnimal) // para clases staticas
        {
            Animal.contadorDeAnimales++;
            this.nombre = nombre;
            this.edad = edad;
            this.tipoDeAnimal = tipoDeAnimal;
        }
        //ctor tab tab

        //public Animal(string nombre, int edad, string tipoDeAnimal= "gato") harcodeo

        //METODOS   (Comportamientos - funciones) UpperCammelCase
        //Hablar
        //Comer
        public string Hablar()//No estatico
        {
            StringBuilder sb = new StringBuilder();//Genero objeto para texto largos 
            //Clase + objeto 
            sb.Append("Mi nombre es "); // crea una linea
            sb.AppendLine(this.nombre);// Salto de linea
            sb.Append("Tengo ");
            sb.AppendLine(this.edad.ToString());//transformo edad int en string
            sb.AppendLine(" Años");
            sb.Append("y soy un ");
            sb.AppendLine(this.tipoDeAnimal);
            //sb.AppendLine("minombre es" + this.nombre);

            return sb.ToString();//convierto en string
        }


    }
}
