using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Forum_Topics
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Dictionary<string, List<string>>();
            while (true)
            {
                var input = Console.ReadLine();
                if (input == "filter")
                {
                    break;
                }
                var inputTokens = input.Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                var topic = inputTokens[0];
                var tags = inputTokens[1].Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                if (!book.ContainsKey(topic))
                {
                    book[topic] = new List<string>();
                }
                foreach (var tag in tags)
                {
                    if (!book[topic].Contains(tag))
                    {
                        book[topic].Add(tag);
                    }
                }
            }
            var wantedTags = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            foreach (var item in book)
            {
                var isContainsAllTags = false;
                foreach (var tag in wantedTags)
                {
                    if (item.Value.Contains(tag))
                    {
                        isContainsAllTags = true;
                    }
                    else
                    {
                        isContainsAllTags = false;
                        break;
                    }
                }
                if (isContainsAllTags)
                {
                    Console.WriteLine($"{item.Key} | #{string.Join(", #", item.Value)}");
                }
            }
        }
    }
}
