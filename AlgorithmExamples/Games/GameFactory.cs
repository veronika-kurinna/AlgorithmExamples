using AlgorithmExamples.Algorithms;

namespace AlgorithmExamples.Games
{
    public class GameFactory
    {
        private readonly ISelectElements _selectElements;

        public GameFactory(ISelectElements selectElements)
        {
            _selectElements = selectElements;
        }

        public IGame CreateGame(string gameName)
        {
            switch (gameName.ToLower())
            {
                case "trainingprogramming":
                    return new TrainingProgramming(_selectElements);
                default:
                    throw new ArgumentException("Invalid game specified");
            }
        }
    }
}
