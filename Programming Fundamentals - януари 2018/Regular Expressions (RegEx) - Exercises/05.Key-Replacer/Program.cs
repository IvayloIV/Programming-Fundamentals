using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _05.Key_Replacer
{
    class Program
    {
        static void Main(string[] args)
        {
            Match keyString = Regex.Match(Console.ReadLine(), @"^(?<start>[A-Za-z]+)(<|\||\\)(.*)(<|\||\\)(?<end>[A-Za-z]+)$");
            var start = keyString.Groups["start"].Value;
            var end = keyString.Groups["end"].Value;
            MatchCollection finding = Regex.Matches(Console.ReadLine(), $@"{start}(.*?){end}");
            var isEmpty = true;
            foreach (Match item in finding)
            {
                if (item.Groups[1].Value != "")
                {
                    Console.Write(item.Groups[1].Value);
                    isEmpty = false;
                }
            }
            if (isEmpty)
            {
                Console.WriteLine($"Empty result");
            }
            else
            {
                Console.WriteLine();
            }
        }
    }
}
