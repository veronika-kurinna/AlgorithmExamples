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
                Console.WriteLine("Select the game:");
                foreach (var item in factory.GameNames)
                {
                    Console.WriteLine(item);
                }
                
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

                Console.WriteLine("\n");
                Console.WriteLine("Do you want to play again?");
                Console.WriteLine("Yes - 1, No - any numbers");
                int answer = ConsoleReader.ReadNumber();
                Console.WriteLine("\n");
                if (answer == 1)
                {
                    Console.Clear();
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