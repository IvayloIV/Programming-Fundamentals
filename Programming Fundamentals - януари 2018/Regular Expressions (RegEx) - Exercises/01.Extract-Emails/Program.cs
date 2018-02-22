using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _01.Extract_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();
            var pattern = @"(?<=\s|^)[A-Za-z0-9]+([\._-][A-Za-z0-9]+)*@[A-Za-z-]+(\.[A-Za-z-]+)+\b";
            MatchCollection findings = Regex.Matches(text, pattern);
            foreach (Match item in findings)
            {
                Console.WriteLine(item.Value);
            }
        }
    }
}
