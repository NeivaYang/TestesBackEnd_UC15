using Projeto_teste;

namespace TestMSTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SomarDoisNumeros()
        {
            // Arrange - Preparação
            double pNum = 1;
            double sNum = 1;
            double rNum = 2;

            //act - ação
            var resultado = Operacoes.Somar(pNum, sNum);
            Assert.AreEqual(rNum, resultado);
        }

        [DataTestMethod]
        [DataRow(1, 1, 2)]
        [DataRow(2, 2, 4)]
        [DataRow(2, 1, 2)]
        public void SomarDoisNumerosLista(double pNum, double sNum, double rNum)
        {
            //Act - Ação
            var resultado = Operacoes.Somar(pNum, sNum);

            //Assert - Verificação
            Assert.AreEqual(rNum, resultado);
        }



    }
}