﻿namespace AlgorithmExamples.Algorithms
{
    public static class TheBiggestNumber
    {
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
    }
}
