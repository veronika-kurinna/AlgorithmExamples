using AlgorithmExamples.Algorithms;
using FluentAssertions;
using Xunit;

namespace AlgorithmExamplesTest
{
    public class TwoSumTests
    {
        [Theory]
        [InlineData(new int[] {2, 7, 11, 15}, 9, new int[] { 0, 1})]
        [InlineData(new int[] {3, 2, 4}, 6, new int[] { 1, 2})]
        [InlineData(new int[] {3, 3}, 6, new int[] { 0, 1})]
        public void FindTwoSum_Numbers_ReturnsArrayCorrectly(int[] array, int target, int[] expectedResult)
        {
            //Arrange
            TwoSum twoSum = new TwoSum();

            //Act
            int[] result = twoSum.FindTwoSum(array, target);

            //Assert
            result.Should().Equal(expectedResult);
        }
    }
}
