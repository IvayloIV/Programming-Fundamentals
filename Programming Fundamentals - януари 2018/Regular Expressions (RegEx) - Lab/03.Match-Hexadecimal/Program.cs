using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.Match_Hexadecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var findings = Regex.Matches(input, @"\b(0x)?[0-9A-F]+\b").Cast<Match>().Select(a => a.Value).ToArray();
            Console.WriteLine(string.Join(" ", findings));
        }
    }
}
