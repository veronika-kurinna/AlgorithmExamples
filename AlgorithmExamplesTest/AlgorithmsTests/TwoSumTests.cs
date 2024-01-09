using AlgorithmExamples.Algorithms;
using FluentAssertions;
using Xunit;

namespace AlgorithmExamplesTest.AlgorithmsTests
{
    public class TwoSumTests
    {
        [Theory]
        [InlineData(new int[] { 2, 7, 11, 15 }, 9, new int[] { 0, 1 })]
        [InlineData(new int[] { 3, 2, 4 }, 6, new int[] { 1, 2 })]
        [InlineData(new int[] { 3, 3 }, 6, new int[] { 0, 1 })]
        [InlineData(new int[] { 3, 4, 1, 7, 0 }, 7, new int[] { 0, 1 })]
        public void FindTwoSum_Numbers_ReturnsArrayCorrectly(int[] array, int target, int[] expectedResult)
        {
            //Arrange && Act
            int[] result = TwoSum.FindTwoSum(array, target);

            //Assert
            result.Should().Equal(expectedResult);
        }
    }
}
