using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _05.Match_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var findings = Regex.Matches(input, @"(^|(?<=\s))-?[0-9]+(\.[0-9]+)?($|(?=\s))").Cast<Match>().Select(a => a.Value).ToArray();
            Console.WriteLine(string.Join(" ", findings));
        }
    }
}
