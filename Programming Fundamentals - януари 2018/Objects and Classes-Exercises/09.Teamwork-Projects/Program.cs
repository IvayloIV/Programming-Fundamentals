using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Teamwork_Projects
{
    class Program
    {
        class Team
        {
            public string Creator { get; set; }
            public string TeamName { get; set; }
            public List<string> Teams { get; set; }
            public Team(string creator, string teamName)
            {
                Creator = creator;
                TeamName = teamName;
                Teams = new List<string>();
            }
        }
        static void Main(string[] args)
        {
            var book = new List<Team>();
            var n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var inputTokens = Console.ReadLine().Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                var creator = inputTokens[0];
                var teamName = inputTokens[1];
                if (book.Any(a => a.TeamName == teamName))
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                    continue;
                }
                if (book.Any(a => a.Creator == creator))
                {
                    Console.WriteLine($"{creator} cannot create another team!");
                    continue;
                }             
                book.Add(new Team(creator, teamName));
                Console.WriteLine($"Team {teamName} has been created by {creator}!");
            }
            while (true)
            {
                var input = Console.ReadLine();
                if (input == "end of assignment")
                {
                    break;
                }
                var inputTokens = input.Split(new string[] { "->" }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                var member = inputTokens[0];
                var team = inputTokens[1];
                if (book.All(a => a.TeamName != team))
                {
                    Console.WriteLine($"Team {team} does not exist!");
                    continue;
                }
                if (book.Any(a => a.Teams.Contains(member)) || book.Any(a => a.Creator == member))
                {
                    Console.WriteLine($"Member {member} cannot join team {team}!");
                    continue;
                }
                foreach (var item in book.Where(a => a.TeamName == team))
                {
                    item.Teams.Add(member);
                }
            }
            foreach (var item in book.OrderByDescending(a => a.Teams.Count).ThenBy(a => a.TeamName).Where(a => a.Teams.Count() > 0))
            {
                Console.WriteLine(item.TeamName);
                Console.WriteLine("- " + item.Creator);
                foreach (var item2 in item.Teams.OrderBy(a => a))
                {
                    Console.WriteLine($"-- {item2}");
                }
            }
            Console.WriteLine($"Teams to disband:");
            foreach (var item in book.OrderBy(a => a.TeamName).Where(a => a.Teams.Count() == 0))
            {
                Console.WriteLine(item.TeamName);
            }
        }
    }
}
