using AlgorithmExamples.Algorithms;

namespace AlgorithmExamples.Games
{
    public class PlayWithArray : IGame
    {
        public void Play()
        {
            int countNumbers = 5;
            Console.WriteLine($"Write {countNumbers} numbers and computer will find the smallest number, the biggest number and sum of elements.");

            int[] array = new int[countNumbers];
            for (int i = 0; i < countNumbers; i++)
            {
                string? numberString = Console.ReadLine();
                int number;
                if (int.TryParse(numberString, out number))
                {
                    array[i] = number;
                }
                else
                {
                    Console.WriteLine("You've written letters. Use only numbers");
                    i--;
                }
            }
            ArrayInfo result = ArrayAlgorithms.GetArrayInfo(array);
            Console.WriteLine($"The the smallest number: {result.TheSmallestNumber}");
            Console.WriteLine($"The the biggest number: {result.TheBiggestNumber}");
            Console.WriteLine($"Sum of elements: {result.Sum}");
        }
    }
}
