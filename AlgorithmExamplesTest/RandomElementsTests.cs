using AlgorithmExamples.Algorithms;
using FluentAssertions;
using Xunit;

namespace AlgorithmExamplesTest
{
    public class RandomElementsTests
    {
        [Fact]
        public void SelectElements_ArrayIsEmpty_ThrowsArgumentException()
        {
            // Arrange
            RandomElements randomElements = new RandomElements();
            int countElements = 3;
            string[] elements = Array.Empty<string>();

            // Act && Assert
            Func<string[]> action = () => randomElements.SelectElements(elements, countElements);
            action.Should().Throw<ArgumentException>()
                           .WithMessage("Array is empty");
        }

        [Fact]
        public void SelectElements_CountElementsLessThanZero_ThrowsArgumentException()
        {
            // Arrange
            RandomElements randomElements = new RandomElements();
            int countElements = -3;
            string[] elements = new string[]
            {
                "What is an aggregate function in SQL?",
                "What is ACID?"
            };

            // Act && Assert
            Func<string[]> action = () => randomElements.SelectElements(elements, countElements);
            action.Should().Throw<ArgumentException>()
                           .WithMessage($"Count of elements {countElements} is invalid. Count must be more than zero");
        }

        [Fact]
        public void SelectElements_CountElementsMoreThanCountElementsInArray_ThrowsArgumentException()
        {
            // Arrange
            RandomElements randomElements = new RandomElements();
            int countElements = 5;
            string[] elements = new string[]
            {
                "What is an aggregate function in SQL?",
                "What is ACID?"
            };

            // Act && Assert
            Func<string[]> action = () => randomElements.SelectElements(elements, countElements);
            action.Should().Throw<ArgumentException>()
                           .WithMessage($"Count of elements {countElements} is invalid. Count must be more than elements in array");
        }

        [Fact]
        public void SelectElements_CountElementsMoreThanZero_ReturnsArrayCorrectly()
        {
            // Arrange
            RandomElements randomElements = new RandomElements();
            int countElements = 1;
            string[] elements = new string[]
            {
                "What is an aggregate function in SQL?",
                "What is the difference between Primary key and Unique?",
                "What is ACID?"
            };

            // Act
            string[] result = randomElements.SelectElements(elements, countElements);

            // Assert
            result.Should().HaveCount(countElements);
        }

        [Fact]
        public void SelectElements_CallMethod1000Times_ReturnsArraysCorrectly()
        {
            // Arrange
            RandomElements randomElements = new RandomElements();
            int countElements = 3;
            string[] elements = new string[]
            {
                "What is an aggregate function in SQL?",
                "What is the difference between Primary key and Unique?",
                "What is ACID?",
                "What is SOLID?",
                "What is the difference between unit test and integration test?",
            };
            Dictionary<string, int> dictionary = new Dictionary<string, int>
            {
                { "What is an aggregate function in SQL?", 0 },
                { "What is the difference between Primary key and Unique?", 0 },
                { "What is ACID?", 0 },
                { "What is SOLID?", 0 },
                { "What is the difference between unit test and integration test?", 0 }
            };

            // Act
            for (int i = 0; i < 1000; i++)
            {
                string[] result = randomElements.SelectElements(elements, countElements);
                foreach (var item in result)
                {
                    if (dictionary.ContainsKey(item))
                    {
                        dictionary[item]++;
                    }
                }
            }

            // Assert
            dictionary.Values.Should().OnlyContain(e => e > 550 && e < 650);
        }
    }
}
