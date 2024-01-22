namespace AlgorithmExamples.Games
{
    public class GameFactory
    {
        public Dictionary<string, IGame> games = new Dictionary<string, IGame>(StringComparer.OrdinalIgnoreCase)
        {
            {"TrainingProgramming", new TrainingProgramming() },
            {"GuessNumber", new GuessNumber() },
            {"PlayWithArray", new PlayWithArray() },
            {"GuessPalindrome", new GuessPalindrome() },
            {"BuyWater", new BuyWater() }
        };

        public string[] GameNames { 
            get
            {
                return games.Keys.ToArray();
            }
        }

        public IGame CreateGame(string gameName)
        {
            if (games.ContainsKey(gameName))
            {
                return games[gameName];
            }
            throw new ArgumentException("Invalid game specified");
        }
    }
}
