using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Problem_3.Football_Standings
{
    class Program
    {
        class StandAndGoals
        {
            public long Standing { get; set; }
            public long Goals { get; set; }
        }
        static void Main(string[] args)
        {
            StartProgram();
        }

        private static void StartProgram()
        {
            var key = Console.ReadLine();
            var parsingKey = Regex.Escape(key);
            var bookStanding = new Dictionary<String, StandAndGoals>();

            bookStanding = ReturnResult(parsingKey, bookStanding);
            PrintResult(bookStanding);
        }

        private static Dictionary<string, StandAndGoals> ReturnResult(string parsingKey, Dictionary<string, StandAndGoals> bookStanding)
        {
            while (true)
            {
                var text = Console.ReadLine();

                if (text == "final")
                {
                    break;
                }

                MatchCollection findingTeam = Regex.Matches(text, $@"{parsingKey}(.*?){parsingKey}");
                var book = new List<string>();

                foreach (Match item in findingTeam)
                {
                    var team = item.Groups[1].Value;
                    book.Add(team);
                }
                var team1 = new string(book[0].Reverse().ToArray()).ToUpper();
                var team2 = new string(book[1].Reverse().ToArray()).ToUpper();

                var charText = text.Split(new[] { ":", " " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                var firstTeamGoal = long.Parse(charText[charText.Length - 2].ToString());
                var secoundTeamGoal = long.Parse(charText[charText.Length - 1].ToString());

                if (!bookStanding.ContainsKey(team1))
                {
                    bookStanding[team1] = new StandAndGoals();
                    bookStanding[team1].Standing = 0;
                    bookStanding[team1].Goals = 0;
                }

                if (!bookStanding.ContainsKey(team2))
                {
                    bookStanding[team2] = new StandAndGoals();
                    bookStanding[team2].Standing = 0;
                    bookStanding[team2].Goals = 0;
                }

                if (firstTeamGoal == secoundTeamGoal)
                {
                    bookStanding[team1].Standing++;
                    bookStanding[team2].Standing++;
                }
                else if (firstTeamGoal < secoundTeamGoal)
                {
                    bookStanding[team2].Standing += 3;
                }
                else if (firstTeamGoal > secoundTeamGoal)
                {
                    bookStanding[team1].Standing += 3;
                }

                bookStanding[team1].Goals += firstTeamGoal;
                bookStanding[team2].Goals += secoundTeamGoal;
            }
            return bookStanding;
        }

        private static void PrintResult(Dictionary<string, StandAndGoals> bookStanding)
        {
            var count = 1;
            Console.WriteLine($"League standings:");
            foreach (var item in bookStanding.OrderByDescending(a => a.Value.Standing).ThenBy(a => a.Key))
            {
                Console.WriteLine($"{count}. {item.Key} {item.Value.Standing}");
                count++;
            }

            Console.WriteLine($"Top 3 scored goals:");
            foreach (var item in bookStanding.OrderByDescending(a => a.Value.Goals).ThenBy(a => a.Key).Take(3))
            {
                Console.WriteLine($"- {item.Key} -> {item.Value.Goals}");
            }
        }
    }
}
