namespace AlgorithmExamples.Algorithms
{
    public class RandomElements
    {
        public string[] SelectElements(string[] array, int countElements)
        {
            if (array.Length == 0)
            {
                throw new ArgumentException("Array is empty");
            }
            if (countElements < 0)
            {
                throw new ArgumentException($"Count of elements {countElements} is invalid. Count must be more than zero");
            }
            if (countElements > array.Length)
            {
                throw new ArgumentException($"Count of elements {countElements} is invalid. Count must be more than elements in array");
            }

            Random random = new Random();
            int countSelectedElements = 0;
            string[] selectedElements = new string[countElements];

            for (int i = 0; i < array.Length; i++)
            {
                int randomNumber = random.Next(array.Length - i);
                if (randomNumber < countElements - countSelectedElements)
                {
                    selectedElements[countSelectedElements] = array[i];
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
