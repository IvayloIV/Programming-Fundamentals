using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Mentor_Group
{
    class Program
    {
        class DataComments
        {
            public List<string> Comments { get; set; }
            public List<DateTime> Time { get; set; }
            public DataComments()
            {
                Comments = new List<string>();
                Time = new List<DateTime>();
            }
        }
        static void Main(string[] args)
        {
            var book = new Dictionary<string, DataComments>();
            while (true)
            {
                var input = Console.ReadLine();
                if (input == "end of dates")
                {
                    break;
                }
                var inputTokens = input.Split(new[] { " ", "," }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                if (!book.ContainsKey(inputTokens[0]))
                {
                    book[inputTokens[0]] = new DataComments();
                }
                for (int i = 1; i < inputTokens.Length; i++)
                {
                    book[inputTokens[0]].Time.Add(DateTime.ParseExact(inputTokens[i], "dd/MM/yyyy", CultureInfo.InvariantCulture));
                }
            }
            while (true)
            {
                var input = Console.ReadLine();
                if (input == "end of comments")
                {
                    break;
                }
                var inputTokens = input.Split(new[] { "-"}, StringSplitOptions.RemoveEmptyEntries).ToArray();
                if (!book.ContainsKey(inputTokens[0]))
                {
                    continue;
                }
                book[inputTokens[0]].Comments.Add(inputTokens[1]);
            }
            foreach (var item in book.OrderBy(a => a.Key))
            {
                Console.WriteLine(item.Key);
                Console.WriteLine($"Comments:");
                foreach (var item2 in item.Value.Comments)
                {
                    Console.WriteLine($"- {item2}");
                }
                Console.WriteLine($"Dates attended:");
                foreach (var item2 in item.Value.Time.OrderBy(a => a))
                {
                    Console.WriteLine($"-- {item2:dd/MM/yyyy}");
                }
            }
        }
    }
}
