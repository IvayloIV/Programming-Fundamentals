using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _08.Mines
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();
            MatchCollection findingBomb = Regex.Matches(text, @"<(.{2})>");
            foreach (Match item in findingBomb)
            {
                var bombIndex = item.Index;
                var bombChars = item.Groups[1].Value.ToCharArray();
                var strengthBomb = Math.Abs(bombChars[0] - bombChars[1]);
                var startBomb = Math.Max(0, bombIndex - strengthBomb);
                var endBomb = Math.Min(text.Length, bombIndex + 4 + strengthBomb);
                var result = "";
                for (int i = 0; i < text.Length; i++)
                {
                    if (i >= startBomb && i < endBomb)
                    {
                        result += "_";
                    }
                    else
                    {
                        result += text[i];
                    }
                }
                text = result;
            }
            Console.WriteLine(text);
        }
    }
}
