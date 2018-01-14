using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.SoftUni_Water
{
    class Program
    {
        static void Main(string[] args)
        {
            var totalAmountOfWater = double.Parse(Console.ReadLine());
            var arr = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToList();
            var bottleCapacity = double.Parse(Console.ReadLine());

            var count = 0;
            var index = totalAmountOfWater % 2 == 0 ? 0 : arr.Count() - 1;

            var indexes = new List<double>();
            var sum = 0D;
            while (count <= arr.Count() - 1)
            {
                sum += bottleCapacity - arr[index];
                indexes.Add(sum > totalAmountOfWater ? index : -1);
                index += totalAmountOfWater % 2 == 0 ? 1 : -1;
                count++;
            }

            PrinResult(sum, totalAmountOfWater, indexes);            
        }

        private static void PrinResult(double sum, double totalAmountOfWater, List<double> indexes)
        {
            if (sum <= totalAmountOfWater)
            {
                Console.WriteLine($"Enough water!");
                Console.WriteLine($"Water left: {totalAmountOfWater - sum}l.");
            }
            else
            {
                indexes = indexes.Where(a => a != -1).ToList();
                Console.WriteLine($"We need more water!");
                Console.WriteLine($"Bottles left: {indexes.Count()}");
                Console.WriteLine($"With indexes: {string.Join(", ", indexes)}");
                Console.WriteLine($"We need {sum - totalAmountOfWater} more liters!");
            }
        }
    }
}
