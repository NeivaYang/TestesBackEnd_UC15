using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculadora;

namespace TesteXUnit
{
   public class CalculoIMCTest
    {
        [Fact]

        public void CalcularIMC_RetornaResultado()
        {
            double peso = 110;
            double altura = 1.79;

            var resultado = Operacoes.CalcularIMC(peso, altura);

            Assert.Equal(34.33, resultado);
        }

        [Theory]
        [InlineData(80, 1.79, 24.97)]
        [InlineData(100, 1.79, 31.21)]
        [InlineData(120, 1.79, 37.45)]


        public void CalcularIMC_RetornaResultado_ParaUmaListaDeValores(double peso, double altura, double resultadoEsperado)
        {
            var resultadoIMC = Operacoes.CalcularIMC(peso, altura);

            Assert.Equal(resultadoEsperado, resultadoIMC);

        }
    }

    




}
