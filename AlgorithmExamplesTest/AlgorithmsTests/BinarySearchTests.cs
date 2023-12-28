using AlgorithmExamples.Algorithms;
using FluentAssertions;
using Xunit;

namespace AlgorithmExamplesTest.AlgorithmsTests
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
            //Arrange && Act
            int result = BinarySearch.Search(array, element);

            //Assert
            result.Should().Be(expectedResult);
        }

        [Fact]
        public void Search_ValueIsNotInArray_ReturnsMinusOne()
        {
            //Arrange
            int[] numbers = { 57, 68, 75, 84, 96 };

            //Act
            int index = BinarySearch.Search(numbers, 567);

            //Assert
            index.Should().Be(-1);
        }

        [Fact]
        public void Search_TwoIdenticalValue_ReturnsFirstIndexValue()
        {
            //Arrange
            int[] numbers = { 57, 57, 68, 75, 84 };

            //Act
            int index = BinarySearch.Search(numbers, 57);

            //Assert
            index.Should().Be(0);
        }

        [Fact]
        public void Search_OneElement_ReturnsIndexValue()
        {
            //Arrange
            int[] numbers = { 57 };

            //Act
            int index = BinarySearch.Search(numbers, 57);

            //Assert
            index.Should().Be(0);
        }
    }
}
