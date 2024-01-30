namespace AlgorithmExamples.Helpers
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
                    Console.WriteLine("Value is invalid. Use only numbers");
                }
            }
        }
    }
}
