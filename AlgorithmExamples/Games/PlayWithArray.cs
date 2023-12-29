using AlgorithmExamples.Algorithms;

namespace AlgorithmExamples.Games
{
    public class PlayWithArray : IGame
    {
        public void Play()
        {
            Console.WriteLine("Write 5 numbers and computer will find the smallest number, the biggest number and sum of elements.");
            int[] array = ReadNumber(5);

            ArraySpecification result = ArrayAlgorithms.CalculateSumElementsFindSmallestBiggestElement(array);
            Console.WriteLine($"The the smallest number: {result.TheSmallestNumber}");
            Console.WriteLine($"The the biggest number: {result.TheBiggestNumber}");
            Console.WriteLine($"Sum of elements: {result.Sum}");
        }

        public int[] ReadNumber(int countNumbers)
        {
            int[] array = new int[countNumbers];
            for (int i = 0; i < countNumbers; i++)
            {
                string? numberString = Console.ReadLine();

                if (numberString.All(char.IsNumber))
                {
                    int number = Convert.ToInt32(numberString);
                    array[i] = number;
                }
                else
                {
                    throw new ArgumentException("You've written letters. Use only numbers");
                }
            }
            return array;
        }
    }
}
