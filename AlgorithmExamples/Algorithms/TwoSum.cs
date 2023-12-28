namespace AlgorithmExamples.Algorithms
{
    public class TwoSum : ITwoSum
    {
        public int[] FindTwoSum(int[] array, int target)
        {
            Dictionary<int, int> dictionary = new Dictionary<int, int>();
            int[] result = new int[2];
            for (int firstNumber = 0; firstNumber < array.Length; firstNumber++)
            {
                int secondNumber = target - array[firstNumber];
                if (dictionary.ContainsKey(secondNumber))
                {
                    result[0] = dictionary[secondNumber];
                    result[1] = firstNumber;
                }
                else
                {
                    dictionary[array[firstNumber]] = firstNumber;
                }
            }
            return result;
        }
    }
}
