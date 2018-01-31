using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.House_Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            var num1 = long.Parse(Console.ReadLine());
            var num2 = long.Parse(Console.ReadLine());

            if (num1 >= sbyte.MinValue && num1 <= sbyte.MaxValue)
            {
                Console.WriteLine(num1 * 4 + num2 * 10);
            }
            else
            {
                Console.WriteLine(num1 * 10 + num2 * 4);
            }
        }
    }
}
