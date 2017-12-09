using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Roli_The_Coder
{
    class Program
    {

        class Teams
        {
            public string Team { get; set; }
            public List<string> Participant { get; set; }
        }

        static void Main(string[] args)
        {
            var book = new Dictionary<string, Teams>();

            while (true)
            {
                var input = Console.ReadLine();

                if (input == "Time for Code")
                {
                    break;
                }

                var currentInput = input.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                if (currentInput.Length < 2)
                {
                    continue;
                }
                var id = currentInput[0];
                var team = currentInput[1];
                var participant = new List<string>();

                if (!team.StartsWith("#"))
                {
                    continue;
                }

                var isOkey = true;
                for (int i = 2; i <= currentInput.Length - 1; i++)
                {
                    if (!currentInput[i].StartsWith("@"))
                    {
                        isOkey = false;
                        break;
                    }
                    participant.Add(currentInput[i]);
                }

                if (!isOkey)
                {
                    continue;
                }

                if (!book.ContainsKey(id))
                {
                    book[id] = new Teams();
                    book[id].Team = team;
                    book[id].Participant = new List<string>();
                    book[id].Participant.AddRange(participant);
                }
                else
                {
                    if (book[id].Team == team)
                    {
                        book[id].Participant.AddRange(participant);
                    }
                }
            }

            foreach (var item in book.OrderByDescending(a => a.Value.Participant.Distinct().Count()).ThenBy(a => a.Value.Team))
            {
                Console.WriteLine($"{item.Value.Team.TrimStart('#')} - {item.Value.Participant.Distinct().Count()}");
                foreach (var item2 in item.Value.Participant.Distinct().OrderBy(a => a))
                {
                    Console.WriteLine($"{item2}");
                }
            }
        }
    }
}
