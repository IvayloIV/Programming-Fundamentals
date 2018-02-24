using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _08.Commits
{
    class Program
    {
        class TypeRepo
        {
            public string Hash { get; set; }
            public string Message { get; set; }
            public int AdditionsCount { get; set; }
            public int DeletionsCount { get; set; }
            public TypeRepo(string hash, string message, int add, int delete)
            {
                Hash = hash;
                Message = message;
                AdditionsCount = add;
                DeletionsCount = delete;
            }
        }
        static void Main(string[] args)
        {
            var book = new Dictionary<string, Dictionary<string, List<TypeRepo>>>();
            while (true)
            {
                var input = Console.ReadLine();
                if (input == "git push")
                {
                    break;
                }
                Match findings = Regex.Match(input, @"https:\/\/github\.com\/(?<username>[A-Za-z0-9-]+)\/(?<repo>[A-Za-z_-]+)\/commit\/(?<hash>[0-9a-f]{40}),(?<message>[^\n]+),(?<add>[0-9]+),(?<delete>[0-9]+)");
                if (!findings.Success) continue;
                var userName = findings.Groups["username"].Value;
                var repo = findings.Groups["repo"].Value;
                var hash = findings.Groups["hash"].Value;
                var message = findings.Groups["message"].Value;
                var add = int.Parse(findings.Groups["add"].Value);
                var delete = int.Parse(findings.Groups["delete"].Value);
                if (!book.ContainsKey(userName))
                {
                    book[userName] = new Dictionary<string, List<TypeRepo>>();
                }
                if (!book[userName].ContainsKey(repo))
                {
                    book[userName][repo] = new List<TypeRepo>();
                }
                book[userName][repo].Add(new TypeRepo(hash, message, add, delete));
            }
            foreach (var item in book.OrderBy(a => a.Key))
            {
                Console.WriteLine($"{item.Key}:");
                foreach (var item2 in item.Value.OrderBy(a => a.Key))
                {
                    Console.WriteLine($"  {item2.Key}:");
                    foreach (var item3 in item2.Value)
                    {
                        Console.WriteLine($"    commit {item3.Hash}: {item3.Message} ({item3.AdditionsCount} additions, {item3.DeletionsCount} deletions)");
                    }
                    Console.WriteLine($"    Total: {item2.Value.Sum(a => a.AdditionsCount)} additions, {item2.Value.Sum(a => a.DeletionsCount)} deletions");
                }
            }
        }
    }
}
