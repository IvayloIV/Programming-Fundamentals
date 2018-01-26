using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04.Winning_Ticket
{
    class Program
    {
        static void Main(string[] args)
        {
            var tikets = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            foreach (var e in tikets)
            {
                var ticket = e.Trim();

                if (ticket.Length != 20)
                {
                    Console.WriteLine("invalid ticket");
                    continue;
                }

                var leftPart = new string(ticket.Take(10).ToArray());
                var rightPart = new string(ticket.Skip(10).ToArray());

                var isFind = true;

                isFind = FindMonkey('@', leftPart, rightPart, isFind, ticket);
                if (!isFind)
                {
                    continue;
                }
                isFind = FindMonkey('#', leftPart, rightPart, isFind, ticket);
                if (!isFind)
                {
                    continue;
                }
                isFind = FindMonkey('$', leftPart, rightPart, isFind, ticket);
                if (!isFind)
                {
                    continue;
                }
                isFind = FindMonkey('^', leftPart, rightPart, isFind, ticket);
                if (!isFind)
                {
                    continue;
                }
                if (isFind)
                {
                    Console.WriteLine($"ticket \"{ticket}\" - no match");
                }
            }
        }

        private static bool FindMonkey(char v, string leftPart, string rightPart, bool isFind, string ticket)
        {
            if (leftPart.Contains(v) && rightPart.Contains(v))
            {
                Match findingsLeft = Regex.Match(leftPart, $@"\{v}+");
                Match findingsRight = Regex.Match(rightPart, $@"\{v}+");

                if (findingsLeft.Length == 10 && findingsRight.Length == 10)
                {
                    Console.WriteLine($"ticket \"{ticket}\" - 10{v} Jackpot!");
                    return false;
                }
                else if (Math.Min(findingsLeft.Length, findingsRight.Length) >= 6)
                {
                    Console.WriteLine($"ticket \"{ticket}\" - {Math.Min(findingsLeft.Length, findingsRight.Length)}{v}");
                    return false;
                }
            }
            return true;
        }
    }
}
