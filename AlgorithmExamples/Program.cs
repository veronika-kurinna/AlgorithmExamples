using AlgorithmExamples.Games;

namespace AlgorithmExamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GameFactory factory = new GameFactory();

            Console.WriteLine("Select the game (TrainingProgramming, GuessNumber, PlayWithArray, GuessPalindrome, FindIndices):");
            string? gameName = Console.ReadLine();
            Console.WriteLine("\n");

            try
            {
                IGame game = factory.CreateGame(gameName!);
                game.Play();
            }
            catch (ArgumentException exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
}