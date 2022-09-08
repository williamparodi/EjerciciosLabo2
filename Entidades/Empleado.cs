using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
	public class Empleado
	{
		#region Atributos
		private string nombre;
		private int legajo;
		private float sueldo;
		#endregion

		public Empleado()// se inicia
		{
			this.nombre = "NN";
			this.legajo = 1000;
			this.sueldo = 0;
		}

		public string Nombre
		{
			get { return this.nombre; }
			set { this.nombre = value; }
		}

		public int Legajo
		{
			get { return this.legajo; }
			set { this.legajo = value; }
		}

		public float Sueldo
		{
			get { return this.sueldo; }
			set { this.sueldo = value; }
		}

		public Empleado(string nombre) // sobrecarga  :this()
		{
			this.nombre = nombre;
		}

		public Empleado(string nombre, int legajo, float sueldo) : this(nombre)
		{

			this.legajo = legajo;
			this.sueldo = sueldo;
		}

		public string Saludar()
		{
			return $"Hola soy {this.nombre}, mi legajo es {this.Legajo} y estoy saludando a todos";
		}

		public string Saludar(string nombre)
		{
			return $"Hola soy {this.nombre}, mi legajo es {this.Legajo} y estoy saludando {nombre}";
		}

		public string Saludar(int veces)
        {
			string cadena = "";

			for(int i = 0; i < veces; i++)
            {
				cadena += $"{this.nombre}";
            }

			return cadena;
        }

		public static bool operator ==(Empleado e1, Empleado e2)
        {
			bool retorno = false;

			if(e1.nombre == e2.nombre && e1.legajo == e2.legajo)//puedo retornar directo la condicion
            {
				retorno = true;
            }

			//string saludo = e1.nombre == e2.nombre ? "hola" : "chau";
			return retorno;
        }

		public static bool operator !=(Empleado e1, Empleado e2)
		{
			return !(e1 == e2);
		}
	}
}

