using System.Collections.Generic;

namespace Clase18Delegados_Anotaciones
{
    //compara y retorna un bool 
    public delegate bool MiDelegadoComparador(int num1, int num2);
    public class Persona
    {
        private string nombre;
        private int edad;

        public Persona(string nombre, int edad)
        {
            this.nombre = nombre;
            this.edad = edad;
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }

        public string SaludarSinParametros()
        {
            return $"Hola {nombre} con edad {edad}";
        }

        public string SaludarConEdad()
        {
            return $"Hola {nombre} con edad {edad}";
        }

        public string SaludarConMensaje(string mensaje)
        {
            return $"HOLa {this.nombre} tenes un mensaje: {mensaje}";
        }

        //solo de muestra es mejorable, le paso un delegado ya con funcion adentro
        public int FuncionConDelegado(MiDelegadoComparador comparador, List<int> listaNumeros)
        {
            int aux = listaNumeros[0];
            for (int i = 0; i < listaNumeros.Count; i++)
            {
                if (!comparador(aux, listaNumeros[i]))
                {
                    aux = listaNumeros[i];
                }
            }
            return aux;
        }


    }
}
