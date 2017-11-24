using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Problem_9.Match_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            MatchCollection finding = Regex.Matches(input, @"(^|(?<=\s))-?\d+(\.\d+)?($|(?=\s))");

            foreach (Match item in finding)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
