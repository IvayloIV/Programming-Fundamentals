using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.Phoenix_Grid
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                var input = Console.ReadLine();
                if (input == "ReadMe")
                {
                    break;
                }
                Match findingPolid = Regex.Match(input, @"^[^\s_]{3}(\.[^\s_]{3})*$");
                if (!findingPolid.Success)
                {
                    Console.WriteLine("NO");
                    continue;
                }
                Console.WriteLine(isPolidrom(input) ? "YES" : "NO");
            }
        }

        private static bool isPolidrom(string input)
        {
            for (int i = 0; i < input.Length / 2; i++)
            {
                if (input[i] != input[input.Length - 1 - i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
