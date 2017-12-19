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

            foreach (var tiket in tikets)
            {
                var currentTiket = tiket.Trim(' ');

                if (currentTiket.Length != 20)
                {
                    Console.WriteLine($"invalid ticket");
                    continue;
                }

                var leftPart = new string(currentTiket.Take(10).ToArray());
                var rightPart = new string(currentTiket.Skip(10).ToArray());

                if (leftPart.Contains('@') && rightPart.Contains('@'))
                {
                    Match leftMatch = Regex.Match(leftPart, @"\@+");
                    Match rightMatch = Regex.Match(rightPart, @"\@+");

                    if (Math.Min(leftMatch.Length, rightMatch.Length) >= 6 && Math.Min(leftMatch.Length, rightMatch.Length) < 10)
                    {
                        Console.WriteLine($"ticket \"{currentTiket}\" - {Math.Min(leftMatch.Length, rightMatch.Length)}@");
                        continue;
                    }
                    else if (leftMatch.Length == 10 && rightMatch.Length == 10)
                    {
                        Console.WriteLine($"ticket \"{currentTiket}\" - 10@ Jackpot!");
                        continue;
                    }
                }

                if (leftPart.Contains('#') && rightPart.Contains('#'))
                {
                    Match leftMatch = Regex.Match(leftPart, @"\#+");
                    Match rightMatch = Regex.Match(rightPart, @"\#+");

                    if (Math.Min(leftMatch.Length, rightMatch.Length) >= 6 && Math.Min(leftMatch.Length, rightMatch.Length) < 10)
                    {
                        Console.WriteLine($"ticket \"{currentTiket}\" - {Math.Min(leftMatch.Length, rightMatch.Length)}#");
                        continue;
                    }
                    else if (leftMatch.Length == 10 && rightMatch.Length == 10)
                    {
                        Console.WriteLine($"ticket \"{currentTiket}\" - 10# Jackpot!");
                        continue;
                    }
                }

                if (leftPart.Contains('$') && rightPart.Contains('$'))
                {
                    Match leftMatch = Regex.Match(leftPart, @"\$+");
                    Match rightMatch = Regex.Match(rightPart, @"\$+");

                    if (Math.Min(leftMatch.Length, rightMatch.Length) >= 6 && Math.Min(leftMatch.Length, rightMatch.Length) < 10)
                    {
                        Console.WriteLine($"ticket \"{currentTiket}\" - {Math.Min(leftMatch.Length, rightMatch.Length)}$");
                        continue;
                    }
                    else if (leftMatch.Length == 10 && rightMatch.Length == 10)
                    {
                        Console.WriteLine($"ticket \"{currentTiket}\" - 10$ Jackpot!");
                        continue;
                    }
                }

                if (leftPart.Contains('^') && rightPart.Contains('^'))
                {
                    Match leftMatch = Regex.Match(leftPart, @"\^+");
                    Match rightMatch = Regex.Match(rightPart, @"\^+");

                    if (Math.Min(leftMatch.Length, rightMatch.Length) >= 6 && Math.Min(leftMatch.Length, rightMatch.Length) < 10)
                    {
                        Console.WriteLine($"ticket \"{currentTiket}\" - {Math.Min(leftMatch.Length, rightMatch.Length)}^");
                        continue;
                    }
                    else if (leftMatch.Length == 10 && rightMatch.Length == 10)
                    {
                        Console.WriteLine($"ticket \"{currentTiket}\" - 10^ Jackpot!");
                        continue;
                    }
                }

                Console.WriteLine($"ticket \"{currentTiket}\" - no match");
            }
        }
    }
}
