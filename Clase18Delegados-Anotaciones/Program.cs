using System;
using System.Collections.Generic;

namespace Clase18Delegados_Anotaciones
{
    internal class Program
    {
        //Declaro el delegado
        public delegate string MiDelegado();
        public delegate void DelegadoSinRetornoNiParametros();
        public delegate void DelegadoConUnParametro(string mensaje);
        //
        public delegate void DelegadoAction();//ejemplo
        public delegate string DelegadoFunc(string mensaje);
        public delegate bool DelegadoPredicate(string mensaje);
        static void Main(string[] args)
        {
            Persona p1 = new Persona("Pepe", 22);
            Persona p2 = new Persona("Pablo", 33);

            //Intancio el delegado
            MiDelegado delegadito = new MiDelegado(p1.SaludarSinParametros);
            MiDelegado delegado2 = new MiDelegado(p1.SaludarConEdad);

            //llamo al delegado
            Console.WriteLine(delegadito());

            delegadito = p1.SaludarSinParametros;//esta es la mejor manera
            Console.WriteLine(delegadito() );

            //le paso el metodo a delegado va a comparar y apunta a mifuncion 
            MiDelegadoComparador delegadoComparador = MiFuncionMayor;//o puedo poner MiFUncionMenor

            List<int> listaNumeros = new List<int>()
            {
                5,8,12,99,22,5,1223,54,88,7887,8
            };

            //el delegadoComparador acciona la funcion por atras
            Console.WriteLine("El numero mayor es: " + p1.FuncionConDelegado(delegadoComparador, listaNumeros));
            
        }


        
        static bool MiFuncionMayor(int num1, int num2)
        {
            //(num1, num2) => num1 + num2; ejemplo lambda
            if(num1 > num2)
            {
                return true;
            }
            return false;
        }

        static bool MiFuncionMenor(int num1, int num2)
        {
            if (num1 < num2)
            {
                return true;
            }
            return false;
        }


    }
}
