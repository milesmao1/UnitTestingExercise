using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)] //Add test data <-------
        [InlineData(1,1,1,3)]
        [InlineData(1,2,3,6)]
        [InlineData(10,10,10,30)]
        [InlineData(100,100,100,300)]
        [InlineData(-1,6,-3,2)]
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:

            //Arrange
            // create a Calculator object
            var tester = new Calculator();

            //Act
            // call the Add method that is located in the Calculator class
            // and store its result in a variable named actual
            var actual = tester.Add(num1, num2, num3);


            //Assert
                Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(1,1,0)]
        [InlineData(-1,1,-2)]
        [InlineData(10,5,5)]
        [InlineData(100,25,75)]
        [InlineData(-4,-6,2)]
        public void SubtractTest(int minuend, int subtrahend, int expected)
        {
            //Start Step 5 here:

            //Arrange
            var tester = new Calculator();

            //Act
            var actual = tester.Subtract(minuend,subtrahend);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(1,5,5)]
        [InlineData(10,10,100)]
        [InlineData(5,5,25)]
        [InlineData(-5,-5,25)]
        [InlineData(3,3,9)]
        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Start Step 7 here:

            //Arrange
            var tester = new Calculator();

            //Act
            var actual = tester.Multiply(num1, num2);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(4,2,2)]
        [InlineData(7,1,7)]
        [InlineData(100,5,20)]
        [InlineData(9,3,3)]
        [InlineData(7,-1,-7)]
        public void DivideTest(int num1, int num2, int expected)
        {
            //Arrange
            var tester = new Calculator();

            //Act
            var actual = tester.Divide(num1, num2);

            //Assert
            Assert.Equal(expected, actual);

        }

    }
}
