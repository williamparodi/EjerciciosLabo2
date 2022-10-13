using System;
using clase10_Ejer02_Exception;

namespace clase10_Ejer02_Exception
{
    public class Calculador
    {
        public static double Calcular(int numero1, int numero2)
        {
            double resultado = 0;

            try
            {
                resultado =(double) numero1 / numero2;
            }
            catch (DivideByZeroException ex)
            {
                throw new MisExceptions("No se puede dividir por 0",ex);
            }

            return resultado;
        }
    }
}
