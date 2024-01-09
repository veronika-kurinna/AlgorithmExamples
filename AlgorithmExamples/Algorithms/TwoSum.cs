namespace AlgorithmExamples.Algorithms
{
    public static class TwoSum
    {
        public static int[] FindTwoSum(int[] array, int target)
        {
            Dictionary<int, int> dictionary = new Dictionary<int, int>();
            for (int firstNumber = 0; firstNumber < array.Length; firstNumber++)
            {
                int secondNumber = target - array[firstNumber];
                if (dictionary.ContainsKey(secondNumber))
                {
                    return new int[] { dictionary[secondNumber], firstNumber};
                }
                else
                {
                    dictionary[array[firstNumber]] = firstNumber;
                }
            }
            return new int[0];
        }
    }
}
