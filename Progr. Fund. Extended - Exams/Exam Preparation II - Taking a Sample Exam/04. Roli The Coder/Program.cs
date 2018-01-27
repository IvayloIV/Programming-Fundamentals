using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Roli_The_Coder
{
    class Program
    {
        class Roli
        {
            public string Name { get; set; }
            public List<string> Teams { get; set; }
        }

        static void Main(string[] args)
        {
            var book = new Dictionary<long, Roli>();

            while (true)
            {
                var input = Console.ReadLine();

                if (input == "Time for Code")
                {
                    break;
                }

                var inputTokens = input.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                var id = long.Parse(inputTokens[0]);
                var name = inputTokens[1];
                if (!name.StartsWith("#")) {
                    continue;
                }
                var participants = new List<string>();
                var isOkey = true;
                for (int i = 2; i < inputTokens.Length; i++)
                {
                    var currentParticipant = inputTokens[i];
                    if (!currentParticipant.StartsWith("@"))
                    {
                        isOkey = false;
                        break;
                    }
                    participants.Add(currentParticipant);
                }
                if (!isOkey)
                {
                    continue;
                }

                book = AddToBook(book, id, name, participants);
                if (!book.ContainsKey(id))
                {
                    var newRoli = new Roli();
                    newRoli.Name = name;
                    newRoli.Teams = participants;
                    book[id] = newRoli;
                }
                else
                {
                    if (book[id].Name != name)
                    {
                        continue;
                    }
                    book[id].Teams.AddRange(participants);
                }
            }
            PrintResult(book);
        }

        private static Dictionary<long, Roli> AddToBook(Dictionary<long, Roli> book, long id, string name, List<string> participants)
        {
            throw new NotImplementedException();
        }

        private static void PrintResult(Dictionary<long, Roli> book)
        {
            foreach (var item in book.OrderByDescending(a => a.Value.Teams.Distinct().Count()).ThenBy(a => a.Value.Name))
            {
                Console.WriteLine($"{item.Value.Name.TrimStart('#')} - {item.Value.Teams.Distinct().Count()}");
                foreach (var item2 in item.Value.Teams.Distinct().OrderBy(a => a))
                {
                    Console.WriteLine(item2);
                }
            }
        }
    }
}
