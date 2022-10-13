using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace clase10_Ejer02_Exception
{
    public class Calculador
    {
        private int kilometros;
        private int litros;
        public Calculador(int kilometros,int litros)
        {
            this.kilometros = kilometros;
            this.litros = litros;
        }

        public static double Calcular(int numero1,int numero2)
        {
            double resultado = 0;

            try
            {
                resultado = numero1 / numero2;
            }
            catch (DivideByZeroException ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
