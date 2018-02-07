using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Integer_to_Base
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            var baseN = int.Parse(Console.ReadLine());
            string result = IntegerToBase(number, baseN);
            Console.WriteLine(result);
        }

        private static string IntegerToBase(int number, int baseN)
        {
            var result = "";

            while (number > 0)
            {
                var remainder = number % baseN;
                result = remainder.ToString() + result;
                number /= baseN;
            }
            return result;
        }
    }
}
