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
            int liters = ConsoleReader.ReadNumber();
            decimal price = liters * costPerLiter;

            int[] suitableTwoBottlesSize = TwoSum.FindTwoSum(bottleSizes, liters);
            bool isSuitableBottleSize = false;
            if (suitableTwoBottlesSize.Length > 0)
            {
                isSuitableBottleSize = true;
                Console.WriteLine($"Great! The cost of {liters}L water is {price} Hrn.");
                Console.WriteLine($"We're going to use bottle sizes:");
                foreach (var item in suitableTwoBottlesSize)
                {
                    Console.WriteLine($"{bottleSizes[item]}");
                }
            }
            else
            {
                for (int i = 0; i < bottleSizes.Length; i++)
                {
                    if (liters == bottleSizes[i] || liters == bottleSizes[i] * 2)
                    {
                        isSuitableBottleSize = true;
                        Console.WriteLine($"Great! The cost of {liters}L water is {price} Hrn.");
                        Console.WriteLine($"We're going to use bottle size: {bottleSizes[i]}");
                    }
                }
            }

            if (!isSuitableBottleSize)
            {
                Console.WriteLine($"Sorry, we can't deliver {liters}L. We don't have suitable bottle size");
            }
        }
    }
}
