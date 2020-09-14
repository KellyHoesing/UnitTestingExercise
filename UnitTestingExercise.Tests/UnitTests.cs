using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(1, 2, 3, 6)]
        [InlineData(5, 5, 5, 15)]
        public void Add(int num1, int num2, int num3, int expected)
        {
            //Arrange
            var test1 = new UnitTestMethods();
            //Act
            var actual = test1.Add(num1, num2, num3);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(5, 5, 0)]
        public void Subtract(int minuend, int subtrhend, int expected)
        {
            //Arrange
            var test2 = new UnitTestMethods();
            //Act
            var actual = test2.Subtract(minuend, subtrhend);
            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(1, 4, 4)]
        [InlineData(2, 2, 4)]
        public void Multiply(int num1, int num2, int expected)
        {
            //Arrange
            var test3 = new UnitTestMethods();
            //Act
            var actual = test3.Multiply(num1, num2);
            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(4, 2, 2)]
        [InlineData(12, 2, 6)]
        public void Divide(int num1, int num2, int expected)
        {
            //Arrange
            var test4 = new UnitTestMethods();
            //Act
            var actual = test4.Divide(num1, num2);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void YourMethodName()
        {
            //Arrange
            var expected1 = new UnitTestMethods();
            //Act
            var actual = expected1.DogNoise();
            //Assert
            Assert.Equal('h', actual);
        }

        [Fact]
        public void YourMethodName2()
        {
            //Arrange
            var expected2 = new UnitTestMethods();
            //Act
            int actual = expected2.YourAge();
            //Assert
            Assert.Equal(10, actual);
        }
    }
}
