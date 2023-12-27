using AlgorithmExamples.Algorithms;

namespace AlgorithmExamples.Games
{
    public class FindTheBiggestNumber : IGame
    {
        private readonly ITheBiggestNumber _theBiggestNumber;

        public FindTheBiggestNumber(ITheBiggestNumber theBiggestNumber)
        {
            _theBiggestNumber = theBiggestNumber;
        }

        public void Play()
        {
            Console.WriteLine("Write 3 numbers and computer finds the biggest number");
            string? firstNumberString = Console.ReadLine();
            int firstNumber = Convert.ToInt32(firstNumberString);
            string? secondNumberString = Console.ReadLine();
            int secondNumber = Convert.ToInt32(secondNumberString);
            string? thirdNumberString = Console.ReadLine();
            int thirdNumber = Convert.ToInt32(thirdNumberString);

            int[] array = { firstNumber, secondNumber, thirdNumber};
            int theBiggestNumber = _theBiggestNumber.FindTheBiggestNumber(array);
            Console.WriteLine($"The the biggest number is {theBiggestNumber}");
        }
    }
}
