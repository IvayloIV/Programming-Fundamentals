using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _01.Match_Full_Name
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var pattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";
            MatchCollection findings = Regex.Matches(input, pattern);
            var output = new List<string>();
            foreach (Match item in findings)
            {
                output.Add(item.Value);
            }
            Console.WriteLine(string.Join(" ", output));
        }
    }
}
