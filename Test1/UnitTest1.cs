using clase10_Ejer02_Exception;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange : inicianiliza las variables
            int numero1 = 2;
            int numero2 = 3;
            int resultado;
            //Acct:
            resultado = numero1 + numero2;
            //Assert
            Assert.AreEqual(5, resultado);// por ejemplo testeo si se agrego a la lista voy por la positiva
        }

        [TestMethod]
        public void TestResta()
        {
            int numero1 = 5;
            int numero2 = 3;
            int resultado;

            resultado = numero1 - numero2;

            Assert.AreEqual(2, resultado);
        }

        [TestMethod]
        [ExpectedException(typeof(MisExceptions))] //Se puede hacer asi para las execption

        public void TestDivision()
        {
            int numero1 = 6;
            int numero2 = 0;
            double resultado;

            resultado = Calculador.Calcular(numero1,numero2);

        }
    }
}
