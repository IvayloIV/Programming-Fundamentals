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
            var tickets = Console.ReadLine().Split(new string[] { ", " },StringSplitOptions.RemoveEmptyEntries).ToArray();

            foreach (var ticket in tickets)
            {
                var currentTicket = ticket.Trim(' ');
                if (currentTicket.Length == 20)
                {
                    var leftPart = new string(currentTicket.Take(10).ToArray());
                    var rightPart = new string(currentTicket.Skip(10).Take(10).ToArray());

                    if (leftPart.Contains('@') && rightPart.Contains('@'))
                    {
                        Match leftSize = Regex.Match(leftPart, @"\@+");
                        Match rightSize = Regex.Match(rightPart, @"\@+");
                        if (Math.Min(leftSize.Length, rightSize.Length) >= 6)
                        {
                            if (leftSize.Length == 10 && rightSize.Length == 10)
                            {
                                Console.WriteLine($"ticket \"{currentTicket}\" - 10@ Jackpot!");
                                continue;
                            }
                            else
                            {
                                Console.WriteLine($"ticket \"{currentTicket}\" - {Math.Min(leftSize.Length, rightSize.Length)}@");
                                continue;
                            }
                        }                       
                    }

                    if (leftPart.Contains('#') && rightPart.Contains('#'))
                    {
                        Match leftSize = Regex.Match(leftPart, @"\#+");
                        Match rightSize = Regex.Match(rightPart, @"\#+");
                        if (Math.Min(leftSize.Length, rightSize.Length) >= 6)
                        {
                            if (leftSize.Length == 10 && rightSize.Length == 10)
                            {
                                Console.WriteLine($"ticket \"{currentTicket}\" - 10# Jackpot!");
                                continue;
                            }
                            else
                            {
                                Console.WriteLine($"ticket \"{currentTicket}\" - {Math.Min(leftSize.Length, rightSize.Length)}#");
                                continue;
                            }
                        }
                    }

                    if (leftPart.Contains('$') && rightPart.Contains('$'))
                    {
                        Match leftSize = Regex.Match(leftPart, @"\$+");
                        Match rightSize = Regex.Match(rightPart, @"\$+");
                        if (Math.Min(leftSize.Length, rightSize.Length) >= 6)
                        {
                            if (leftSize.Length == 10 && rightSize.Length == 10)
                            {
                                Console.WriteLine($"ticket \"{currentTicket}\" - 10$ Jackpot!");
                                continue;
                            }
                            else
                            {
                                Console.WriteLine($"ticket \"{currentTicket}\" - {Math.Min(leftSize.Length, rightSize.Length)}$");
                                continue;
                            }
                        }
                    }

                    if (leftPart.Contains('^') && rightPart.Contains('^'))
                    {
                        Match leftSize = Regex.Match(leftPart, @"\^+");
                        Match rightSize = Regex.Match(rightPart, @"\^+");
                        if (Math.Min(leftSize.Length, rightSize.Length) >= 6)
                        {
                            if (leftSize.Length == 10 && rightSize.Length == 10)
                            {
                                Console.WriteLine($"ticket \"{currentTicket}\" - 10^ Jackpot!");
                                continue;
                            }
                            else
                            {
                                Console.WriteLine($"ticket \"{currentTicket}\" - {Math.Min(leftSize.Length, rightSize.Length)}^");
                                continue;
                            }
                        }
                    }
                    Console.WriteLine($"ticket \"{currentTicket}\" - no match");
                }
                else
                {
                    Console.WriteLine($"invalid ticket");
                }
            }
        }
    }
}
