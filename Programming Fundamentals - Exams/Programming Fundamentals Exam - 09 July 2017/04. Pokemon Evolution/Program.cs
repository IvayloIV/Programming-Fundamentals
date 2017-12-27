using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Pokemon_Evolution
{
    class Program
    {
        class Evolution
        {
            public string EvolutionType { get; set; }
            public long EvolutionIndex { get; set; }
        }
        static void Main(string[] args)
        {
            var book = new Dictionary<string, List<Evolution>>();

            while (true)
            {
                var input = Console.ReadLine();

                if (input == "wubbalubbadubdub")
                {
                    break;
                }

                var splitInput = input.Split(new string[] { " -> " },StringSplitOptions.RemoveEmptyEntries).ToArray();

                if (splitInput.Length == 1)
                {
                    foreach (var item in book.Where(a => a.Key == splitInput[0]))
                    {
                        Console.WriteLine($"# {item.Key}");
                        foreach (var item2 in item.Value)
                        {
                            Console.WriteLine($"{item2.EvolutionType} <-> {item2.EvolutionIndex}");
                        }
                    }
                }
                else
                {
                    var pokemonName = splitInput[0];
                    var evolutionType = splitInput[1];
                    var evolutionIndex = long.Parse(splitInput[2]);

                    if (!book.ContainsKey(pokemonName))
                    {
                        book[pokemonName] = new List<Evolution>();
                    }
                    var currentEvoludion = new Evolution();
                    currentEvoludion.EvolutionType = evolutionType;
                    currentEvoludion.EvolutionIndex = evolutionIndex;
                    book[pokemonName].Add(currentEvoludion);
                }
            }
            PrintResult(book);
        }

        private static void PrintResult(Dictionary<string, List<Evolution>> book)
        {
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
