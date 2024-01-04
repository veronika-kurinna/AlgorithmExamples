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
            for (int i = 0; i < array.Length; i++)
            {
                int number = Game.ReadNumber();
                array[i] = number;
            }

            ArrayInfo result = ArrayAlgorithms.GetArrayInfo(array);
            Console.WriteLine($"The the smallest number: {result.TheSmallestNumber}");
            Console.WriteLine($"The the biggest number: {result.TheBiggestNumber}");
            Console.WriteLine($"Sum of elements: {result.Sum}");
        }
    }
}
