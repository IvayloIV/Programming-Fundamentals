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
        class Result
        {
            public long TableResult { get; set; }
            public long Goals { get; set; }

            public void SetValues()
            {
                this.TableResult = 0;
                this.TableResult = 0;
            }
        }
        static void Main(string[] args)
        {
            StartProgram();
        }

        private static void StartProgram()
        {
            var book = new Dictionary<string, Result>();
            var regex = Regex.Escape(Console.ReadLine());

            book = CalculateBook(book, regex);
            PrintResult(book);
        }

        private static void PrintResult(Dictionary<string, Result> book)
        {
            PrintTableScore(book);
            PrintTop3Goals(book);
        }

        private static void PrintTop3Goals(Dictionary<string, Result> book)
        {
            Console.WriteLine($"Top 3 scored goals:");
            foreach (var item in book.OrderByDescending(a => a.Value.Goals).ThenBy(a => a.Key).Take(3))
            {
                Console.WriteLine($"- {item.Key} -> {item.Value.Goals}");
            }
        }

        private static void PrintTableScore(Dictionary<string, Result> book)
        {
            var count = 1;
            Console.WriteLine($"League standings:");
            foreach (var item in book.OrderByDescending(a => a.Value.TableResult).ThenBy(a => a.Key))
            {
                Console.WriteLine($"{count}. {item.Key} {item.Value.TableResult}");
                count++;
            }
        }

        private static Dictionary<string, Result> CalculateBook(Dictionary<string, Result> book, string regex)
        {
            while (true)
            {
                var input = Console.ReadLine();

                if (input == "final")
                {
                    break;
                }
                MatchCollection findingTeams = Regex.Matches(input, $@"{regex}(.*?){regex}");

                var firstTeam = new string(findingTeams[0].Groups[1].Value.ToUpper().Reverse().ToArray());
                var secoundTeam = new string(findingTeams[1].Groups[1].Value.ToUpper().Reverse().ToArray());

                var results = input.Split(new string[] { ":", " " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                var firstTeamResult = long.Parse(results[results.Length - 2]);
                var secoundTeamResult = long.Parse(results[results.Length - 1]);

                book = CheckBookForKey(firstTeam, book);
                book = CheckBookForKey(secoundTeam, book);

                book = AddTableScores(firstTeam, secoundTeam, secoundTeamResult, firstTeamResult, book);
                book = AddGoals(book, firstTeam, secoundTeam, firstTeamResult, secoundTeamResult);
            }
            return book;
        }

        private static Dictionary<string, Result> CheckBookForKey(string v, Dictionary<string, Result> book)
        {
            if (!book.ContainsKey(v))
            {
                book[v] = new Result();
            }
            return book;
        }

        private static Dictionary<string, Result> AddGoals(Dictionary<string, Result> book,
            string firstTeam, string secoundTeam, 
            long firstTeamResult, long secoundTeamResult)
        {
            book[firstTeam].Goals += firstTeamResult;
            book[secoundTeam].Goals += secoundTeamResult;
            return book;
        }

        private static Dictionary<string, Result> AddTableScores(string firstTeam, 
            string secoundTeam, long secoundTeamResult,
            long firstTeamResult, Dictionary<string, Result> book)
        {
            if (firstTeamResult > secoundTeamResult)
            {
                book[firstTeam].TableResult += 3;
            }
            else if (firstTeamResult == secoundTeamResult)
            {
                book[firstTeam].TableResult += 1;
                book[secoundTeam].TableResult += 1;
            }
            else if (firstTeamResult < secoundTeamResult)
            {
                book[secoundTeam].TableResult += 3;
            }
            return book;
        }
    }
}
