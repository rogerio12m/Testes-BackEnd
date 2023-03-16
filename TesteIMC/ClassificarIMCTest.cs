using Calculadora;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteIMC
{
    [TestClass]
    public class ClassificarIMCTest
    {
        [TestMethod]
        public void ClassificarIMC()
        {
            //Arrange - Preparação
            double imc = 28;

            //Act - Ação
            var classificacaoIMC = Operacoes.ClassificarIMC(imc);

            //Assert - Verificação
            Assert.AreEqual("Sobrepeso", classificacaoIMC);
        }
    }
}
