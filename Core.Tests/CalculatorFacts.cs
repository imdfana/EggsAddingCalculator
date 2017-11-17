using NUnit.Framework;

namespace Core.Tests
{
    [TestFixture]
    public sealed class CalculatorFacts
    {
        public sealed class AddMessage
        {
            [TestCase(1, 1, 2, Description = "1 + 1 Should Be 2")]
            [TestCase(1, 2, 3, Description = "1 + 2 Should Be 3")]
            public void AddTwoNumbers(int addendA, int addendB, int expected)
            {
                //Arrange
                Calculator calc = new Calculator();

                //Act
                int actual = calc.Add(addendA, addendB);

                //Assert
                Assert.That(actual, Is.EqualTo(expected));
            }

            [Test]
            public void MaxValuePlusOneMustBeEqualsToMinValue()
            {
                //Arrange
                Calculator calc = new Calculator();

                //Act
                int actual = calc.Add(int.MaxValue, 1);

                //Assert
                Assert.That(actual, Is.EqualTo(int.MinValue));
            }
        }

        public sealed class SubtractMessage
        {
            [TestCase(1, 2, -1, Description = "1 - 2 should be 1")]
            [TestCase(2, 1, 1, Description = "1 - 2 should be 1")]
            public void SubtractTwoNumber(int subtracting, int minuing, int remains)
            {
                Calculator calc = new Calculator();
                
                //Act
                int current = calc.Subtract(subtracting, minuing);

                Assert.That(current, Is.EqualTo(remains));
            }

        }

        public sealed class DivideMessage
        {
            [TestCase(2, 1, 2, Description = "2 / 1 should be 2")]
            [TestCase(5, 2, 3, Description = "5 / 2 should be 3")]
            public void DivideTwoNumber(int dividend, int divisor, int division)
            {
                Calculator calc = new Calculator();

                //Act 
                int current = calc.Divide(dividend, divisor);

                Assert.That(current, Is.EqualTo(division));
            }
        }

        public sealed class MultiplicationMessage
        {

            [TestCase(5, 2, 10, Description = "5 * 2 should be 10")]
            [TestCase(10, 3, 30, Description = "10 * 3 should be 30")]
            public void MultiplicationTwoNumber(int multiplying, int multiplier, int product)
            {
                Calculator calc = new Calculator();

                //Act 
                double current = calc.Multiplication(multiplying, multiplier);

                Assert.That(current, Is.EqualTo(product));
            }
        }
    }
}
