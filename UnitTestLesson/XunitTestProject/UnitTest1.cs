using System;
using Xunit;
using CalculatorDemo;

namespace XunitTestProject
{
    public class UnitTest1
    {
        [Fact]
        public void AddTest()
        {
            //assemble
            Calculator calc = new Calculator();

            //Act
            int answer = calc.Add(1, 2);

            //Assert
            Assert.Equal(3, answer);

        }
    }
}
