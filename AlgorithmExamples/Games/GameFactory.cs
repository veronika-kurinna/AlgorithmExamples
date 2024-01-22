namespace AlgorithmExamples.Games
{
    public class GameFactory
    {
        public Dictionary<string, IGame> games = new Dictionary<string, IGame>
        {
            {"trainingprogramming", new TrainingProgramming() },
            {"guessnumber", new GuessNumber() },
            {"playwitharray", new PlayWithArray() },
            {"guesspalindrome", new GuessPalindrome() },
            {"buywater", new BuyWater() }
        };

        public string[] GameNames { 
            get
            {
                return games.Keys.ToArray();
            }
        }

        public IGame CreateGame(string gameName)
        {
            if (games.ContainsKey(gameName.ToLower()))
            {
                return games[gameName.ToLower()];
            }
            throw new ArgumentException("Invalid game specified");
        }
    }
}
