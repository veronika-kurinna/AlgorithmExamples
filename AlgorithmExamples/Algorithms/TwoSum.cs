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

            Dictionary<int, int> dictionary = new Dictionary<int, int>();
            for (int i = 0; i < array.Length; i++)
            {
                dictionary[array[i]] = i;
            }

            if (dictionary.ContainsKey(target))
            {
                return new int[] { target };
            }

            for (int i = 0; i < array.Length; i++)
            {
                int number = target - array[i];
                if (dictionary.ContainsKey(number))
                {
                    return new int[] { array[i], number };
                }
            }
            return new int[0];
        }
    }
}
