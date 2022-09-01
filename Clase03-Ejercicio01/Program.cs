using System;
using Entidades;
/*
 * Crear una aplicación de consola y una biblioteca de clases que contenga la clase Cuenta.

Deberá tener los atributos:

titular que contendrá la razón social del titular de la cuenta.
cantidad que será un número decimal que representa al monto actual de dinero en la cuenta.
Construir los siguientes métodos para la clase:

Un constructor que permita inicializar todos los atributos.
Un método getter para cada atributo.
mostrar retornará una cadena de texto con todos los datos de la cuenta.
ingresar recibirá un monto para acreditar a la cuenta. Si el monto ingresado es negativo, no se hará nada.
retirar recibirá un monto para debitar de la cuenta. La cuenta puede quedar en negativo.
En el método Main, simular depósitos y extracciones de dinero de la cuenta, e ir mostrando como va variando el saldo.*/

namespace Clase03_Ejercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cuenta cantidad1;
            string respuesta = "n";
            string operacionIngresada = "";
            int operacion = 0;
            string montoIngresado = "";
            int monto;
            bool flag = false;
            
            cantidad1 = new Cuenta("Pedro",50000);

            do
            {
                /*
                Console.WriteLine("Ingrese nombre y razon social");
                cantidad1.titular = Console.ReadLine();
                */
                Console.WriteLine("Ingrese operacion a realizar: 1- Deposito o 2-retiro");
                operacionIngresada = Console.ReadLine();
                flag = int.TryParse(operacionIngresada, out operacion);

                if(flag && operacion == 1)
                {
                    /*
                    Console.WriteLine("Ingrese monto a depositar: ");
                    montoIngresado = Console.ReadLine();
                    flag = int.TryParse(montoIngresado, out monto);
                    
                    while(!flag)
                    {
                        Console.WriteLine("Error,Ingrese monto a depositar: ");
                        montoIngresado = Console.ReadLine();
                        flag = int.TryParse(montoIngresado, out monto);
                    }
                    */

                    if(cantidad1.Ingresar(600))
                    {
                        Console.WriteLine("Deposito Efectuado");
                        
                    }
                    else
                    {
                        Console.WriteLine("El monto debe ser mayor a 0");
                    }
                }
                else if(flag && operacion == 2)
                {

                    Console.WriteLine("Ingrese monto a retirar: ");
                    montoIngresado = Console.ReadLine();
                    flag = int.TryParse(montoIngresado, out monto);

                    while (!flag)
                    {
                        Console.WriteLine("Error,Ingrese monto a retirar: ");
                        montoIngresado = Console.ReadLine();
                        flag = int.TryParse(montoIngresado, out monto);
                    }

                    if(cantidad1.Retirar(800))
                    {
                        Console.WriteLine("Retiro Efectuado");
                        
                    }
                    else
                    {
                        Console.WriteLine("No hay dinero en la cuenta");
                    }
                }

                Console.WriteLine(cantidad1.Mostrar());
                Console.WriteLine("Desea continuar?");
                respuesta = Console.ReadLine();

            } while (respuesta != "s");


        }
    }
}
