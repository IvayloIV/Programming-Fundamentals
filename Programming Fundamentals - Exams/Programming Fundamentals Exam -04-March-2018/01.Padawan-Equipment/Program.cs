using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTask
{
    class Program
    {
        static void Main(string[] args)
        {
            var allMoney = double.Parse(Console.ReadLine());
            var countOfStudents = long.Parse(Console.ReadLine());
            var lightsabers = double.Parse(Console.ReadLine());
            var robes = double.Parse(Console.ReadLine());
            var belts = double.Parse(Console.ReadLine());

            var sabresPrive = lightsabers * Math.Ceiling(countOfStudents + countOfStudents * 0.1d);
            var robotPrice = robes * countOfStudents;
            var freeBlets = 0;
            var helper = countOfStudents;
            while (helper >= 6)
            {
                helper -= 6;
                freeBlets++;
            }
            var beltsPrice = belts * (countOfStudents - freeBlets);
            var sum = sabresPrive + robotPrice + beltsPrice;
            if (sum <= allMoney)
            {
                Console.WriteLine($"The money is enough - it would cost {sum:f2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivan Cho will need {(sum - allMoney):f2}lv more.");
            }
        }
    }
}
