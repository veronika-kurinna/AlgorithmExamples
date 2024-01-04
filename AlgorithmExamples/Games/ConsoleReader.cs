namespace AlgorithmExamples.Games
{
    public static class ConsoleReader
    {
        public static int ReadNumber()
        {
            while (true)
            {
                string? numberString = Console.ReadLine();
                int number;
                if (int.TryParse(numberString, out number))
                {
                    return number;
                }
                else
                {
                    Console.WriteLine("You've written letters. Use only numbers");
                }
            }
        }
    }
}
