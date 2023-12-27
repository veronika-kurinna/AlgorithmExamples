using AlgorithmExamples.Algorithms;
using AlgorithmExamples.Games;

namespace AlgorithmExamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SelectElements selectElements = new SelectElements();
            BinarySearch binarySearch = new BinarySearch();
            TheBiggestNumber theBiggestNumber = new TheBiggestNumber();

            GameFactory factory = new GameFactory(selectElements, binarySearch, theBiggestNumber);

            Console.WriteLine("Select the game (TrainingProgramming, GuessNumber, FindTheBiggestNumber):");
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