using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Exercises
{
    class Program
    {
        class Exercise
        {
            public string Topic { get; set; }
            public string CourseName { get; set; }
            public string JudgeContestLink { get; set; }
            public List<string> Problems { get; set; }
            public Exercise(string topic, string courseName, string judgeContest, List<string> problems)
            {
                Topic = topic;
                CourseName = courseName;
                JudgeContestLink = judgeContest;
                Problems = problems;
            }
        }
        static void Main(string[] args)
        {
            var book = new List<Exercise>();
            while (true)
            {
                var input = Console.ReadLine();
                if (input == "go go go")
                {
                    break;
                }
                var inputTokens = input.Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                book.Add(new Exercise(inputTokens[0], inputTokens[1], inputTokens[2], inputTokens[3].Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries).ToList()));
            }
            foreach (var item in book)
            {
                Console.WriteLine($"Exercises: {item.Topic}");
                Console.WriteLine($"Problems for exercises and homework for the \"{item.CourseName}\" course @ SoftUni.");
                Console.WriteLine($"Check your solutions here: {item.JudgeContestLink}");
                var count = 1;
                foreach (var item2 in item.Problems)
                {
                    Console.WriteLine($"{count}. {item2}");
                    count++;
                }
            }
        }
    }
}
