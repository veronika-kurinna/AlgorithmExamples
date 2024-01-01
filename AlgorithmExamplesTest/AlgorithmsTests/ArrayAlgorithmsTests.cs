using AlgorithmExamples.Algorithms;
using FluentAssertions;
using Xunit;

namespace AlgorithmExamplesTest.AlgorithmsTests
{
    public class ArrayAlgorithmsTests
    {
        [Theory]
        [InlineData(new int[] { 6, 9, 2, 8, 4 }, 29, 2, 9)]
        [InlineData(new int[] { 6, 1, -2, 8, -4 }, 9, -4, 8)]
        [InlineData(new int[] { -6, -1, -2, -8, -4 }, -21, -8, -1)]
        [InlineData(new int[] { 5, 5, 5, 5, 5 }, 25, 5, 5)]
        [InlineData(new int[] { 2 }, 2, 2, 2)]
        public void GetArrayInfo_ArrayWithNumbers_ReturnsInfoCorrectly
                    (int[] array, int expectedSum, int expectedSmallestNumber, int expectedBiggestNumber)
        {
            //Arrange && Act
            ArrayInfo result = ArrayAlgorithms.GetArrayInfo(array);

            //Assert
            result.Sum.Should().Be(expectedSum);
            result.TheSmallestNumber.Should().Be(expectedSmallestNumber);
            result.TheBiggestNumber.Should().Be(expectedBiggestNumber);
        }

        [Fact]
        public void GetArrayInfo_ArrayIsEmpty_ThrowsArgumentException()
        {
            //Arrange
            int[] array = Array.Empty<int>();

            //Act && Assert
            Action act = () => ArrayAlgorithms.GetArrayInfo(array);
            act.Should().Throw<ArgumentException>()
                        .WithMessage("Array is empty");
        }

        [Theory]
        [InlineData(new int[] { 6, 9, 2, -8, 4 })]
        [InlineData(new int[] { 1, 2, 5, 3, 4 })]
        [InlineData(new int[] { 1, 2, 3, 4 })]
        [InlineData(new int[] { 6 })]
        [InlineData(new int[] { 3, 7, 4, 2, 5, 4 })]
        public void SortElementsBubble_NumbersOutOfOrder_ReturnsNumberInOrder(int[] array)
        {
            //Arrange && Act
            ArrayAlgorithms.SortElementsBubble(array);

            //Assert
            array.Should().BeInAscendingOrder();
        }

        [Fact]
        public void SortElementsBubble_ArrayIsEmpty_ThrowsArgumentException()
        {
            //Arrange
            int[] array = Array.Empty<int>();

            //Act && Assert
            Action act = () => ArrayAlgorithms.SortElementsBubble(array);
            act.Should().Throw<ArgumentException>()
                        .WithMessage("Array is empty");
        }
    }
}
