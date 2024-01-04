using AlgorithmExamples.Algorithms;
using FluentAssertions;
using Xunit;

namespace AlgorithmExamplesTest.AlgorithmsTests
{
    public class SelectElementsTests
    {
        [Fact]
        public void Select_CountElementsLessThanZero_ThrowsArgumentException()
        {
            // Arrange
            int countElements = -3;
            List<string> elements = new List<string>
            {
                "What is an aggregate function in SQL?",
                "What is ACID?"
            };

            // Act && Assert
            Func<List<string>> action = () => SelectElements.Select(elements, countElements);
            action.Should().Throw<ArgumentException>()
                           .WithMessage($"Count of elements {countElements} is invalid. Count must be more than zero");
        }

        [Fact]
        public void Select_CountElementsMoreThanCountElementsInList_ThrowsArgumentException()
        {
            // Arrange
            int countElements = 5;
            List<string> elements = new List<string>
            {
                "What is an aggregate function in SQL?",
                "What is ACID?"
            };

            // Act && Assert
            Func<List<string>> action = () => SelectElements.Select(elements, countElements);
            action.Should().Throw<ArgumentException>()
                           .WithMessage($"Count of elements {countElements} is invalid. Count must be less than elements in array");
        }

        [Fact]
        public void Select_CountElementsMoreThanZero_ReturnsListCorrectly()
        {
            // Arrange
            int countElements = 1;
            List<string> elements = new List<string>
            {
                "What is an aggregate function in SQL?",
                "What is the difference between Primary key and Unique?",
                "What is ACID?"
            };

            // Act
            List<string> result = SelectElements.Select(elements, countElements);

            // Assert
            result.Should().AllSatisfy(e => elements.Should().Contain(e)).
                            And.OnlyHaveUniqueItems();
        }

        [Fact]
        public void Select_CountElementsTheSameAsCountElementsInList_ReturnsListCorrectly()
        {
            // Arrange
            int countElements = 3;
            List<string> elements = new List<string>
            {
                "What is an aggregate function in SQL?",
                "What is the difference between Primary key and Unique?",
                "What is ACID?"
            };

            // Act
            List<string> result = SelectElements.Select(elements, countElements);

            // Assert
            result.Should().AllSatisfy(e => elements.Should().Contain(e)).
                            And.OnlyHaveUniqueItems();
        }

        [Fact]
        public void Select_CallMethod1millionTimes_ReturnsListsCorrectly()
        {
            // Arrange
            int countElements = 3;
            List<string> elements = new List<string>
            {
                "What is an aggregate function in SQL?",
                "What is the difference between Primary key and Unique?",
                "What is ACID?",
                "What is SOLID?",
                "What is the difference between unit test and integration test?",
            };

            Dictionary<string, int> dictionary = new Dictionary<string, int>();

            // Act
            for (int i = 0; i < 1000000; i++)
            {
                List<string> result = SelectElements.Select(elements, countElements);

                foreach (var item in result)
                {
                    if (dictionary.ContainsKey(item))
                    {
                        dictionary[item]++;
                    }
                    else
                    {
                        dictionary.Add(item, 1);
                    }
                }
            }

            // Assert
            dictionary.Values.Should().OnlyContain(e => e > 599000 && e < 601000);
        }
    }
}
