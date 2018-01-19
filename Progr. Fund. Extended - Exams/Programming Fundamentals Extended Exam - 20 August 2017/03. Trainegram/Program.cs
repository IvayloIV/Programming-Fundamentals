using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.Trainegram
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true) {
                var input = Console.ReadLine();

                if (input == "Traincode!")
                {
                    break;
                }

                Match findingIt = Regex.Match(input, @"^<\[([^0-9A-Za-z]*)\]\.(\.\[[A-Za-z0-9]*\]\.)*$");

                if (findingIt.Success) {
                    Console.WriteLine(input);
                }
            }
        }
    }
}
