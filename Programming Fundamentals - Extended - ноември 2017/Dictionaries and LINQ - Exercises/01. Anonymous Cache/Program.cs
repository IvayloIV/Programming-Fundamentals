using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Anonymous_Cache
{
    class Program
    {
        static void Main(string[] args)
        {
            var dateSets = new List<string>();
            var book = new Dictionary<string, Dictionary<string, long>>();
            while (true)
            {
                var input = Console.ReadLine();

                if (input == "thetinggoesskrra")
                {
                    break;
                }

                var currentOpsion = input.Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                if (currentOpsion.Length == 1)
                {
                    dateSets.Add(currentOpsion[0]);
                }
                else
                {
                    var name = currentOpsion[0];
                    var totalOpcion = currentOpsion[1].Split(new string[] { " | " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                    var money = long.Parse(totalOpcion[0]);
                    var bank = totalOpcion[1];
                    if (!book.ContainsKey(bank))
                    {
                        book[bank] = new Dictionary<string, long>();
                    }
                    if (!book[bank].ContainsKey(name))
                    {
                        book[bank][name] = 0;
                    }
                    book[bank][name] += money;
                }
            }

            foreach (var item in book.OrderByDescending(a => a.Value.Values.Sum()))
            {
                if (dateSets.Contains(item.Key))
                {
                    Console.WriteLine($"Data Set: {item.Key}, Total Size: {item.Value.Values.Sum()}");
                    foreach (var item2 in item.Value)
                    {
                        Console.WriteLine($"$.{item2.Key}");
                    }
                    return;
                }
            }
        }
    }
}
