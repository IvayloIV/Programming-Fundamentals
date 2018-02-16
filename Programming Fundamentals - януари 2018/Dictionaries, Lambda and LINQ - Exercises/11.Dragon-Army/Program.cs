using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Dragon_Army
{
    class Program
    {
        class DragonProperties
        {
            public long Damage { get; set; }
            public long Health { get; set; }
            public long Armor { get; set; }
        }
        static void Main(string[] args)
        {
            var book = new Dictionary<string, Dictionary<string, DragonProperties>>();
            var n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var inputTokens = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                var type = inputTokens[0];
                var name = inputTokens[1];
                var damage = inputTokens[2];
                var health = inputTokens[3];
                var armor = inputTokens[4];
                if (!book.ContainsKey(type))
                {
                    book[type] = new Dictionary<string, DragonProperties>();
                }
                if (!book[type].ContainsKey(name))
                {
                    book[type][name] = new DragonProperties();
                }

                if (damage == "null")
                {
                    book[type][name].Damage = 45;
                }
                else
                {
                    book[type][name].Damage = long.Parse(damage);
                }

                if (health == "null")
                {
                    book[type][name].Health = 250;
                }
                else
                {
                    book[type][name].Health = long.Parse(health);
                }

                if (armor == "null")
                {
                    book[type][name].Armor = 10;
                }
                else
                {
                    book[type][name].Armor = long.Parse(armor);
                }
            }
            PrintResult(book);
        }

        private static void PrintResult(Dictionary<string, Dictionary<string, DragonProperties>> book)
        {
            foreach (var item in book)
            {
                var damageAverage = (double)item.Value.Values.Sum(a => a.Damage) / item.Value.Values.Count();
                var healthAverage = (double)item.Value.Values.Sum(a => a.Health) / item.Value.Values.Count();
                var armorAverage = (double)item.Value.Values.Sum(a => a.Armor) / item.Value.Values.Count();
                Console.WriteLine($"{item.Key}::({(damageAverage):f2}/{(healthAverage):f2}/{(armorAverage):f2})");
                foreach (var item2 in item.Value.OrderBy(a => a.Key))
                {
                    Console.WriteLine($"-{item2.Key} -> damage: {item2.Value.Damage}, " +
                        $"health: {item2.Value.Health}, armor: {item2.Value.Armor}");
                }
            }
        }
    }
}
