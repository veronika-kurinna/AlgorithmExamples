namespace AlgorithmExamples.Algorithms
{
    public class Palindrome : IPalindrome
    {
        public bool IsWordPalindrome(string word)
        {
            int leftIndex = 0;
            int rightIndex = word.Length - 1;
            while (rightIndex > leftIndex)
            {
                if (word[leftIndex] == word[rightIndex])
                {
                    leftIndex++;
                    rightIndex--;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
    }
}
