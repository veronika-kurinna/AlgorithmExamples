namespace AlgorithmExamples.Algorithms
{
    public static class TwoSum
    {
        public static int[] FindTwoSum(int[] array, int target)
        {
            if (array.Length == 0)
            {
                throw new ArgumentException("Array is empty");
            }
            if (array.Length == 1)
            {
                throw new ArgumentException("Array has only 1 number");
            }

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
