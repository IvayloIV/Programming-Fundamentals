using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.Nether_Realms
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = Console.ReadLine().Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries).Select(a => a.Trim()).ToArray();

            foreach (var name in names.OrderBy(a => a))
            {
                var health = 0;

                MatchCollection matchLetters = Regex.Matches(name, @"[^\+\-\*\/\.0-9]");
                foreach (Match item in matchLetters)
                {
                    health += char.Parse(item.Value);
                }

                var damage = 0d;
                MatchCollection matchNums = Regex.Matches(name, @"\-?[0-9]+(\.[0-9]+)*");

                foreach (Match item in matchNums)
                {
                    damage += double.Parse(item.Value);
                }
                MatchCollection matchMultip = Regex.Matches(name, @"\*");

                for (int i = 0; i < matchMultip.Count; i++)
                {
                    damage *= 2;
                }

                MatchCollection matchDivide = Regex.Matches(name, @"\/");

                for (int i = 0; i < matchDivide.Count; i++)
                {
                    damage /= 2;
                }
                Console.WriteLine($"{name} - {health} health, {damage:f2} damage");
            }

        }
    }
}
