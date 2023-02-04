using Projeto_teste;

namespace TesteXUnit
{
    public class UnitTest1
    {
        [Fact]
        public void SomarDoisNumeros()
        {
            // Arrange - Preparação
            double pNum = 1;
            double sNum = 1;
            double rNum = 2;

            // act - Ação
            var resultado = Operacoes.Somar(pNum, sNum);

            //Assert - Verificação

            Assert.Equal(rNum, resultado);

        }

        [Theory]
        [InlineData(1,1,2)]
        [InlineData(2,2,4)]
        [InlineData(2,1,2)]  

        public void SomarDoisNumerosLista(double pNum, double sNum,double rNum)
        {
            //Act - Ação
            var resultado = Operacoes.Somar(pNum,sNum);

            //assert - verificação
            Assert.Equal(rNum, resultado);

            
        }
    }
}