using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalClase08
{
    public class Perro : Mascota // la clase perro hereda de Mascota
    {
        private string raza;
        //Hay que hacer constructor de mascota, no se heredan
        public Perro(string nombre,int patas,string sexo) : base(nombre,patas,sexo) // hago referencia al ctor de la clase padre
        {
            this.raza = "Desconocido";       
        }

        public Perro(string nombre, int patas, string sexo,string raza) : base(nombre, patas, sexo) // hago referencia al ctor de la clase padre
        {
            this.raza = raza;    
        }

        public string Ladrar()
        {
            //base.Saludar();//Llamo al metodo saludar de la clase base se puede poner con this pero es mejor asi.
            return this.nombre + "Guau"; //como esta protected la puedo ver a nombre

        }
    }
}
