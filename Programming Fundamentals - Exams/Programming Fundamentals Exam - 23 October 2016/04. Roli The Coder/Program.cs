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
            public string EventName { get; set; }
            public List<string> Partisipant { get; set; }
        }
        static void Main(string[] args)
        {
            var book = new Dictionary<string, Roli>();

            while (true)
            {
                var input = Console.ReadLine();

                if (input == "Time for Code")
                {
                    break;
                }

                var splitInput = input.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                var id = splitInput[0];
                var eventName = splitInput[1];

                if (!eventName.Contains('#'))
                {
                    continue;
                }

                List<string> participant = new List<string>();
                bool isOkey = CheckForM(splitInput, participant);

                if (!isOkey)
                {
                    continue;
                }
                book = AddInBook(book, eventName, participant, id);
            }
            PrintResult(book);
        }

        private static bool CheckForM(string[] splitInput, List<string> participant)
        {
            for (int i = 2; i < splitInput.Length; i++)
            {
                if (!splitInput[i].Contains('@'))
                {
                    return false;
                }
                participant.Add(splitInput[i]);
            }
            return true;
        }

        private static Dictionary<string, Roli> AddInBook(Dictionary<string, 
            Roli> book, 
            string eventName, 
            List<string> participant, 
            string id)
        {
            if (!book.ContainsKey(id))
            {
                book[id] = new Roli();
                book[id].EventName = eventName;
                book[id].Partisipant = new List<string>();
                book[id].Partisipant.AddRange(participant);
            }
            else
            {
                if (book[id].EventName != eventName)
                {
                    return book;
                }
                book[id].Partisipant.AddRange(participant);
            }
            return book;
        }

        private static void PrintResult(Dictionary<string, Roli> book)
        {
            foreach (var item in book.OrderByDescending(a => a.Value.Partisipant.Distinct().Count()).ThenBy(a => a.Value.EventName))
            {
                Console.WriteLine($"{item.Value.EventName.Trim('#')} - {item.Value.Partisipant.Distinct().Count()}");
                foreach (var item2 in item.Value.Partisipant.Distinct().OrderBy(a => a))
                {
                    Console.WriteLine($"{item2}");
                }
            }
        }
    }
}
