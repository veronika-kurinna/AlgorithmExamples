using AlgorithmExamples.Algorithms;
using FluentAssertions;
using Xunit;

namespace AlgorithmExamplesTest
{
    public class TheBiggestNumberTests
    {
        [Theory]
        [InlineData(new int[] { 6, 9, 2, 8, 4 }, 9)]
        [InlineData(new int[] { 6, 1, -2, 8, -4 }, 8)]
        [InlineData(new int[] { 5, 5, 5, 5, 5 }, 5)]
        [InlineData(new int[] { 2 }, 2)]
        public void FindTheBiggestNumber_ArrayWithNumbers_ReturnsTheBiggestNumber(int[] array, int expectedResult)
        {
            //Arrange
            TheBiggestNumber theBiggestNumber = new TheBiggestNumber();

            //Act
            int result = theBiggestNumber.FindTheBiggestNumber(array);

            //Assert
            result.Should().Be(expectedResult);
        }

        [Fact]
        public void FindTheBiggestNumber_ArrayIsEmpty_ThrowsArgumentException()
        {
            //Arrange
            int[] array = Array.Empty<int>();
            TheBiggestNumber theBiggestNumber = new TheBiggestNumber();

            //Act && Assert
            Action act = () => theBiggestNumber.FindTheBiggestNumber(array);
            act.Should().Throw<ArgumentException>()
                        .WithMessage("Array is empty");
        }
    }
}
