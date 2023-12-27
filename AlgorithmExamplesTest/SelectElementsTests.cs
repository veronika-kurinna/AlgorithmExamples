using AlgorithmExamples.Algorithms;
using FluentAssertions;
using Xunit;

namespace AlgorithmExamplesTest
{
    public class SelectElementsTests
    {
        [Fact]
        public void Select_CountElementsLessThanZero_ThrowsArgumentException()
        {
            // Arrange
            SelectElements randomElements = new SelectElements();
            int countElements = -3;
            List<string> elements = new List<string>
            {
                "What is an aggregate function in SQL?",
                "What is ACID?"
            };

            // Act && Assert
            Func<List<string>> action = () => randomElements.Select(elements, countElements);
            action.Should().Throw<ArgumentException>()
                           .WithMessage($"Count of elements {countElements} is invalid. Count must be more than zero");
        }

        [Fact]
        public void Select_CountElementsMoreThanCountElementsInList_ThrowsArgumentException()
        {
            // Arrange
            SelectElements randomElements = new SelectElements();
            int countElements = 5;
            List<string> elements = new List<string>
            {
                "What is an aggregate function in SQL?",
                "What is ACID?"
            };

            // Act && Assert
            Func<List<string>> action = () => randomElements.Select(elements, countElements);
            action.Should().Throw<ArgumentException>()
                           .WithMessage($"Count of elements {countElements} is invalid. Count must be less than elements in array");
        }

        [Theory]
        [InlineData(1)]
        [InlineData(3)]
        public void Select_CountElementsMoreThanZero_ReturnsListCorrectly(int countElements)
        {
            // Arrange
            SelectElements randomElements = new SelectElements();
            List<string> elements = new List<string>
            {
                "What is an aggregate function in SQL?",
                "What is the difference between Primary key and Unique?",
                "What is ACID?"
            };

            // Act
            List<string> result = randomElements.Select(elements, countElements);

            // Assert
            result.Should().HaveCount(countElements);
        }

        [Fact]
        public void Select_CallMethod1000Times_ReturnsListsCorrectly()
        {
            // Arrange
            SelectElements randomElements = new SelectElements();
            int countElements = 3;
            List<string> elements = new List<string>
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
                List<string> result = randomElements.Select(elements, countElements);
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
