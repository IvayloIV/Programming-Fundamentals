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
            public string Team { get; set; }
            public List<string> Participant { get; set; }
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

                var currentInput = input.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                var id = currentInput[0].Trim(' ');
                var team = currentInput[1].Trim(' ');
                var participants = new List<string>();

                if (!team.Contains('#'))
                {
                    continue;
                }

                var isOkye = true;
                for (int i = 2; i < currentInput.Length; i++)
                {
                    if (!currentInput[i].Contains('@'))
                    {
                        isOkye = false;
                        break;
                    }
                    participants.Add(currentInput[i].Trim(' '));
                }

                if (!isOkye)
                {
                    continue;
                }

                if (!book.ContainsKey(id))
                {
                    book[id] = new Roli();
                    book[id].Team = team;
                    book[id].Participant = new List<string>();
                    book[id].Participant.AddRange(participants);
                }
                else
                {
                    if (book[id].Team != team)
                    {
                        continue;
                    }

                    book[id].Participant.AddRange(participants);
                }
            }

            foreach (var item in book.OrderByDescending(a => a.Value.Participant.Distinct().Count()).ThenBy(a => a.Value.Team))
            {
                Console.WriteLine($"{item.Value.Team.Trim('#')} - {item.Value.Participant.Distinct().Count()}");
                foreach (var item2 in item.Value.Participant.Distinct().OrderBy(a => a))
                {
                    Console.WriteLine($"{item2}");
                }
            }
        }
    }
}
