using AlgorithmExamples.Models;

namespace AlgorithmExamples.Algorithms
{
    public static class ArrayAlgorithms
    {
        public static ArrayInfo GetArrayInfo(int[] array)
        {
            if (array.Length == 0)
            {
                throw new ArgumentException("Array is empty");
            }
            int sum = 0;
            int theSmallestNumber = array[0];
            int theBiggestNumber = array[0];

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < theSmallestNumber)
                {
                    theSmallestNumber = array[i];
                }
                if (array[i] > theBiggestNumber)
                {
                    theBiggestNumber = array[i];
                }
                sum += array[i];
            }
            return new ArrayInfo()
            {
                SmallestNumber = theSmallestNumber,
                BiggestNumber = theBiggestNumber,
                Sum = sum
            };
        }

        public static void BubbleSort(int[] array)
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
