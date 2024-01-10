using AlgorithmExamples.Games;

namespace AlgorithmExamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GameFactory factory = new GameFactory();

            while (true)
            {
                factory.SelectGame();

                Console.WriteLine("\n");
                Console.WriteLine("Do you want to play again?");
                Console.WriteLine("Yes - 1, No - any numbers");
                int answer = ConsoleReader.ReadNumber();
                if (answer == 1)
                {
                    Console.WriteLine("Great!");
                }
                else
                {
                    Console.WriteLine("See you next day");
                    break;
                }
            }
        }
    }
}