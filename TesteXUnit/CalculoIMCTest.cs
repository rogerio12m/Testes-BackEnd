﻿using Calculadora;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace TesteXUnit
{
    public class CalculoIMCTest
    {
        [Fact]
        public void CalcularIMC_RetornaResultado()
        {
            //Arrange - Preparação
            double peso = 110;
            double altura = 1.79;

            //Act - Ação
            var resultado = Operacoes.CalcularIMC(peso, altura);

            //Assert - Verificação
            Assert.Equal(34.33, resultado);
        }

        [Theory]
        [InlineData(80, 1.79, 24.97)]
        [InlineData(100, 1.79, 31.21)]
        public void CalcularIMC_RetornaResultado_ParaUmaListaDeValores(double peso, double altura, double resultadoEsperado)
        {
            //Act - Ação
            var resultadoDoIMC = Operacoes.CalcularIMC(peso, altura);

            //Assert - Verificação
            Assert.Equal(resultadoEsperado, resultadoDoIMC); 
        }
    }
}
