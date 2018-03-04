using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourPart
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Dictionary<string, List<string>>();
            var allUsers = new List<string>();
            while (true)
            {
                var input = Console.ReadLine();
                if (input == "Lumpawaroo")
                {
                    break;
                }
                var inputTokens = input.Split(new string[] { " | " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                if (inputTokens.Count() == 2)
                {
                    var forceSice = inputTokens[0];
                    var forceUser = inputTokens[1];
                    if (allUsers.Contains(forceUser))
                    {
                        continue;
                    }
                    if (!book.ContainsKey(forceSice))
                    {
                        book[forceSice] = new List<string>();
                    }
                    if (!book[forceSice].Contains(forceUser))
                    {
                        book[forceSice].Add(forceUser);
                    }
                    allUsers.Add(forceUser);
                }
                else
                {
                    var inputTokens2 = input.Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                    var forceUser = inputTokens2[0];
                    var forceSice = inputTokens2[1];
                    foreach (var item in book)
                    {
                        if (item.Value.Any(a => a == forceUser))
                        {
                            item.Value.Remove(forceUser);
                        }
                    }
                    if (!book.ContainsKey(forceSice))
                    {
                        book[forceSice] = new List<string>();
                    }
                    if (!book[forceSice].Contains(forceUser))
                    {
                        book[forceSice].Add(forceUser);
                    }
                    Console.WriteLine($"{forceUser} joins the {forceSice} side!");
                    allUsers.Add(forceUser);
                }
            }
            foreach (var item in book.Where(a => a.Value.Count() != 0).OrderByDescending(a => a.Value.Count()).ThenBy(a => a.Key))
            {
                Console.WriteLine($"Side: {item.Key}, Members: {item.Value.Count()}");
                foreach (var item2 in item.Value.OrderBy(a => a))
                {
                    Console.WriteLine($"! {item2}");
                }
            }
        }
    }
}
