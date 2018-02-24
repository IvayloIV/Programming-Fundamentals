using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _01.Cards
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var output = Regex.Matches(input, @"(?<=[SHDC]|^)([2-9]|10|[JQKA])([SHDC])").Cast<Match>().Select(a => a.Value).ToArray();
            Console.WriteLine(string.Join(", ", output));
        }
    }
}
