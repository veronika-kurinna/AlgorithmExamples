using AlgorithmExamples.Algorithms;

namespace AlgorithmExamples.Games
{
    public class FindIndices : IGame
    {
        public void Play()
        {
            int countNumbers = 5;
            Console.WriteLine($"Write {countNumbers} numbers:");
            int[] array = new int[countNumbers];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = ConsoleReader.ReadNumber();
            }

            Console.WriteLine("Write number that must be sum of two written numbers. Program will find indices of these numbers");
            int number = ConsoleReader.ReadNumber();
            int[] numbers = TwoSum.FindTwoSum(array, number);
            if (numbers.Length == 0)
            {
                Console.WriteLine("Selected sum doesn't exist in array");
            }
            else
            {
                Console.WriteLine($"Indices:");
                foreach (var item in numbers)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
