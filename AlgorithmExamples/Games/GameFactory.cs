using AlgorithmExamples.Algorithms;

namespace AlgorithmExamples.Games
{
    public class GameFactory
    {
        public IGame CreateGame(string gameName)
        {
            switch (gameName.ToLower())
            {
                case "trainingprogramming":
                    return new TrainingProgramming();
                case "guessnumber":
                    return new GuessPositionNumber();
                case "findthebiggestnumber":
                    return new FindTheBiggestNumber();
                default:
                    throw new ArgumentException("Invalid game specified");
            }
        }
    }
}
