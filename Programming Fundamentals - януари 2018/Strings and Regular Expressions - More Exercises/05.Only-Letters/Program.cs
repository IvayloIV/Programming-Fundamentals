using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _05.Only_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();
            MatchCollection finding = Regex.Matches(text, @"([0-9]+)([^0-9]{1})");
            foreach (Match item in finding)
            {
                var numsStr = item.Groups[1].Value;
                var currentChar = item.Groups[2].Value;
                text = text.Replace(item.Value, currentChar + currentChar);
            }
            Console.WriteLine(text);
        }
    }
}
