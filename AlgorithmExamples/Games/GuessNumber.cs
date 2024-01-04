using AlgorithmExamples.Algorithms;

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
                int randomNumber = random.Next(0, 50);
                numbers[i] = randomNumber;
            }
            ArrayAlgorithms.BubbleSort(numbers);

            int countNumbers = 1;
            Console.WriteLine("Write number from 1 to 50. If this number is present in array, program will find position of number");
            int[] array = Game.ReadNumber(countNumbers);

            int index = BinarySearch.Search(numbers, array[0]);
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
