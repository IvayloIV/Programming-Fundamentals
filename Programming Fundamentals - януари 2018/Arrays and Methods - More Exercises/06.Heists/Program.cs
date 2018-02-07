using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Heists
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(long.Parse).ToArray();
            var priceForJewels = arr[0];
            var priceForGold = arr[1];

            long sumNeeded = 0;
            long currentSum = 0;
            while (true)
            {
                var input = Console.ReadLine();
                if (input == "Jail Time")
                {
                    break;
                }
                var inputTokens = input.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                sumNeeded += long.Parse(inputTokens[1]);

                var element = inputTokens[0];
                for (int i = 0; i < element.Length; i++)
                {
                    if (element[i] == '%')
                    {
                        currentSum += priceForJewels;
                    }
                    else if (element[i] == '$')
                    {
                        currentSum += priceForGold;
                    }
                }
            }
            if (currentSum >= sumNeeded)
            {
                Console.WriteLine($"Heists will continue. Total earnings: {currentSum - sumNeeded}.");
            }
            else
            {
                Console.WriteLine($"Have to find another job. Lost: {sumNeeded - currentSum}.");
            }
        }
    }
}
