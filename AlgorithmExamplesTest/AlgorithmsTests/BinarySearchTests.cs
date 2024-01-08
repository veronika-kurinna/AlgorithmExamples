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
        [InlineData(new int[] { 57, 68, 75, 84, 96 }, 96, 4)]
        public void Search_OddCountElementsInArray_ReturnsIndex(int[] array, int element, int expectedResult)
        {
            //Arrange && Act
            int result = BinarySearch.Search(array, element);

            //Assert
            result.Should().Be(expectedResult);
        }

        [Theory]
        [InlineData(new int[] { 57, 68, 75, 84 }, 57, 0)]
        [InlineData(new int[] { 57, 68, 75, 84 }, 68, 1)]
        [InlineData(new int[] { 57, 68, 75, 84 }, 75, 2)]
        [InlineData(new int[] { 57, 68, 75, 84 }, 84, 3)]
        public void Search_EvenCountElementsInArray_ReturnsIndex(int[] array, int element, int expectedResult)
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
        public void Search_ArrayIsEmpty_ReturnsMinusOne()
        {
            //Arrange
            int[] numbers = Array.Empty<int>();

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
    }
}
