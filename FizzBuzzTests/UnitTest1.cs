using System;
using Xunit;
using System.IO;

namespace Algorithms
{
    public class UnitTest1
    {
        [Fact]
        public void RunFizzBuzzTests()
        {
            // Arrange
            var fizzBuzz = new FizzBuzz();
            var output = new StringWriter();
            Console.SetOut(output);

            // Act
            fizzBuzz.SolveFizzBuzz(20);
            var console = output.ToString();

            // Assert
            var n = Environment.NewLine;
            Assert.Equal($"1{n}2{n}fizz{n}4{n}buzz{n}fizz{n}7{n}8{n}fizz{n}buzz{n}11{n}fizz{n}13{n}14{n}fizzbuzz{n}16{n}17{n}fizz{n}19{n}buzz{n}", console);
        }

        // New unit test for FizzBuzzFunctional using data theory.
        [Theory]
        [InlineData(5, "1\n2\nfizz\n4\nbuzz\n")]
        [InlineData(15, "1\n2\nfizz\n4\nbuzz\nfizz\n7\n8\nfizz\nbuzz\n11\nfizz\n13\n14\nfizzbuzz\n")]
        [InlineData(20, "1\n2\nfizz\n4\nbuzz\nfizz\n7\n8\nfizz\nbuzz\n11\nfizz\n13\n14\nfizzbuzz\n16\n17\nfizz\n19\nbuzz\n")]
        public void RunFizzBuzzFunctionalTests(int input, string expected)
        {
            // Arrange
            var fizzBuzzFunctional = new FizzBuzzFunctional();
            var output = new StringWriter();
            Console.SetOut(output);

            // Act
            fizzBuzzFunctional.SolveFizzBuzz(input);
            var consoleOutput = output.ToString();
            var expectedOutput = expected.Replace("\n", Environment.NewLine);

            // Assert
            Assert.Equal(expectedOutput, consoleOutput);
        }
    }
}
