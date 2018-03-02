using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Hornet_Armada
{
    class Program
    {
        class TypeLegion
        {
            public long LastActivity { get; set; }
            public Dictionary<string, long> Soldier { get; set; }
            public TypeLegion()
            {
                LastActivity = long.MinValue;
                Soldier = new Dictionary<string, long>();
            }
        }
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var book = new Dictionary<string, TypeLegion>();
            for (int i = 0; i < n; i++)
            {
                var inputTokens = Console.ReadLine().Split(new string[] { " = ", " -> " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                var lastActivity = long.Parse(inputTokens[0]);
                var legionName = inputTokens[1];
                var soldierTokens = inputTokens[2].Split(':').ToArray();
                var soldierType = soldierTokens[0];
                var soldierCount = long.Parse(soldierTokens[1]);
                if (!book.ContainsKey(legionName))
                {
                    book[legionName] = new TypeLegion();
                }
                if (book[legionName].LastActivity < lastActivity)
                {
                    book[legionName].LastActivity = lastActivity;
                }
                if (book[legionName].Soldier.All(a => a.Key != soldierType))
                {
                    book[legionName].Soldier[soldierType] = 0;
                }
                book[legionName].Soldier[soldierType] += soldierCount;
            }
            var outputTokens = Console.ReadLine().Split(new string[] { "\\" }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            if (outputTokens.Count() == 2)
            {
                var activity = long.Parse(outputTokens[0]);
                var soldierType = outputTokens[1];
                var helper = new Dictionary<string, long>();
                foreach (var item in book.Where(a => a.Value.LastActivity < activity))
                {
                    foreach (var item2 in item.Value.Soldier)
                    {
                        if (item2.Key == soldierType)
                        {
                            helper[item.Key] = item2.Value;
                        }
                    }
                }
                foreach (var item in helper.OrderByDescending(a => a.Value))
                {
                    Console.WriteLine($"{item.Key} -> {item.Value}");
                }
            }
            else
            {
                var soldierType = outputTokens[0];
                foreach (var item in book.Where(a => a.Value.Soldier.Any(b => b.Key == soldierType)).OrderByDescending(a => a.Value.LastActivity))
                {
                    Console.WriteLine($"{item.Value.LastActivity} : {item.Key}");
                }
            }
        }
    }
}
