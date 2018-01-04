using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Sweet_Dessert
{
    class Program
    {
        static void Main(string[] args)
        {
            StartProgram();
        }

        private static void StartProgram()
        {
            var cashIvancho = double.Parse(Console.ReadLine());
            var countQuest = int.Parse(Console.ReadLine());
            var priceBananas = double.Parse(Console.ReadLine());
            var priceEggs = double.Parse(Console.ReadLine());
            var priceBerries = double.Parse(Console.ReadLine());

            var allSum = MakeCalculations(cashIvancho, countQuest, priceBananas, priceEggs, priceBerries);
            PrintResult(allSum, cashIvancho);
        }

        private static double MakeCalculations(double cashIvancho, 
            int countQuest, double priceBananas,
            double priceEggs, double priceBerries)
        {
            var sets = (int)Math.Ceiling(countQuest / 6D);
            var allSum = sets * (2D * priceBananas) + sets * (4D * priceEggs) + sets * (0.2 * priceBerries);
            return allSum;
        }

        private static void PrintResult(double allSum, double cashIvancho)
        {
            if (allSum <= cashIvancho)
            {
                Console.WriteLine($"Ivancho has enough money - it would cost {allSum:f2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivancho will have to withdraw money - he will need {(allSum - cashIvancho):f2}lv more.");
            }
        }
    }
}
