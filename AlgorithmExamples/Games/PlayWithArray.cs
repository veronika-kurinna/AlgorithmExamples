using AlgorithmExamples.Algorithms;
using AlgorithmExamples.Models;

namespace AlgorithmExamples.Games
{
    public class PlayWithArray : IGame
    {
        public void Play()
        {
            int countNumbers = 5;
            Console.WriteLine($"Write {countNumbers} numbers and computer will find the smallest number, the biggest number and sum of elements.");
            int[] array = new int[countNumbers];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = ConsoleReader.ReadNumber();
            }

            ArrayInfo result = ArrayAlgorithms.GetArrayInfo(array);
            Console.WriteLine($"The the smallest number: {result.SmallestNumber}");
            Console.WriteLine($"The the biggest number: {result.BiggestNumber}");
            Console.WriteLine($"Sum of elements: {result.Sum}");
        }
    }
}
