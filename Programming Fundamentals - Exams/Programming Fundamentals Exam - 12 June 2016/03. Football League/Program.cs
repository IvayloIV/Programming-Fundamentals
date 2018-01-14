using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.Football_League
{
    class Program
    {
        class InsideDoor
        {
            public long LeagueScore { get; set; }
            public long Goals { get; set; }
        }

        static void Main(string[] args)
        {
            StartProgram();
        }

        private static void StartProgram()
        {
            var special = Regex.Escape(Console.ReadLine());
            var book = new Dictionary<string, InsideDoor>();

            book = MakeLoop(special, book);

            PrintResult(book);
        }

        private static Dictionary<string, InsideDoor> MakeLoop(string special, Dictionary<string, InsideDoor> book)
        {
            while (true)
            {
                var input = Console.ReadLine();

                if (input == "final")
                {
                    break;
                }

                MatchCollection findingTeams = Regex.Matches(input, $@"{special}(.*?){special}");
                var firstTeam = new string(findingTeams[0].Groups[1].Value.ToUpper().Reverse().ToArray());
                var secoundTeam = new string(findingTeams[1].Groups[1].Value.ToUpper().Reverse().ToArray());

                var points = input
                    .Split(new string[] { ":", " " }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                var firstTeamScore = long.Parse(points[points.Length - 2]);
                var secoundTeamScore = long.Parse(points[points.Length - 1]);

                book = AddInBookAllThings(firstTeam, secoundTeam, book, firstTeamScore, secoundTeamScore);
            }
            return book;
        }

        private static Dictionary<string, InsideDoor> AddInBookAllThings(string firstTeam, 
            string secoundTeam, 
            Dictionary<string, InsideDoor> book, 
            long firstTeamScore, 
            long secoundTeamScore)
        {
            book = AddTeams(firstTeam, secoundTeam, book);
            book = AddLeagueScore(firstTeam, secoundTeam, book, firstTeamScore, secoundTeamScore);
            book = AddGoals(firstTeam, secoundTeam, book, firstTeamScore, secoundTeamScore);
            return book;
        }

        private static void PrintResult(Dictionary<string, InsideDoor> book)
        {
            PrintLeagueScore(book);
            PrintGoals(book);
        }

        private static void PrintGoals(Dictionary<string, InsideDoor> book)
        {
            Console.WriteLine("Top 3 scored goals:");
            foreach (var item in book.OrderByDescending(a => a.Value.Goals).ThenBy(a => a.Key).Take(3))
            {
                Console.WriteLine($"- {item.Key} -> {item.Value.Goals}");
            }
        }

        private static void PrintLeagueScore(Dictionary<string, InsideDoor> book)
        {
            Console.WriteLine("League standings:");
            var count = 1;
            foreach (var item in book.OrderByDescending(a => a.Value.LeagueScore).ThenBy(a => a.Key))
            {
                Console.WriteLine($"{count}. {item.Key} {item.Value.LeagueScore}");
                count++;
            }
        }

        private static Dictionary<string, InsideDoor> AddGoals(string firstTeam,
            string secoundTeam, 
            Dictionary<string, InsideDoor> 
            book, long firstTeamScore, 
            long secoundTeamScore)
        {
            book[firstTeam].Goals += firstTeamScore;
            book[secoundTeam].Goals += secoundTeamScore;
            return book;
        }

        private static Dictionary<string, InsideDoor> AddLeagueScore(string firstTeam, 
            string secoundTeam, 
            Dictionary<string, InsideDoor> book, 
            long firstTeamScore, 
            long secoundTeamScore)
        {
            if (firstTeamScore > secoundTeamScore)
            {
                book[firstTeam].LeagueScore += 3;
            }
            else if (firstTeamScore == secoundTeamScore)
            {
                book[firstTeam].LeagueScore += 1;
                book[secoundTeam].LeagueScore += 1;
            }
            else if (firstTeamScore < secoundTeamScore)
            {
                book[secoundTeam].LeagueScore += 3;
            }
            return book;
        }

        private static Dictionary<string, InsideDoor> AddTeams(string firstTeam, string secoundTeam, 
            Dictionary<string, InsideDoor> book)
        {
            if (!book.ContainsKey(firstTeam))
            {
                book[firstTeam] = new InsideDoor();
            }
            if (!book.ContainsKey(secoundTeam))
            {
                book[secoundTeam] = new InsideDoor();
            }
            return book;
        }
    }
}
