﻿using AlgorithmExamples.Games;
using FluentAssertions;
using Xunit;

namespace AlgorithmExamplesTest.GamesTests
{
    public class GameFactoryTests
    {
        [Theory]
        [InlineData("FindTheBiggestNumber")]
        [InlineData("findthebiggestnumber")]
        [InlineData("findtHebiggesTnumber")]
        public void CreateGame_FindTheBiggestNumber_ReturnsCorrectly(string game)
        {
            // Arrange
            GameFactory factory = new GameFactory();

            // Act
            IGame result = factory.CreateGame(game);

            // Assert
            result.Should().BeOfType<FindTheBiggestNumber>();
        }

        [Theory]
        [InlineData("GuessNumber")]
        [InlineData("guessnumber")]
        [InlineData("guesSnumbeR")]
        public void CreateGame_GuessPositionNumber_ReturnsCorrectly(string game)
        {
            // Arrange
            GameFactory factory = new GameFactory();

            // Act
            IGame result = factory.CreateGame(game);

            // Assert
            result.Should().BeOfType<GuessPositionNumber>();
        }

        [Theory]
        [InlineData("TrainingProgramming")]
        [InlineData("trainingprogramming")]
        [InlineData("tRainingproGramming")]
        public void CreateGame_TrainingProgramming_ReturnsCorrectly(string game)
        {
            // Arrange
            GameFactory factory = new GameFactory();

            // Act
            IGame result = factory.CreateGame(game);

            // Assert
            result.Should().BeOfType<TrainingProgramming>();
        }

        [Theory]
        [InlineData("")]
        [InlineData(" ")]
        [InlineData("trainingprogrammin")]
        [InlineData("rainingprogramming")]
        [InlineData("traininrogramming")]
        public void CreateGame_InvalidGame_ThrowsArgumentException(string game)
        {
            // Arrange
            GameFactory factory = new GameFactory();

            // Act && Assert
            Action action = () => factory.CreateGame(game);
            action.Should().Throw<ArgumentException>()
                            .WithMessage("Invalid game specified");
        }
    }
}
