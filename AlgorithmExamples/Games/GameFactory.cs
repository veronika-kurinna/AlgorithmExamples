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
                    return new GuessNumber();
                case "playwitharray":
                    return new PlayWithArray();
                case "guesspalindrome":
                    return new GuessPalindrome();
                case "buywater":
                    return new BuyWater();
                default:
                    throw new ArgumentException("Invalid game specified");
            }
        }

        public void SelectGame()
        {
            Console.WriteLine("Select the game (TrainingProgramming, GuessNumber, PlayWithArray, GuessPalindrome, BuyWater):");
            string? gameName = Console.ReadLine();
            Console.WriteLine("\n");

            try
            {
                IGame game = CreateGame(gameName!);
                game.Play();
            }
            catch (ArgumentException exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
}
