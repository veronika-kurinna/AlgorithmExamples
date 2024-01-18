using AlgorithmExamples.Models;

namespace AlgorithmExamples.Algorithms
{
    public static class WaterAlgorithm
    {
        public static BottleOfWater[] FindBottles(BottleOfWater[] bottles, int target)
        {
            if (bottles.Length == 0)
            {
                throw new ArgumentException("Array is empty");
            }
            if (target <= 0)
            {
                throw new ArgumentException($"Value {target} is invalid. Value must be more than zero");
            }

            Dictionary<int, decimal> dictionary = new Dictionary<int, decimal>();
            for (int i = 0; i < bottles.Length; i++)
            {
                dictionary.Add(bottles[i].Volume, bottles[i].Price);
            }

            if (dictionary.ContainsKey(target))
            {
                return new BottleOfWater[] 
                {
                   new() { Volume = target, Price = dictionary[target]}
                };
            }

            for (int i = 0; i < bottles.Length; i++)
            {
                int difference = target - bottles[i].Volume;
                if (dictionary.ContainsKey(difference))
                {
                    return new BottleOfWater[]
                    {
                        new() { Volume = bottles[i].Volume, Price = dictionary[bottles[i].Volume] }, 
                        new() { Volume = difference, Price = dictionary[difference] } 
                    };
                }
            }
            return new BottleOfWater[0];
        }
    }
}
