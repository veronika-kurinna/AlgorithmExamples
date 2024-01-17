using AlgorithmExamples.Algorithms;
using AlgorithmExamples.Models;
using FluentAssertions;
using Xunit;

namespace AlgorithmExamplesTest.AlgorithmsTests
{
    public class TwoSumTests
    {
        [Fact]
        public void FindBottles_TwoBottlesExist_ReturnsArrayWithTwoElementsCorrectly()
        {
            //Arrange
            BottleOfWater[] bottlesOfWater =
            {
                new() { Volume = 1, Price = 18.7m },
                new() { Volume = 3, Price = 45.5m },
                new() { Volume = 5, Price = 60.8m },
                new() { Volume = 10, Price = 110m },
                new() { Volume = 18, Price = 200m },
            };
            int target = 15;

            //Act
            BottleOfWater[] result = TwoSum.FindBottles(bottlesOfWater, target);

            //Assert
            result.Should().Satisfy(b => b.Volume == 5 && b.Price == 60.8m,
                                    b => b.Volume == 10 && b.Price == 110m);
        }

        [Fact]
        public void FindBottles_OneBottleExist_ReturnsArrayWithTwoElementsCorrectly()
        {
            //Arrange
            BottleOfWater[] bottlesOfWater =
            {
                new() { Volume = 1, Price = 18.7m },
                new() { Volume = 3, Price = 45.5m },
                new() { Volume = 5, Price = 60.8m },
                new() { Volume = 10, Price = 110m },
                new() { Volume = 18, Price = 200m },
            };
            int target = 2;

            //Act
            BottleOfWater[] result = TwoSum.FindBottles(bottlesOfWater, target);

            //Assert
            result.Should().Satisfy(b => b.Volume == 1 && b.Price == 18.7m,
                                    b => b.Volume == 1 && b.Price == 18.7m);
        }

        [Fact]
        public void FindBottles_OneBottleExist_ReturnsArrayWithOneElementCorrectly()
        {
            //Arrange
            BottleOfWater[] bottlesOfWater =
            {
                new() { Volume = 1, Price = 18.7m },
                new() { Volume = 3, Price = 45.5m },
                new() { Volume = 5, Price = 60.8m },
                new() { Volume = 10, Price = 110m },
                new() { Volume = 18, Price = 200m },
            };
            int target = 5;

            //Act
            BottleOfWater[] result = TwoSum.FindBottles(bottlesOfWater, target);

            //Assert
            result.Should().Satisfy(b => b.Volume == 5 && b.Price == 60.8m);
        }

        [Fact]
        public void FindBottles_BottlesNotExist_ReturnsEmptyArray()
        {
            //Arrange
            BottleOfWater[] bottlesOfWater =
            {
                new() { Volume = 1, Price = 18.7m },
                new() { Volume = 3, Price = 45.5m },
                new() { Volume = 5, Price = 60.8m },
                new() { Volume = 10, Price = 110m },
                new() { Volume = 18, Price = 200m },
            };
            int target = 22;

            //Act
            BottleOfWater[] result = TwoSum.FindBottles(bottlesOfWater, target);

            //Assert
            result.Should().BeEmpty();
        }

        [Fact]
        public void FindBottles_ArrayIsEmpty_ThrowsArgumentException()
        {
            //Arrange
            BottleOfWater[] bottlesOfWater = { };
            int target = 7;

            //Act && Assert
            Action action = () => TwoSum.FindBottles(bottlesOfWater, target);
            action.Should().Throw<ArgumentException>()
                           .WithMessage("Array is empty");
        }

        [Fact]
        public void FindBottles_NumberLessThanZero_ThrowsArgumentException()
        {
            //Arrange
            BottleOfWater[] bottlesOfWater =
            {
                new() { Volume = 1, Price = 18.7m },
                new() { Volume = 3, Price = 45.5m },
                new() { Volume = 5, Price = 60.8m },
                new() { Volume = 10, Price = 110m },
                new() { Volume = 18, Price = 200m },
            };
            int target = -7;

            //Act && Assert
            Action action = () => TwoSum.FindBottles(bottlesOfWater, target);
            action.Should().Throw<ArgumentException>()
                           .WithMessage($"Value {target} is invalid. Value must be more than zero");
        }
    }
}
