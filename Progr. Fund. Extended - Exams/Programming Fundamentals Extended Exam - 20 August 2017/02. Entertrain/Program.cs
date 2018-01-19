using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Entertrain
{
    class Program
    {
        static void Main(string[] args)
        {
            var locomotivPower = int.Parse(Console.ReadLine());

            var wagonsWeight = new List<int>();
            while (true)
            {
                var input = Console.ReadLine();

                if (input == "All ofboard!") {
                    break;
                }

                var inputInt = int.Parse(input);
                wagonsWeight.Add(inputInt);
                var sumWagons = wagonsWeight.Sum();

                if (sumWagons > locomotivPower)
                {
                    double average = wagonsWeight.Average();
                    var closestNum = CalculateNumAv(average, wagonsWeight);
                    wagonsWeight.Remove(closestNum);
                }
            }
            wagonsWeight.Reverse();
            Console.WriteLine($"{string.Join(" ", wagonsWeight)} {locomotivPower}");
        }

        private static int CalculateNumAv(double average, List<int> wagonsWeight)
        {
            var minDifferent = double.MaxValue;
            var currentNum = 0;

            for (int i = 0; i < wagonsWeight.Count(); i++)
            {
                if (minDifferent > Math.Abs(wagonsWeight[i] - average))
                {
                    minDifferent = Math.Abs(wagonsWeight[i] - average);
                    currentNum = wagonsWeight[i];
                }
            }
            return currentNum;
        }
    }
}
