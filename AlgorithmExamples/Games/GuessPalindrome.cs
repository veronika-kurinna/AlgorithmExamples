using AlgorithmExamples.Algorithms;

namespace AlgorithmExamples.Games
{
    public class GuessPalindrome : IGame
    {
        private readonly IPalindrome _palindrome;

        public GuessPalindrome(IPalindrome palindrome)
        {
            _palindrome = palindrome;
        }

        public void Play()
        {
            Console.WriteLine("Write palindrome word and program will check is it palindrome or not:");
            string? word = Console.ReadLine();
            bool isPalindrome = _palindrome.IsWordPalindrome(word!);
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
