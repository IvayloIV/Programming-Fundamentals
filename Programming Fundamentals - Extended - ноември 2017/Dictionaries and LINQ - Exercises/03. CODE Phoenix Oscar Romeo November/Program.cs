using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.CODE_Ph
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Dictionary<string, List<string>>();

            while (true)
            {
                var input = Console.ReadLine();

                if (input == "Blaze it!")
                {
                    break;
                }

                var totalInput = input.Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                var creature = totalInput[0];
                var squardMate = totalInput[1];

                if (creature == squardMate)
                {
                    continue;
                }
                if (!book.ContainsKey(creature))
                {
                    book[creature] = new List<string>();
                }
                if (book[creature].All(a => a != squardMate))
                {
                    book[creature].Add(squardMate);
                }
            }

            foreach (var item in book)
            {
                for (int i = 0; i < item.Value.Count; i++)
                {
                    if (book.ContainsKey(item.Value[i]))
                    {
                        if (book[item.Value[i]].Contains(item.Key))
                        {
                            var current = item.Key;
                            var currrent2 = item.Value[i];
                            book[current].Remove(currrent2);
                            book[currrent2].Remove(current);
                        }
                    }
                }                                  
            }
            foreach (var item in book.OrderByDescending(a => a.Value.Count))
            {
                Console.WriteLine($"{item.Key} : {item.Value.Count}");
            }
        }
    }
}
