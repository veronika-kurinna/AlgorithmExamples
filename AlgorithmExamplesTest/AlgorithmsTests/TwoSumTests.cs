using AlgorithmExamples.Algorithms;
using FluentAssertions;
using Xunit;

namespace AlgorithmExamplesTest.AlgorithmsTests
{
    public class TwoSumTests
    {
        [Theory]
        [InlineData(new int[] { 6, 2, 4 }, 6, new int[] { 2, 4 })]
        [InlineData(new int[] { -3, -3 }, -6, new int[] { -3, -3 })]
        [InlineData(new int[] { 9, 2, 3, 4, 7, 0 }, 7, new int[] { 3, 4 })]
        [InlineData(new int[] { 9, 2, -3, 7, 0, -4 }, -7, new int[] { -3, -4 })]
        [InlineData(new int[] { 5, 2, 3, 7, 8 }, 8, new int[] { 5, 3 })]
        [InlineData(new int[] { 0, 2, 3, 9, 7 }, 4, new int[] { 2, 2 })]
        public void FindTwoSum_Numbers_ReturnsArrayCorrectly(int[] array, int target, int[] expectedResult)
        {
            //Arrange && Act
            int[] result = TwoSum.FindTwoSum(array, target);

            //Assert
            result.Should().Equal(expectedResult);
        }

        [Fact]
        public void FindTwoSum_ArrayIsEmpty_ThrowsArgumentException()
        {
            //Arrange
            int[] array = Array.Empty<int>();
            int target = 7;

            //Act && Assert
            Action action = () => TwoSum.FindTwoSum(array, target);
            action.Should().Throw<ArgumentException>()
                        .WithMessage("Array is empty");
        }

        [Fact]
        public void FindTwoSum_ArrayHasOnly1Number_ThrowsArgumentException()
        {
            //Arrange
            int[] array = { 7 };
            int target = 7;

            //Act && Assert
            Action action = () => TwoSum.FindTwoSum(array, target);
            action.Should().Throw<ArgumentException>()
                        .WithMessage("Array has only 1 number");
        }
    }
}
