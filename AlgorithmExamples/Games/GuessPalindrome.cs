using AlgorithmExamples.Algorithms;

namespace AlgorithmExamples.Games
{
    public class GuessPalindrome : IGame
    {
        public void Play()
        {
            Console.WriteLine("Write palindrome word and program will check is it palindrome or not:");
            string? word = Console.ReadLine();
            if (Palindrome.IsPalindrome(word!))
            {
                Console.WriteLine($"{word} is palindrome.");
            }
            else
            {
                Console.WriteLine($"{word} isn't palindrome.");
            }
        }
    }
}
