using AlgorithmExamples.Algorithms;

namespace AlgorithmExamples.Games
{
    public class GameFactory
    {
        private readonly ISelectElements _selectElements;
        private readonly IBinarySearch _binarySearch;
        private readonly ITheBiggestNumber _theBiggestNumber;
        private readonly IPalindrome _palindrome;

        public GameFactory(ISelectElements selectElements, IBinarySearch binarySearch, ITheBiggestNumber theBiggestNumber, IPalindrome palindrome)
        {
            _selectElements = selectElements;
            _binarySearch = binarySearch;
            _theBiggestNumber = theBiggestNumber;
            _palindrome = palindrome;
        }

        public IGame CreateGame(string gameName)
        {
            switch (gameName.ToLower())
            {
                case "trainingprogramming":
                    return new TrainingProgramming(_selectElements);
                case "guessnumber":
                    return new GuessPositionNumber(_binarySearch);
                case "findthebiggestnumber":
                    return new FindTheBiggestNumber(_theBiggestNumber);
                case "guesspalindrome":
                    return new GuessPalindrome(_palindrome);
                default:
                    throw new ArgumentException("Invalid game specified");
            }
        }
    }
}
