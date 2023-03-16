using Calculadora;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteIMC
{
    [TestClass]
    public class CalculoIMCTest
    {
        [TestMethod]
        public void CalcularIMC()
        {
            //Arrange - Preparação
            double peso = 110;
            double altura = 1.79;

            //Act - Ação
            var resultadoIMC = Operacoes.CalcularIMC(peso, altura);

            //Assert - Verificação
            Assert.AreEqual(34.33, resultadoIMC);
        }
    }
}
