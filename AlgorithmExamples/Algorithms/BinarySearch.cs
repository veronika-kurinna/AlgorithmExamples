namespace AlgorithmExamples.Algorithms
{
    public static class BinarySearch
    {
        public static int Search(int[] array, int searchedValue)
        {
            int minIndex = 0;
            int maxIndex = array.Length - 1;

            while (minIndex <= maxIndex)
            {
                int middle = minIndex + (maxIndex - minIndex) / 2;
                if (array[middle] == searchedValue)
                {
                    return middle;
                }
                else if (array[middle] > searchedValue)
                {
                    maxIndex = middle - 1;
                }
                else
                {
                    minIndex = middle + 1;
                }
            }
            return -1;
        }
    }
}
