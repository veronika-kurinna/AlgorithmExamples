using AlgorithmExamples.Algorithms;

namespace AlgorithmExamples.Games
{
    public class GuessPositionNumber : IGame
    {
        private readonly int[] _numbers = { 1, 3, 5, 8, 10, 11, 14, 17, 20, 23, 34, 45, 52, 63, 78};
        private readonly IBinarySearch _binarySearch;

        public GuessPositionNumber(IBinarySearch binarySearch)
        {
            _binarySearch = binarySearch;
        }

        public void Play()
        {
            Console.WriteLine("Select number and program will find position of this number:");
            foreach (var item in _numbers)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Write selected number:");
            string? selectedNumberString = Console.ReadLine();
            int selectedNumber = Convert.ToInt32(selectedNumberString);

            int index = _binarySearch.Search(_numbers, selectedNumber);
            if (index == -1)
            {
                Console.WriteLine("Selected number doesn't exist in array");
            }
            Console.WriteLine($"The position of selected number is {index}");
        }
    }
}
