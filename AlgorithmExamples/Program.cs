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
            Palindrome palindrome = new Palindrome();
            TwoSum twoSum = new TwoSum();

            GameFactory factory = new GameFactory(selectElements, binarySearch, theBiggestNumber, palindrome, twoSum);

            Console.WriteLine("Select the game (TrainingProgramming, GuessNumber, FindTheBiggestNumber, GuessPalindrome, FindNumbers):");
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