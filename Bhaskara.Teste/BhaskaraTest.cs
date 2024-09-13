using Bhaskara;
using BhaskaraExemplo;
namespace Bhaskara.Teste
{
    public class BhaskaraTest
    {
        [Fact]
        public void DuasRaizesReais()
        {
            // Arrange
            double a = 1;
            double b = -5;
            double c = 6;

            // Act
            var (x1, x2) = BhaskaraExemplo.BhaskaraExemplo.CalcularRaizes(a, b, c);

            // Assert
            Assert.True(x1 > 0 && x2 > 0);
            Assert.Equal(2, x1, 2);
            Assert.Equal(3, x2, 2);
        }

        [Fact]
        public void NenhumaRaizReal()
        {
            // Arrange
            double a = 1;
            double b = 2;
            double c = 10;

            // Act e Assert
            Assert.Throws<InvalidOperationException>(() => BhaskaraExemplo.BhaskaraExemplo.CalcularRaizes(a, b, c));
        }
    }
}