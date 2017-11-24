using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Problem_7
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            MatchCollection finding = Regex.Matches(input, @"\b(?:0x)?[A-F0-9]+\b");

            foreach (Match item in finding)
            {
                Console.Write(item.Value + " ");
            }
            Console.WriteLine();
        }
    }
}
