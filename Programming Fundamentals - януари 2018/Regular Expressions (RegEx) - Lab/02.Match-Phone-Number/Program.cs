using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _02.Match_Phone_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            MatchCollection matches = Regex.Matches(input, @"\+359(\s|-)2\1[0-9]{3}\1[0-9]{4}\b");
            var outputArr = new List<string>();
            foreach (Match match in matches)
            {
                outputArr.Add(match.Value);
            }
            Console.WriteLine(string.Join(", ", outputArr));
        }
    }
}
