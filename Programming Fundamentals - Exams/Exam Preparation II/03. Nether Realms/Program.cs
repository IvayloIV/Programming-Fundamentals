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
            var input = Console.ReadLine().Split(new[] { "," }, StringSplitOptions.RemoveEmptyEntries).ToArray().Select(a => a.Trim(' '));

            foreach (var item in input.OrderBy(a => a))
            {
                var currentDemon = item.Trim(' ');

                MatchCollection matchHealt = Regex.Matches(currentDemon, @"[^0-9\+\-\*\/\.]");

                decimal health = 0;
                foreach (Match letter in matchHealt)
                {
                    health += char.Parse(letter.Value);
                }

                decimal damage = 0;
                MatchCollection matchDamage = Regex.Matches(currentDemon, @"(\-)?([0-9]+)(\.[0-9]+)?");

                foreach (Match num in matchDamage)
                {
                    damage += decimal.Parse(num.Value);
                }
                MatchCollection nultiplay = Regex.Matches(currentDemon, @"\*");

                for (int i = 0; i < nultiplay.Count; i++)
                {
                    damage *= 2;
                }

                MatchCollection divide = Regex.Matches(currentDemon, @"\/");

                for (int i = 0; i < divide.Count; i++)
                {
                    damage /= 2;
                }
                Console.WriteLine($"{currentDemon} - {health} health, {damage:f2} damage");
            }
        }
    }
}
