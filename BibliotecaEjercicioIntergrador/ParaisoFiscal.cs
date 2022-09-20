using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotecaEjercicioIntergrador
{
    public class ParaisoFiscal
    {
        private List<CuentaOffShore> listadoCuentas;
        private eParaisosFiscales lugar;
        public static int cantidadDeCuentas;
        public static DateTime fechaDeInicioDeActividades;

        public static implicit operator ParaisoFiscal(eParaisosFiscales epf)
        {
            ParaisoFiscal pfiscal = new ParaisoFiscal(epf);

            return pfiscal;
        }

        public void MostrarParaiso()
        {
            StringBuilder mensaje = new StringBuilder("");
            mensaje.AppendLine($"Fecha de Inicio: {fechaDeInicioDeActividades}");
            mensaje.AppendLine($"Locación: {this.lugar}");
            mensaje.AppendLine($"Cantidad de cuentas: {cantidadDeCuentas}");
            mensaje.AppendLine($"**********************Listado de cuentas offshores************************");
            
            foreach (var cliente in this.listadoCuentas)
            {
                mensaje.Append(Cliente.RetornarDatos(cliente.Dueño));
                mensaje.AppendLine($"Numero de cuenta:{(int)cliente}");
                mensaje.AppendLine($"Saldo :{cliente.Saldo}");
                mensaje.AppendFormat("\n");
      
            }

            Console.WriteLine(mensaje.ToString());
        }

        public static bool operator !=(ParaisoFiscal pf, CuentaOffShore cos)
        {
            return !(pf == cos);
        }
        public static ParaisoFiscal operator -(ParaisoFiscal pf, CuentaOffShore cos)
        {

            bool flag = false;

            foreach (CuentaOffShore cosAux in pf.listadoCuentas)
            {
                if (cosAux == cos)
                {
                    if (pf.listadoCuentas.Remove(cos))
                    {
                        Console.WriteLine("Se borro la Cuenta");
                        ParaisoFiscal.cantidadDeCuentas--;
                        flag = true;
                        return pf;
                    }
                }

            }
            if (!flag)
            {
                Console.WriteLine("Esa cuenta no existe en ese Paraiso Fiscal");
            }

            return pf;
        }

        public static ParaisoFiscal operator +(ParaisoFiscal pf, CuentaOffShore cos)
        {
            bool flag = false;

            foreach (CuentaOffShore cosAux in pf.listadoCuentas)
            {
                if (cosAux == cos)
                {
                    cosAux.Saldo += cos.Saldo;
                    Console.WriteLine("Se actualizo el saldo en la cuenta");
                    flag = true;
                    return pf;
                }

            }

            if (!flag)
            {
                pf.listadoCuentas.Add(cos);
                ParaisoFiscal.cantidadDeCuentas++;
                Console.WriteLine("Se agrego la Cuenta");
                
            }

            return pf;

        }

        public static bool operator ==(ParaisoFiscal pf, CuentaOffShore cos)
        {
            bool retorno = false;

            foreach (CuentaOffShore cosAux in pf.listadoCuentas)
            {
                if (cosAux == cos)
                {
                    retorno = true;
                }
            }

            return retorno;
        }

        static ParaisoFiscal()
        {
            cantidadDeCuentas = 0;
            fechaDeInicioDeActividades = DateTime.Now;
        }

        private ParaisoFiscal()
        {
            this.listadoCuentas = new List<CuentaOffShore>();
        }

        private ParaisoFiscal(eParaisosFiscales lugar) : this()
        {
            this.lugar = lugar;
        }


    }
}
