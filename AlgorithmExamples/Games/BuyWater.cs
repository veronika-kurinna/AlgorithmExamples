using AlgorithmExamples.Algorithms;
using AlgorithmExamples.Models;

namespace AlgorithmExamples.Games
{
    public class BuyWater : IGame
    {
        public BottleOfWater[] _bottlesOfWater = 
        {
            new() { Volume = 1, Price = 18.7m }, 
            new() { Volume = 3, Price = 45.5m }, 
            new() { Volume = 5, Price = 60.8m }, 
            new() { Volume = 10, Price = 110m }, 
            new() { Volume = 18, Price = 200m }, 
        };

        public void Play()
        {
            Console.WriteLine($"Hi! We deliver water to your house. We have bottle sizes:");
            foreach (var item in _bottlesOfWater)
            {
                Console.WriteLine($"{item.Volume}L - {item.Price} Hrn");
            }

            Console.WriteLine("Our courier can deliver only two bottles. Please, write how many liters of water do you want to buy:");
            int countLiters = ConsoleReader.ReadNumber();

            BottleOfWater[] suitableTwoBottlesSize = ShopWater.FindBottles(_bottlesOfWater, countLiters);
            Console.WriteLine("\n");
            PrintMessage(suitableTwoBottlesSize);
        }

        private void PrintMessage(BottleOfWater[] bottles) 
        {
            if (bottles.Length > 0)
            {
                decimal totalAmount = 0;
                Console.WriteLine($"Your order consist of:");
                for (int i = 0; i < bottles.Length; i++)
                {
                    Console.WriteLine($"{bottles[i].Volume}L - {bottles[i].Price} Hrn");
                    totalAmount += bottles[i].Price;
                }
                Console.WriteLine($"Total amount: {totalAmount} Hrn");
            }
            else
            {
                Console.WriteLine($"Sorry, we can't deliver water. We don't have suitable bottle size");
            }
        }

    }
}
