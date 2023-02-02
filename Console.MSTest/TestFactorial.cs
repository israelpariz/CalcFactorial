using CalcFactorial;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Factorial.Tests
{
    [TestClass]
    public class TestFactorial
    {
        [TestMethod]
        public void SucessoFatorCinco()
        {
            int entrada = 5;
            int resultadoEsperado = 120;

            int resultado = CalculaFatorial.Factorial(entrada);

            Assert.AreEqual(resultadoEsperado, resultado);
        }

        [TestMethod]
        public void SucessoFatorZero()
        {
            int entrada = 0;
            int resultadoEsperado = 1;

            int resultado = CalculaFatorial.Factorial(entrada);

            Assert.AreEqual(resultadoEsperado, resultado);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ErroEntradaNegativa()
        {
            int entrada = -1;

            CalculaFatorial.Factorial(entrada);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ErroEntradaMaiorQueVinte()
        {
            int entrada = 21;

            CalculaFatorial.Factorial(entrada);
        }
    }
}
