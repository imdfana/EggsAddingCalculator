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
    }
}
