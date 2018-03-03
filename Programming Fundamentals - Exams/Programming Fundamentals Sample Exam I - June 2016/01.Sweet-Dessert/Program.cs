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
            decimal cashIvancho = decimal.Parse(Console.ReadLine());
            var countGuest = long.Parse(Console.ReadLine());
            var bananas = decimal.Parse(Console.ReadLine());
            var eggs = decimal.Parse(Console.ReadLine());
            var berries = decimal.Parse(Console.ReadLine());

            countGuest = (int)Math.Ceiling(countGuest / 6d);
            var sum = countGuest * (2 * bananas) + countGuest * (4 * eggs) + countGuest * (0.2M * berries);
            if (sum <= cashIvancho)
            {
                Console.WriteLine($"Ivancho has enough money - it would cost {sum:f2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivancho will have to withdraw money - he will need {(sum - cashIvancho):f2}lv more.");
            }
        }
    }
}
