using AlgorithmExamples.Algorithms;
using FluentAssertions;
using Xunit;

namespace AlgorithmExamplesTest.AlgorithmsTests
{
    public class TwoSumTests
    {
        [Theory]
        [InlineData(new int[] { 0, 2, 3, 9, 7 }, 4, new int[] { 2, 2 })]
        [InlineData(new int[] { 8, 3, 5, 1, 7 }, 2, new int[] { 1, 1 })]
        [InlineData(new int[] { 9, 2, 3, 4, 0 }, 7, new int[] { 3, 4 })]
        [InlineData(new int[] { 9, 2, -3, 7, -6, 4 }, -9, new int[] { -3, -6 })]
        public void FindTwoSum_NumbersExist_ReturnsArrayCorrectly(int[] array, int target, int[] expectedResult)
        {
            //Arrange && Act
            int[] result = TwoSum.FindTwoSum(array, target);

            //Assert
            result.Should().Equal(expectedResult);
        }

        [Theory]
        [InlineData(new int[] { 6, 2, 4 }, 6, new int[] { 6 })]
        [InlineData(new int[] { 5 }, 5, new int[] { 5 })]
        [InlineData(new int[] { 4, 1, 3, 9, 7 }, 7, new int[] { 7 })]
        [InlineData(new int[] { 2, 1, 3, 9, 4, 0 }, 4, new int[] { 4 })]
        [InlineData(new int[] { 5, 2, 3, 8, 7 }, 8, new int[] { 8 })]
        public void FindTwoSum_NumberExist_ReturnsArrayWithOneElement(int[] array, int target, int[] expectedResult)
        {
            //Arrange && Act
            int[] result = TwoSum.FindTwoSum(array, target);

            //Assert
            result.Should().Equal(expectedResult);
        }

        [Theory]
        [InlineData(new int[] { 6, 2, 4 }, 9, new int[] { })]
        [InlineData(new int[] { 2, 1, 3, 9, 7 }, 45, new int[] { })]
        public void FindTwoSum_NumberNotExist_ReturnsEmptyArray(int[] array, int target, int[] expectedResult)
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
    }
}
