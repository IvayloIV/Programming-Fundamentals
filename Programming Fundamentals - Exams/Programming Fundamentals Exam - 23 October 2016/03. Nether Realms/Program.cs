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
            StartProgram();
        }

        private static void StartProgram()
        {
            var demons = Console.ReadLine()
                .Split(new[] { "," }, StringSplitOptions.RemoveEmptyEntries)
                .Select(a => a.Trim(' '))
                .ToList();

            foreach (var demon in demons.OrderBy(a => a))
            {
                var health = CalculateHealth(demon);
                double damage = CalculateDamage(demon);
                Console.WriteLine($"{demon} - {health} health, {damage:f2} damage ");
            }
        }

        private static int CalculateHealth(string demon)
        {
            var health = 0;
            MatchCollection findingHealth = Regex.Matches(demon, @"[^\+\-\*\/\.0-9]");

            foreach (Match item in findingHealth)
            {
                health += char.Parse(item.Value);
            }
            return health;
        }

        private static double CalculateDamage(string demon)
        {
            var damage = 0D;

            damage = AddAllDemonChars(demon, damage);
            damage = MultiDamage(demon, damage);
            damage = DivideDamage(demon, damage);

            return damage;
        }

        private static double AddAllDemonChars(string demon, double damage)
        {
            MatchCollection findingDamage = Regex.Matches(demon, @"\-?[0-9]+(\.[0-9]+)?");

            foreach (Match item in findingDamage)
            {
                damage += double.Parse(item.Value);
            }
            return damage;
        }

        private static double DivideDamage(string demon, double damage)
        {
            MatchCollection findingDivide = Regex.Matches(demon, @"\/");

            for (int i = 0; i < findingDivide.Count; i++)
            {
                damage /= 2D;
            }
            return damage;
        }

        private static double MultiDamage(string demon, double damage)
        {
            MatchCollection findingMulti = Regex.Matches(demon, @"\*");

            for (int i = 0; i < findingMulti.Count; i++)
            {
                damage *= 2D;
            }
            return damage;
        }
    }
}
