using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Points_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Dictionary<string, Dictionary<string, int>>();
            while (true)
            {
                var input = Console.ReadLine();
                if (input == "Result") break;
                var inputTokens = input.Split('|').ToArray();
                var points = int.Parse(inputTokens[2]);
                var firstItem = ClearStuff(inputTokens[0]);
                var secondItem = ClearStuff(inputTokens[1]);
                var isFirstIsTeamName = false;
                if (firstItem.All(a => a >= 65 && a <= 90))
                {
                    isFirstIsTeamName = true;
                }
                if (isFirstIsTeamName)
                {
                    book = CreateNewItemInBook(book, firstItem, secondItem, points);
                }
                else
                {
                    book = CreateNewItemInBook(book, secondItem, firstItem, points);
                }
            }
            foreach (var item in book.OrderByDescending(a => a.Value.Values.Sum()))
            {
                Console.WriteLine($"{item.Key} => {item.Value.Values.Sum()}");
                foreach (var item2 in item.Value.OrderByDescending(a => a.Value).Take(1))
                {
                    Console.WriteLine($"Most points scored by {item2.Key}");
                }
            }
        }

        private static Dictionary<string, Dictionary<string, int>> CreateNewItemInBook(Dictionary<string, Dictionary<string, int>> book, string firstItem, string secondItem, int points)
        {
            if (!book.ContainsKey(firstItem))
            {
                book[firstItem] = new Dictionary<string, int>();
            }
            book[firstItem][secondItem] = points;
            return book;
        }

        private static string ClearStuff(string v)
        {
            var result = "";
            for (int i = 0; i < v.Length; i++)
            {
                if (v[i] != '@' && v[i] != '%' && v[i] != '$' && v[i] != '*')
                {
                    result += v[i];
                }
            }
            return result;
        }
    }
}
