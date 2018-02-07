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
            var cash = double.Parse(Console.ReadLine());
            var quest = int.Parse(Console.ReadLine());
            var bananas = double.Parse(Console.ReadLine());
            var eggs = double.Parse(Console.ReadLine());
            var berries = double.Parse(Console.ReadLine());

            var portions = Math.Ceiling(quest / 6D);
            var allSum = portions * (2 * bananas) + portions * (4 * eggs) + portions * (0.2 * berries);

            if (allSum <= cash)
            {
                Console.WriteLine($"Ivancho has enough money - it would cost {allSum:f2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivancho will have to withdraw money - he will need {(allSum - cash):f2}lv more.");
            }
        }
    }
}
