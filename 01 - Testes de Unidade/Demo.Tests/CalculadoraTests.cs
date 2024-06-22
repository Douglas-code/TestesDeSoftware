namespace Demo.Tests
{
    public class CalculadoraTests
    {
        [Fact]
        public void Calculadora_Somar_RetornarValorSoma()
        {
            // Arrange
            var calculadora = new Calculadora();

            // Act
            var resultado = calculadora.Somar(2, 2);

            // Assert
            Assert.Equal(4, resultado);
        }

        [Theory]
        [InlineData(1, 1, 2)]
        [InlineData(2, 2, 4)]
        [InlineData(4, 2, 6)]
        [InlineData(7, 3, 10)]
        [InlineData(6, 6, 12)]
        [InlineData(9, 9, 18)]
        public void Calculadora_Somar_RetornarValoresSomaCorretos(double v1, double v2, double total)
        {
            // Arrange
            var calculadora = new Calculadora();

            // Act
            var resultado = calculadora.Somar(v1, v2);

            // Assert
            Assert.Equal(total, resultado);
        }

        [Fact]
        public void Calculadora_Dividir_RetornarValorDivisao()
        {
            // Arrange
            var calculadora = new Calculadora();

            // Act
            var resultado = calculadora.Dividir(8, 2);

            // Assert
            Assert.Equal(4, resultado);
        }

        [Theory]
        [InlineData(1, 1, 1)]
        [InlineData(2, 2, 1)]
        [InlineData(4, 2, 2)]
        [InlineData(15, 3, 5)]
        [InlineData(6, 1, 6)]
        [InlineData(30, 10, 3)]
        public void Calculadora_Dividir_RetornarValoresDivisaoCorretos(double v1, double v2, double total)
        {
            // Arrange
            var calculadora = new Calculadora();

            // Act
            var resultado = calculadora.Dividir(v1, v2);

            // Assert
            Assert.Equal(total, resultado);
        }
    }
}
