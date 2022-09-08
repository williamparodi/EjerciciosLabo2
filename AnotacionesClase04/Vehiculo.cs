using System.Text;

namespace AnotacionesClase04
{
    // SOBRECARGAS
    public class Vehiculo
    {
        private int puertas;
        private string marca;
        private string color;
        private int litrosNafta;

        public Vehiculo(string marca, int puertas, string color)
        {
            this.marca = marca;
            this.puertas = puertas;
            this.color = color;
        }

        public Vehiculo(string marca, int puertas, string color, int litrosNafta) : this(marca, puertas, color)// este this se ejecuta primero 
        {
            this.litrosNafta = litrosNafta;
        }

        //Propiedades se declaran asi:SIN Parentesis
        public string Color
        {
            get
            {
                return this.color;
            }
            set
            {
                this.color = value;
            } // se puede validar tamb en el set
            /*set
            {
                if(value != null)
                {
                    this.color = value;
                }
                else
                {
                    this.color = "rojo";
                
            }
            */
        }


        //v1.Color = “ rojo”; Accedo al set
        //v1.Color  = v1.Color; get

        //Console.WirteLine(v1.Mostrar());

        //Sobrecarga metodos
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(this.marca);
            return sb.ToString();
        }

        public string Mostrar(int numero1)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Puertas : {this.puertas}");
            this.Mostrar();  // uso el otro metodo
            return sb.ToString();
        }

        //sobrecarga operador
        public static int operator +(Vehiculo n1, Vehiculo n2)// uno de los dos tiene q ser del tipo de la classe de la sobrecarga
        {
            return n1.litrosNafta + n2.litrosNafta;
        }

        public static int operator -(Vehiculo n1, Vehiculo n2)
        {
            return n1.litrosNafta - n2.litrosNafta;
        }
        // La sobrecarga  de == va con el !=
        public static bool operator ==(Vehiculo n1, Vehiculo n2) // si o si tiene q estar la !=
        {
            return (n1.color == n2.color);
        }

        public static bool operator !=(Vehiculo n1, Vehiculo n2)
        {
            return !(n1 == n2);
        }

        // Sobrecarga Conversion Implicit e Explicit

        public static implicit operator string(Vehiculo v1)// implicit
        {
            return v1.color;// puede guardar y no aviso que se puede perder datos
        }

        //En el main
        // string color;
        //color = v1;
        public static explicit operator int(Vehiculo v1)// explicit 
        {
            return v1.litrosNafta;
        }

        //int ls;
        //ln = (int)v1; // Cuando lo tranforme va a haber una perdida datos dependiendo del tipo de dato
    }
}
