namespace Demo.Tests
{
    public class AssertingExceptionsTests
    {
        [Fact]
        public void Calculadora_Dividir_DeveRetornarErroDivisaoPorZero()
        {
            // Arrange
            var calculadora = new Calculadora();

            // Act & Assert
            Assert.True(Double.IsInfinity(calculadora.Dividir(10, 0)));
        }


        [Fact]
        public void Funcionario_Salario_DeveRetornarErroSalarioInferiorPermitido()
        {
            // Arrange & Act & Assert
            var exception =
                Assert.Throws<Exception>(() => FuncionarioFactory.Criar("Douglas", 250));

            Assert.Equal("Salario inferior ao permitido", exception.Message);
        }
    }
}
