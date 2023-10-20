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
    }
}
