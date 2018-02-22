using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.Camera_View
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputTokens = Console.ReadLine().Split(' ').ToArray();
            var text = Console.ReadLine();
            MatchCollection findings = Regex.Matches(text, @"\|<(.*?)(?=\|<|$)");
            var allFinds = new List<string>();
            foreach (Match item in findings)
            {
                allFinds.Add(new string(item.Groups[1].Value.Skip(int.Parse(inputTokens[0])).Take(int.Parse(inputTokens[1])).ToArray()));
            }
            Console.WriteLine(string.Join(", ", allFinds));
        }
    }
}
