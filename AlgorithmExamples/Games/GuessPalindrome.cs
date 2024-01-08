using AlgorithmExamples.Algorithms;

namespace AlgorithmExamples.Games
{
    public class GuessPalindrome : IGame
    {
        public void Play()
        {
            Console.WriteLine("Write palindrome word and program will check is it palindrome or not:");
            string? word = Console.ReadLine();
            bool isPalindrome = Palindrome.IsWordPalindrome(word!);
            if (isPalindrome)
            {
                Console.WriteLine("This word is palindrome.");
            }
            else
            {
                Console.WriteLine("This word isn't palindrome.");
            }
        }
    }
}
