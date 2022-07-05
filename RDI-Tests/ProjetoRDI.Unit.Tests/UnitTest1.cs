using FluentAssertions;

namespace Calculadora.Unit.Tests
{
    public class Tests
    {
        //[SetUp]
        //public void Setup()
        //{
        //}
        
        private Calculadora calculadora = new Calculadora();

        [TestCase(8, 3)]
        public void Subtracao_WhenValoresDoubles_ShouldSubtrair(double num1, double num2)
        {
            //Arrange
            //Act
            var response = calculadora.Subtracao(num1, num2);

            //Assert
            response.Should().Be(5);
        }

    }
}