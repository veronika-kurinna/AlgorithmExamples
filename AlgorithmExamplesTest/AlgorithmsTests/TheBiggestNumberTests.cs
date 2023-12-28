using AlgorithmExamples.Algorithms;
using FluentAssertions;
using Xunit;

namespace AlgorithmExamplesTest.AlgorithmsTests
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
            //Arrange && Act
            int result = TheBiggestNumber.FindTheBiggestNumber(array);

            //Assert
            result.Should().Be(expectedResult);
        }

        [Fact]
        public void FindTheBiggestNumber_ArrayIsEmpty_ThrowsArgumentException()
        {
            //Arrange
            int[] array = Array.Empty<int>();

            //Act && Assert
            Action act = () => TheBiggestNumber.FindTheBiggestNumber(array);
            act.Should().Throw<ArgumentException>()
                        .WithMessage("Array is empty");
        }
    }
}
