using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Triangle_Formations
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            var c = int.Parse(Console.ReadLine());

            if (a + b > c && a + c > b && b + c > a)
            {
                Console.WriteLine($"Triangle is valid.");
                var isAngle = false;
                isAngle = CheckRightAngle(a, b, c, "a", "b");
                if (isAngle) return;
                isAngle = CheckRightAngle(a, c, b, "a", "c");
                if (isAngle) return;
                isAngle = CheckRightAngle(b, c, a, "b", "c");
                if (isAngle) return;
                Console.WriteLine($"Triangle has no right angles");
            }
            else {
                Console.WriteLine($"Invalid Triangle.");
            }
        }

        private static bool CheckRightAngle(int num1, int num2, int num3,string a1, string b1)
        {
            if (num3 * num3 == (num1 * num1) + (num2 * num2))
            {
                Console.WriteLine($"Triangle has a right angle between sides {a1} and {b1}");
                return true;
            }
            return false;
        }
    }
}
