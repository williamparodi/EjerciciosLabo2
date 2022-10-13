using System;
using System.Data;
using System.Text.RegularExpressions;


namespace Clase10_Anotaciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            //Console.WriteLine("ingrese un numero");

            try //trata de hacer esto
            {
                //numero = int.Parse(Console.ReadLine());
                numero = Funcion4(); 
            }
            catch (Exception) //si ahi error muestra mensaje
            {

                Console.WriteLine("Error");
            }

            Console.WriteLine(numero);
  
        }



        public static int Funcion()
        {
            Console.WriteLine("Ingrese un numero");
            return int.Parse(Console.ReadLine());
        }

        public static int Funcion1()
        {
            int numero = 0;
            try
            {
                Console.WriteLine("Ingrese un numero");
                numero = int.Parse(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Excepcion");
                Console.WriteLine(ex.ToString());
                Console.WriteLine(ex.Message);//guarda el mensaje q escribo
            }
           
            return int.Parse(Console.ReadLine());
        }

        public static int Funcion2()
        {
            int numero = 0;

            try
            {
                Console.WriteLine("Ingrese un numero");
                numero = int.Parse(Console.ReadLine());
            }
            catch (OverflowException ex)// busco el error especifico
            {
                Console.WriteLine("Ocurrio una OverFlow");
                Console.WriteLine(ex.StackTrace);
            }
            catch (Exception) // si hay otro entra aca
            {
                Console.WriteLine("Error");
            }
            return numero;
        }

        public static int Funcion3()
        {
            int numero = 0;

            try
            {
                Console.WriteLine("Ingrese un numero");
                numero = int.Parse(Console.ReadLine());
                int resultado = 8 / numero;
            }
            catch (OverflowException ex)// busco el error especifico
            {
                Console.WriteLine("Ocurrio una OverFlow");
                

                //throw new DivideByZeroException("No se puede dividir por 0");// relanza oto y puedo poner mensaje personalizado

                throw new ArgumentNullException("Error ",ex);//se guardan los datos de las excepciones anteriore
            }
            catch (DivideByZeroException ex) // si hay otro entra aca
            {
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine("Quisiste dividir por cero");
            }
            finally
            {
                Console.WriteLine("Bloque Finally");
            }

            return numero;
        }

        //Finally ejecuta lo sigue al exception lo uso para que despues del catch se ejecute

        //Ineception 

        //Creamos propias excepciones
        public static int Funcion4()
        {
            int numero = 0;

            try
            {
                Console.WriteLine("Ingrese un numero");
                numero = int.Parse(Console.ReadLine());
                int resultado = 8 / numero;
               
            }
            catch (OverflowException ex)// busco el error especifico
            {
                throw new MiExcepcion("MI excepcion con parametros",ex);
            }
           

            return numero;
        }


    }
}
