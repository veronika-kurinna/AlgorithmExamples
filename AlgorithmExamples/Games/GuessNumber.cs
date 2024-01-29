using AlgorithmExamples.Algorithms;
using AlgorithmExamples.Helper;

namespace AlgorithmExamples.Games
{
    public class GuessNumber : IGame
    {
        public void Play()
        {
            Random random = new Random();
            int[] numbers = new int[15];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(0, 50);
            }
            ArrayAlgorithms.BubbleSort(numbers);

            Console.WriteLine("Write number from 1 to 50. If this number is present in array, program will find position of number");
            int number = ConsoleReader.ReadNumber();
            int index = BinarySearch.Search(numbers, number);
            if (index == -1)
            {
                Console.WriteLine("Selected number doesn't exist in array");
            }
            else
            {
                Console.WriteLine($"Selected number is present in array. The position of number is {index}");
            }
        }
    }
}
