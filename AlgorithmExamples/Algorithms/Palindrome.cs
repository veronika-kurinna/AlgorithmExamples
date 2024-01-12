namespace AlgorithmExamples.Algorithms
{
    public static class Palindrome
    {
        public static bool IsPalindrome(string word)
        {
            if (string.IsNullOrWhiteSpace(word))
            {
                throw new ArgumentException("Value is invalid. Word must have letters");
            }

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
