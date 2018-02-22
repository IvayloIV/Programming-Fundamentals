using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Websites
{
    class Program
    {
        class Website
        {
            public string Host { get; set; }
            public string Domain { get; set; }
            public List<string> Queries { get; set; }
            public Website(string host, string domain)
            {
                Host = host;
                Domain = domain;
                Queries = new List<string>();
            }
        }
        static void Main(string[] args)
        {
            var book = new List<Website>();
            while (true)
            {
                var input = Console.ReadLine();
                if (input == "end")
                {
                    break;
                }
                var inputTokens = input.Split(new string[] { " | " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                book.Add(new Website(inputTokens[0], inputTokens[1]));
                if (inputTokens.Length > 2)
                {
                    var queries = inputTokens[2].Split(',').ToList();
                    book[book.Count() - 1].Queries.AddRange(queries);
                }
            }
            foreach (var item in book)
            {
                if (item.Queries.Count() != 0)
                {
                    Console.WriteLine($"https://www.{item.Host}.{item.Domain}/query?=[{string.Join("]&[", item.Queries)}]");
                }
                else
                {
                    Console.WriteLine($"https://www.{item.Host}.{item.Domain}");
                }
            }
        }
    }
}
