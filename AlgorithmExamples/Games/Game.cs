namespace AlgorithmExamples.Games
{
    public static class Game
    {
        public static int[] ReadNumber(int countNumbers)
        {
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
            return array;
        }
    }
}
