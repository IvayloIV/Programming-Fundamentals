using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1___Sweet_Dessert
{
    class Program
    {
        static void Main(string[] args)
        {
            var ivanchoChash = double.Parse(Console.ReadLine());
            var countIvancho = int.Parse(Console.ReadLine());
            var bananas = double.Parse(Console.ReadLine());
            var eggs = double.Parse(Console.ReadLine());
            var beries = double.Parse(Console.ReadLine());

            var neededSets = Math.Ceiling(countIvancho / 6D);
            var neededMoney = neededSets * (2 * bananas) + neededSets * (4 * eggs) + neededSets * (0.2 * beries);

            if (neededMoney <= ivanchoChash)
            {
                Console.WriteLine($"Ivancho has enough money - it would cost {(neededMoney):f2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivancho will have to withdraw money - he will need {(neededMoney -ivanchoChash):f2}lv more.");
            }
        }
    }
}
