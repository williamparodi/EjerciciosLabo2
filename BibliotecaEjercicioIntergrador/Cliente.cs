using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaEjercicioIntergrador
{
    public class Cliente
    {
        private string aliasParaIncognito;
        private string nombre;
        private eTipoCliente tipoDeCliente;

        private Cliente()
        {
            this.aliasParaIncognito = "Sin alias";
            this.nombre = "NN";
            this.tipoDeCliente = eTipoCliente.SinTipo;
        }

        public Cliente(eTipoCliente tipoCliente ) : this ()
        {
            this.tipoDeCliente = tipoCliente;
        }

        public Cliente(eTipoCliente tipoDeCliente, string nombre) : this(tipoDeCliente)
        {
            this.nombre = nombre;
        }

        private void CrearAlias()
        { 
            Random rnd = new Random();
            StringBuilder sb = new StringBuilder("");
            int numero;

            numero = rnd.Next(1000, 9999);
            sb.Append(numero.ToString());
            sb.Append(this.tipoDeCliente.ToString());
            this.aliasParaIncognito = sb.ToString();
              
        }

        public string GetAlias()
        {
            if(this.aliasParaIncognito == "Sin alias")
            {
                CrearAlias();
            }

            return this.aliasParaIncognito;
        }

        private string RetornarDatos()
        {
            StringBuilder sb = new StringBuilder("");
            sb.AppendLine($"Nombre: {this.nombre}");
            sb.AppendLine($"Tipo: {this.tipoDeCliente}");
            sb.AppendLine($"Alias: {GetAlias()}");
            return sb.ToString();
        }

        public static string RetornarDatos(Cliente unCliente)//probar con static
        {
            return unCliente.RetornarDatos();
        }

    }
}
