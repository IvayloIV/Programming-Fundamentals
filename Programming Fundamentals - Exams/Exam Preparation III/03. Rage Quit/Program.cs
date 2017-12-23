using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.Rage_Quit
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            MatchCollection texts = Regex.Matches(input, @"[^0-9]+");
            MatchCollection nums = Regex.Matches(input, @"[0-9]+");

            StringBuilder text = new StringBuilder();
            for (int i = 0; i < texts.Count; i++)
            {
                var currentText = texts[i].Value.ToUpper();
                var currentNum = int.Parse(nums[i].Value);

                for (int k = 0; k < currentNum; k++)
                {
                    text.Append(currentText);
                }
            }
            var allText = text.ToString().Distinct().Count();
            Console.WriteLine($"Unique symbols used: {allText}");
            Console.WriteLine($"{text.ToString()}");
        }
    }
}
