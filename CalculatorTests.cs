using calculatorAppAA;
using CalculatorLibrary;
using Xunit;

namespace CalculatorLibrary.Tests
{
    public class CalculatorTests
    {
        
        public void TestAdd()
        {
       
            Calculator calculator = new Calculator();

 
            int result = calculator.Add(2, 3);

 
            Assert.Equal(5, result);
        }

      
        public void TestSubtract()
        {
            // Arrange
            Calculator calculator = new Calculator();

            // Act
            int result = calculator.Subtract(5, 2);

            // Assert
            Assert.Equal(3, result);
        }

        // Add more test methods for other calculator methods (Multiply, Divide, etc.)
    }
}
