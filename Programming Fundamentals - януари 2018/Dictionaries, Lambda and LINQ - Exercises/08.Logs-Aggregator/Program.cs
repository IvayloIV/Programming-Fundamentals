using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Logs_Aggregator
{
    class Program
    {
        class Durations
        {
            public int Durat { get; set; }
            public List<string> IPS { get; set; }
        }
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var book = new Dictionary<string, Durations>();
            for (int i = 0; i < n; i++)
            {
                var inputTokens = Console.ReadLine().Split(new[] { " " },StringSplitOptions.RemoveEmptyEntries).ToArray();
                var ip = inputTokens[0];
                var name = inputTokens[1];
                var duration = int.Parse(inputTokens[2]);
                if (!book.ContainsKey(name))
                {
                    book[name] = new Durations
                    {
                        Durat = 0,
                        IPS = new List<string>()
                    };
                }
                book[name].Durat += duration;
                if (book[name].IPS.All(a => a != ip))
                {
                    book[name].IPS.Add(ip);
                }
            }
            foreach (var item in book.OrderBy(a => a.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value.Durat} [{string.Join(", ", item.Value.IPS.OrderBy(a => a))}]");
            }
        }
    }
}
