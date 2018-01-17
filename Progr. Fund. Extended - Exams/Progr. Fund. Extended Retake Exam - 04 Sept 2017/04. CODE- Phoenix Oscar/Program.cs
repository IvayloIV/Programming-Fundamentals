using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.CODE__Phoenix_Oscar
{
    class Program
    {
        static void Main(string[] args)
        {
            StartProgram();        
        }

        private static void StartProgram()
        {
            var book = new Dictionary<string, List<string>>();
            while (true)
            {
                var input = Console.ReadLine();

                if (input == "Blaze it!")
                {
                    break;
                }
                book = AddInBook(input, book);
            }
            book = OrderBook(book);
            PrintResult(book);
        }

        private static Dictionary<string, List<string>> AddInBook(string input, 
            Dictionary<string, List<string>> book)
        {
            var splitInput = input
                .Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            var creature = splitInput[0];
            var squadMate = splitInput[1];

            if (creature == squadMate)
            {
                return book;
            }

            if (!book.ContainsKey(creature))
            {
                book[creature] = new List<string>();
            }

            if (book[creature].All(a => a != squadMate))
            {
                book[creature].Add(squadMate);
            }
            return book;
        }

        private static void PrintResult(Dictionary<string, List<string>> book)
        {
            foreach (var item in book.OrderByDescending(a => a.Value.Count()))
            {
                Console.WriteLine($"{item.Key} : {item.Value.Count()}");
            }
        }

        private static Dictionary<string, List<string>> OrderBook(Dictionary<string, List<string>> book)
        {
            foreach (var item in book)
            {
                for (var i = 0; i < book[item.Key].Count(); i++)
                {
                    if (book.ContainsKey(book[item.Key][i]))
                    {
                        if (book[book[item.Key][i]].Contains(item.Key))
                        {
                            book[book[item.Key][i]].Remove(item.Key);
                            book[item.Key].Remove(book[item.Key][i]);
                        }
                    }
                }
            }
            return book;
        }
    }
}
