﻿namespace AlgorithmExamples.Algorithms
{
    public static class SelectElements
    {
        public static List<T> Select<T>(List<T> list, int countElements)
        {
            if (countElements < 0)
            {
                throw new ArgumentException($"Count of elements {countElements} is invalid. Count must be more than zero");
            }
            if (countElements > list.Count)
            {
                throw new ArgumentException($"Count of elements {countElements} is invalid. Count must be less than elements in array");
            }

            Random random = new Random();
            int countSelectedElements = 0;
            List<T> selectedElements = new List<T>();

            for (int i = 0; i < list.Count; i++)
            {
                int randomNumber = random.Next(list.Count - i);
                if (randomNumber < countElements - countSelectedElements)
                {
                    selectedElements.Add(list[i]);
                    countSelectedElements++;
                }
                if (countSelectedElements == countElements)
                {
                    break;
                }
            }
            return selectedElements;
        }
    }
}
