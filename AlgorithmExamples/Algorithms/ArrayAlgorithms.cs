namespace AlgorithmExamples.Algorithms
{
    public static class ArrayAlgorithms
    {
        public static int FindTheSmallestNumber(int[] array)
        {
            if (array.Length == 0)
            {
                throw new ArgumentException("Array is empty");
            }

            int theSmallestNumber = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < theSmallestNumber)
                {
                    theSmallestNumber = array[i];
                }
            }
            return theSmallestNumber;
        }

        public static int FindTheBiggestNumber(int[] array)
        {
            if (array.Length == 0)
            {
                throw new ArgumentException("Array is empty");
            }

            int theBiggestNumber = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > theBiggestNumber)
                {
                    theBiggestNumber = array[i];
                }
            }
            return theBiggestNumber;
        }

        public static int FindSum(int[] array)
        {
            if (array.Length == 0)
            {
                throw new ArgumentException("Array is empty");
            }

            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            return sum;
        }

        public static void SortElementsBubble(int[] array)
        {
            if (array.Length == 0)
            {
                throw new ArgumentException("Array is empty");
            }

            for (int i = 0; i < array.Length; i++)
            {
                bool elementsSwapped = false;
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                        elementsSwapped = true;
                    }
                }

                bool isArraySorted = elementsSwapped == false;
                if (isArraySorted)
                {
                    break;
                }
            }
        }
    }
}
