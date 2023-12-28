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
                default:
                    throw new ArgumentException("Invalid game specified");
            }
        }
    }
}
