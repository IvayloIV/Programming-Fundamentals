using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Pokemon_Evolution
{
    class Evolve
    {
        public string EvolutionType { get; set; }
        public long EvolutionIndex { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var book = new Dictionary<string, List<Evolve>>();

            while (true)
            {
                var input = Console.ReadLine();

                if (input == "wubbalubbadubdub")
                {
                    break;
                }

                var currentInput = input.Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                if (currentInput.Length == 1)
                {
                    foreach (var item in book.Where(a => a.Key == input))
                    {
                        Console.WriteLine($"# {item.Key}");
                        foreach (var item2 in item.Value)
                        {
                            Console.WriteLine($"{item2.EvolutionType} <-> {item2.EvolutionIndex}");
                        }
                    }
                    continue;
                }
                var name = currentInput[0];
                var evolveType = currentInput[1];
                var evolveIndex = long.Parse(currentInput[2]);

                if (!book.ContainsKey(name))
                {
                    book[name] = new List<Evolve>();
                }
                var currentEvolv = new Evolve
                {
                    EvolutionType = evolveType,
                    EvolutionIndex = evolveIndex
                };
                book[name].Add(currentEvolv);
            }

            foreach (var item in book)
            {
                Console.WriteLine($"# {item.Key}");
                foreach (var item2 in item.Value.OrderByDescending(a => a.EvolutionIndex))
                {
                    Console.WriteLine($"{item2.EvolutionType} <-> {item2.EvolutionIndex}");
                }
            }
        }
    }
}
