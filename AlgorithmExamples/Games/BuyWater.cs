using AlgorithmExamples.Algorithms;

namespace AlgorithmExamples.Games
{
    public class BuyWater : IGame
    {
        public void Play()
        {
            decimal costPerLiter = 2.5m;
            Console.WriteLine($"Hi! We deliver water to your house. The cost of 1L water is {costPerLiter} Hrn. We have bottle sizes:");
            int[] bottleSizes = { 1, 3, 5, 7, 10, 18 };
            foreach (var item in bottleSizes)
            {
                Console.WriteLine($"{item}L");
            }

            Console.WriteLine("Our courier can deliver only two bottles. Please, write how many liters of water do you want to buy:");
            int countLiters = ConsoleReader.ReadNumber();
            decimal price = countLiters * costPerLiter;

            int index = BinarySearch.Search(bottleSizes, countLiters);
            if (index == -1)
            {
                int[] suitableTwoBottlesSize = TwoSum.FindTwoSum(bottleSizes, countLiters);
                if (suitableTwoBottlesSize.Length == 0)
                {
                    Console.WriteLine($"Sorry, we can't deliver {countLiters}L. We don't have suitable bottle size");
                }
                else
                {
                    Console.WriteLine($"Great! The cost of {countLiters}L water is {price} Hrn.");
                    Console.WriteLine($"We're going to use bottle sizes: {suitableTwoBottlesSize[0]} and {suitableTwoBottlesSize[1]}");
                }
            }
            else
            {
                Console.WriteLine($"Great! The cost of {countLiters}L water is {price} Hrn.");
                Console.WriteLine($"We're going to use bottle size: {bottleSizes[index]}");
            }
        }
    }
}
