using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SoftUni
{
    class Program
    {
        static void Main(string[] args)
        {
            var bookPeople = new Dictionary<string, string>();
            var bookDrinks = new Dictionary<string, long>();
            var delits = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            var nameDelits = delits[0];
            var numberDelits = delits[1];

            while (true)
            {
                var input = Console.ReadLine();

                if (input == "end of info")
                {
                    break;
                }

                var splitInputforName = input.Split(new string[] { $"{nameDelits}" }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                var splitInputForNumbers = input.Split(new string[] { $"{numberDelits}" }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                if (splitInputforName.Length == 2)
                {
                    var name = splitInputforName[0];
                    var coffe = splitInputforName[1];

                    bookPeople[name] = coffe;

                    if (!bookDrinks.ContainsKey(coffe))
                    {
                        bookDrinks[coffe] = 0;
                    }
                }
                else if (splitInputForNumbers.Length == 2)
                {
                    var coffe = splitInputForNumbers[0];
                    var count = long.Parse(splitInputForNumbers[1]);
                    if (!bookDrinks.ContainsKey(coffe))
                    {
                        bookDrinks[coffe] = 0;
                    }
                    bookDrinks[coffe] += count;
                }
            }

            foreach (var item in bookDrinks.Where(a => a.Value == 0))
            {
                Console.WriteLine($"Out of {item.Key}");
            }
            while (true)
            {                
                var input = Console.ReadLine();

                if (input == "end of week")
                {
                    break;
                }

                var splitInput = input.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                var name = splitInput[0];
                var count = long.Parse(splitInput[1]);

                var currentCoffe = bookPeople[name];
                bookDrinks[currentCoffe] -= count;

                if (bookDrinks[currentCoffe] <= 0)
                {
                    Console.WriteLine($"Out of {currentCoffe}");
                }
            }

            var listCoffes = new List<string>();
            foreach (var item in bookDrinks.Where(a => a.Value > 0))
            {
                listCoffes.Add(item.Key);
            }
            Console.WriteLine($"Coffee Left:");
            foreach (var item in bookDrinks.Where(a => a.Value > 0).OrderByDescending(a => a.Value))
            {
                Console.WriteLine($"{item.Key} {item.Value}");
            }

            Console.WriteLine($"For:");
            foreach (var item in bookPeople.Where(a => listCoffes.Contains(a.Value)).OrderBy(a => a.Value).ThenByDescending(a => a.Key))
            {
                Console.WriteLine($"{item.Key} {item.Value}");
            }
        }
    }
}
