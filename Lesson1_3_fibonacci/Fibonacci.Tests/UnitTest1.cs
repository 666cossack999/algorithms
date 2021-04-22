using System;
using Xunit;
using Lesson1_3_fibonacci;

namespace Fibonacci.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var n = 10;

            var resultRecursive = Calculator.goldenRatio(n);

            Assert.Equal(55, resultRecursive);

        }

        [Fact]
        public void Test2()
        {
            var n = 10;

            var result = Calculator.FibonacciNumber(n);

            Assert.Equal(55, result);


        }

        [Theory]

        [InlineData(0, 0)]
        [InlineData(1, 1)]
        [InlineData(9, 36)]
        [InlineData(10, 55)]
        [InlineData(11, 66)] //неверная теория
        public void Test3(int n, long ex)
        {
            var actualRecursive = Calculator.goldenRatio(n);

            Assert.Equal(ex, actualRecursive);
        }

        [Theory]

        [InlineData(0, 0)]
        [InlineData(1, 1)]
        [InlineData(9, 36)]
        [InlineData(10, 55)]
        [InlineData(11, 66)] //неверная теория
        public void Test4(int n, long ex)
        {
            var actual = Calculator.FibonacciNumber(n);

            Assert.Equal(ex, actual);

        }
    }
}
