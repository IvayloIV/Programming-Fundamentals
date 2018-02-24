using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.Booming_Cannon
{
    class Program
    {
        static void Main(string[] args)
        {
            var cannonType = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var sentence = Console.ReadLine();
            MatchCollection findingSent = Regex.Matches(sentence, @"\\<<<(.*?)(?=\\<<<|$)");
            var words = new List<string>();
            foreach (Match item in findingSent)
            {
                var result = new string(item
                    .Groups[1]
                    .Value
                    .Skip(int.Parse(cannonType[0].ToString()))
                        .Take(int.Parse(cannonType[1].ToString()))
                    .ToArray());
                if (result != "")
                {
                    words.Add(result);
                }
            }
            Console.WriteLine(string.Join("/\\", words));
        }
    }
}
