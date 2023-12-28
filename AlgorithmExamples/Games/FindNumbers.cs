using AlgorithmExamples.Algorithms;

namespace AlgorithmExamples.Games
{
    public class FindNumbers : IGame
    {
        private readonly ITwoSum _twoSum;

        public FindNumbers(ITwoSum twoSum)
        {
            _twoSum = twoSum;
        }

        public void Play()
        {
            Console.WriteLine("Write 3 numbers");
            string? firstNumberString = Console.ReadLine();
            int firstNumber = Convert.ToInt32(firstNumberString);
            string? secondNumberString = Console.ReadLine();
            int secondNumber = Convert.ToInt32(secondNumberString);
            string? thirdNumberString = Console.ReadLine();
            int thirdNumber = Convert.ToInt32(thirdNumberString);

            int[] array = { firstNumber, secondNumber, thirdNumber };

            Console.WriteLine("Write number what must be sum of two written numbers. Program will find positions of these numbers");
            string? numberString = Console.ReadLine();
            int number = Convert.ToInt32(numberString);

            int[] numbers = _twoSum.FindTwoSum(array, number);
            Console.WriteLine($"Numbers:");
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }
        }
    }
}
