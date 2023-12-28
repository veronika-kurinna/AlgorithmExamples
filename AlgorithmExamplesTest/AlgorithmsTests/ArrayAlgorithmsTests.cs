using AlgorithmExamples.Algorithms;
using FluentAssertions;
using Xunit;

namespace AlgorithmExamplesTest.AlgorithmsTests
{
    public class ArrayAlgorithmsTests
    {
        [Theory]
        [InlineData(new int[] { 6, 9, 2, 8, 4 }, 2)]
        [InlineData(new int[] { 6, 1, -2, 8, -4 }, -4)]
        [InlineData(new int[] { -6, -1, -2, -8, -4 }, -8)]
        [InlineData(new int[] { 5, 5, 5, 5, 5 }, 5)]
        [InlineData(new int[] { 2 }, 2)]
        public void FindTheSmallestNumber_ArrayWithNumbers_ReturnsTheSmallestNumber(int[] array, int expectedResult)
        {
            //Arrange && Act
            int result = ArrayAlgorithms.FindTheSmallestNumber(array);

            //Assert
            result.Should().Be(expectedResult);
        }

        [Fact]
        public void FindTheSmallestNumber_ArrayIsEmpty_ThrowsArgumentException()
        {
            //Arrange
            int[] array = Array.Empty<int>();

            //Act && Assert
            Action act = () => ArrayAlgorithms.FindTheSmallestNumber(array);
            act.Should().Throw<ArgumentException>()
                        .WithMessage("Array is empty");
        }


        [Theory]
        [InlineData(new int[] { 6, 9, 2, 8, 4 }, 9)]
        [InlineData(new int[] { 6, 1, -2, 8, -4 }, 8)]
        [InlineData(new int[] { -6, -1, -2, -8, -4 }, -1)]
        [InlineData(new int[] { 5, 5, 5, 5, 5 }, 5)]
        [InlineData(new int[] { 2 }, 2)]
        public void FindTheBiggestNumber_ArrayWithNumbers_ReturnsTheBiggestNumber(int[] array, int expectedResult)
        {
            //Arrange && Act
            int result = ArrayAlgorithms.FindTheBiggestNumber(array);

            //Assert
            result.Should().Be(expectedResult);
        }

        [Fact]
        public void FindTheBiggestNumber_ArrayIsEmpty_ThrowsArgumentException()
        {
            //Arrange
            int[] array = Array.Empty<int>();

            //Act && Assert
            Action act = () => ArrayAlgorithms.FindTheBiggestNumber(array);
            act.Should().Throw<ArgumentException>()
                        .WithMessage("Array is empty");
        }

        [Theory]
        [InlineData(new int[] { 6, 9, 2, 8, 4 }, 29)]
        [InlineData(new int[] { 6, 9, -2, 8, -4 }, 17)]
        [InlineData(new int[] { -6, -9, -2, -8, -4 }, -29)]
        [InlineData(new int[] { 2 }, 2)]
        [InlineData(new int[] { 5, 5, 5, 5 }, 20)]
        public void FindSum_ArrayWithNumbers_ReturnsSum(int[] array, int expectedResult)
        {
            //Arrange && Act
            int result = ArrayAlgorithms.FindSum(array);

            //Assert
            result.Should().Be(expectedResult);
        }

        [Fact]
        public void FindSum_ArrayIsEmpty_ThrowsArgumentException()
        {
            //Arrange
            int[] array = Array.Empty<int>();

            //Act && Assert
            Action act = () => ArrayAlgorithms.FindSum(array);
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
