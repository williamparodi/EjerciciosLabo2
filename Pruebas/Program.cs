using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaEjercicioIntergrador;

namespace Pruebas
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*
            Cliente perrin = new Cliente(eTipoCliente.EmpresarioCorrupto, "Perrin");
            Cliente flipa = new Cliente(eTipoCliente.Financista, "Flipa");

            CuentaOffShore perrinOff= new CuentaOffShore("Lazaro", eTipoCliente.JugadorDeFutbol, 456, 65654);
            CuentaOffShore flipaOff = new CuentaOffShore(flipa, 232, 23333);

            ParaisoFiscal Delaware = eParaisosFiscales.Delaware;

            Delaware += perrinOff;
            Delaware += flipaOff;
            Delaware.MostrarParaiso();
            */

            Random rnd = new Random();
            int numero;
            StringBuilder sb = new StringBuilder();
            numero = rnd.Next(1000,9999);
            int numero2 = 2;
            sb.Append(numero.ToString() + numero2.ToString());
            Console.WriteLine(sb.ToString());

        }

    }
}
