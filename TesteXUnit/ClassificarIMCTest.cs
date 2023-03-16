using Calculadora;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteXUnit
{
    public class ClassificarIMCTest
    {
        [Fact]
        public void ClassificarIMC_RetornaResultado()
        {
            //Arrange - Preparação
            double imc = 28;

            //Act - Ação 
            var resultado = Operacoes.ClassificarIMC(imc);

            //Assert - Verificação 
            Assert.Equal("Sobrepeso", resultado);
        }

        [Theory]
        [InlineData(28, "Sobrepeso")]
        [InlineData(31, "Obesidade Grau I")]
        public void ClassificarIMC_RetornaResultado_ParaUmaListaDeValores(double imc, string resultadoEsperado)
        {
            //Act - Ação
            var resultado = Operacoes.ClassificarIMC(imc);

            //Assert - Verificação
            Assert.Equal(resultadoEsperado, resultado);
        }
    }
}
