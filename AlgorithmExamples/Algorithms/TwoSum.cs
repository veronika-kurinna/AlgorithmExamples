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
            for (int i = 0; i < array.Length; i++)
            {
                int number = target - array[i];
                if (dictionary.ContainsKey(number))
                {
                    return new int[] { number, array[i] };
                }
                else
                {
                    dictionary[array[i]] = i;
                }
            }

            int halfTarget = target / 2;
            if (dictionary.ContainsKey(halfTarget))
            {
                return new int[] { halfTarget, halfTarget };
            }
            return new int[0];
        }
    }
}
