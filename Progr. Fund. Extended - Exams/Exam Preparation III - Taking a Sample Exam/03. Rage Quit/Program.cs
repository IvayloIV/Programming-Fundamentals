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

            StringBuilder allText = new StringBuilder();

            for (int i = 0; i < texts.Count; i++)
            {
                var t = texts[i].Value.ToUpper();
                var counts = int.Parse(nums[i].Value);

                for (int q = 0; q < counts; q++)
                {
                    allText.Append(t);
                }
            }
            Console.WriteLine($"Unique symbols used: {allText.ToString().Distinct().Count()}");
            Console.WriteLine($"{allText.ToString()}");
        }
    }
}
