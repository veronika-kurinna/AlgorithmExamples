using AlgorithmExamples.Algorithms;

namespace AlgorithmExamples.Games
{
    public class GuessNumber : IGame
    {
        private readonly int[] _numbers = { 1, 3, 5, 8, 10, 11, 14, 17, 20, 23, 28, 32, 37, 40, 49};

        public void Play()
        {
            Console.WriteLine("Write number from 1 to 50. If this number is present in array, program will find position of number");
            string? selectedNumberString = Console.ReadLine();
            int selectedNumber = Convert.ToInt32(selectedNumberString);

            int index = BinarySearch.Search(_numbers, selectedNumber);
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
