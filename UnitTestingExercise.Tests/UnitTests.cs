using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)]
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            // Arrange
            var calculator = new Calculator(); 

            // Act
            var actual = calculator.Add(num1, num2, num3); 

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(8, 3, 5)]
        public void SubtractTest(int minuend, int subtrahend, int expected)
        {
            // Arrange
            var calculator = new Calculator(); 

            // Act
            var actual = calculator.Subtract(minuend, subtrahend); 

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(4, 5, 20)]
        public void MultiplyTest(int num1, int num2, int expected)
        {
            // Arrange
            var calculator = new Calculator(); 

            // Act
            var actual = calculator.Multiply(num1, num2); 

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(10, 2, 5)]
        public void DivideTest(int num1, int num2, int expected)
        {
            // Arrange
            var calculator = new Calculator(); 

            // Act
            var actual = calculator.Divide(num1, num2); 

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
