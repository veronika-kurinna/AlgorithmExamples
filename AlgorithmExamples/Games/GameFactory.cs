using AlgorithmExamples.Algorithms;

namespace AlgorithmExamples.Games
{
    public class GameFactory
    {
        private readonly ISelectElements _selectElements;
        private readonly IBinarySearch _binarySearch;

        public GameFactory(ISelectElements selectElements, IBinarySearch binarySearch)
        {
            _selectElements = selectElements;
            _binarySearch = binarySearch;
        }

        public IGame CreateGame(string gameName)
        {
            switch (gameName.ToLower())
            {
                case "trainingprogramming":
                    return new TrainingProgramming(_selectElements);
                case "guessnumber":
                    return new GuessPositionNumber(_binarySearch);
                default:
                    throw new ArgumentException("Invalid game specified");
            }
        }
    }
}
