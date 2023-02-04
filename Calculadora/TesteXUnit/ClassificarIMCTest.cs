using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculadora;

namespace TesteXUnit
{
    public class ClassificarIMCTest
    {
        [Fact]
        public void ClassificarIMC_RetornaResultado()
        {
            double imc = 28;

            var resultadoIMC = Operacoes.ClassificarIMC(imc);

            Assert.Equal("SobrePeso", resultadoIMC);
        }

        [Theory]

        [InlineData(28,"SobrePeso")]
        [InlineData(31, "Obesidade Grau I")]
        public void ClassificarIMC_RetornaResultado_ParaUmaListaDeValores(double imc, string resultadoEsperado)
        {
            var resultadoIMC = Operacoes.ClassificarIMC(imc);

            Assert.Equal(resultadoEsperado, resultadoIMC);
        }       
    }
}
