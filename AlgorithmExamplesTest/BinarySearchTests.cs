using AlgorithmExamples.Algorithms;
using FluentAssertions;
using Xunit;

namespace AlgorithmExamplesTest
{
    public class BinarySearchTests
    {
        [Theory]
        [InlineData(new int[] { 57, 68, 75, 84, 96 }, 57, 0)]
        [InlineData(new int[] { 57, 68, 75, 84, 96 }, 68, 1)]
        [InlineData(new int[] { 57, 68, 75, 84, 96 }, 75, 2)]
        [InlineData(new int[] { 57, 68, 75, 84, 96 }, 84, 3)]
        public void Search_ValueIsInArray_ReturnsIndex(int[] array, int element, int expectedResult)
        {
            //Arrange
            BinarySearch binarySearch = new BinarySearch();

            //Act
            int result = binarySearch.Search(array, element);

            //Assert
            result.Should().Be(expectedResult);
        }

        [Fact]
        public void Search_ValueIsNotInArray_ReturnsMinusOne()
        {
            //Arrange
            BinarySearch binarySearch = new BinarySearch();
            int[] numbers = { 57, 68, 75, 84, 96 };

            //Act
            int index = binarySearch.Search(numbers, 567);

            //Assert
            index.Should().Be(-1);
        }

        [Fact]
        public void Search_TwoIdenticalValue_ReturnsFirstIndexValue()
        {
            //Arrange
            BinarySearch binarySearch = new BinarySearch();
            int[] numbers = { 57, 57, 68, 75, 84 };

            //Act
            int index = binarySearch.Search(numbers, 57);

            //Assert
            index.Should().Be(0);
        }

        [Fact]
        public void Search_OneElement_ReturnsIndexValue()
        {
            //Arrange
            BinarySearch binarySearch = new BinarySearch();
            int[] numbers = { 57 };

            //Act
            int index = binarySearch.Search(numbers, 57);

            //Assert
            index.Should().Be(0);
        }
    }
}
