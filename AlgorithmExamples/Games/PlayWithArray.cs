using AlgorithmExamples.Algorithms;

namespace AlgorithmExamples.Games
{
    public class PlayWithArray : IGame
    {
        public void Play()
        {
            Console.WriteLine("Write 5 numbers and computer will find the smallest number, the biggest number and sum of elements.");
            string? firstNumberString = Console.ReadLine();
            int firstNumber = Convert.ToInt32(firstNumberString);
            string? secondNumberString = Console.ReadLine();
            int secondNumber = Convert.ToInt32(secondNumberString);
            string? thirdNumberString = Console.ReadLine();
            int thirdNumber = Convert.ToInt32(thirdNumberString);
            string? fourthNumberString = Console.ReadLine();
            int fourthNumber = Convert.ToInt32(fourthNumberString);
            string? fifthNumberString = Console.ReadLine();
            int fifthNumber = Convert.ToInt32(fifthNumberString);

            int[] array = { firstNumber, secondNumber, thirdNumber, fourthNumber, fifthNumber };

            int theSmallestNumber = ArrayAlgorithms.FindTheSmallestNumber(array);
            Console.WriteLine($"The the smallest number: {theSmallestNumber}");

            int theBiggestNumber = ArrayAlgorithms.FindTheBiggestNumber(array);
            Console.WriteLine($"The the biggest number: {theBiggestNumber}");

            int sum = ArrayAlgorithms.FindSum(array);
            Console.WriteLine($"Sum of elements: {sum}");

            ArrayAlgorithms.SortElementsBubble(array);
            Console.WriteLine("Sorted Array:");
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
        }
    }
}
