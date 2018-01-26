using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Vapor_Store
{
    class Program
    {
        static void Main(string[] args)
        {
            var currentBallance = double.Parse(Console.ReadLine());
            double totalSum = currentBallance;

            while (true)
            {
                var input = Console.ReadLine();

                if (input == "Game Time")
                {
                    break;
                }

                if (input == "OutFall 4")
                {
                    if (currentBallance - 39.99 < 0)
                    {
                        Console.WriteLine("Too Expensive");
                    }
                    else {
                        currentBallance -= 39.99;
                        Console.WriteLine($"Bought {input}");
                    }
                }
                else if (input == "CS: OG")
                {
                    if (currentBallance - 15.99 < 0)
                    {
                        Console.WriteLine("Too Expensive");
                    }
                    else
                    {
                        currentBallance -= 15.99;
                        Console.WriteLine($"Bought {input}");
                    }
                }
                else if (input == "Zplinter Zell")
                {
                    if (currentBallance - 19.99 < 0)
                    {
                        Console.WriteLine("Too Expensive");
                    }
                    else
                    {
                        currentBallance -= 19.99;
                        Console.WriteLine($"Bought {input}");
                    }
                }
                else if (input == "Honored 2")
                {
                    if (currentBallance - 59.99 < 0)
                    {
                        Console.WriteLine("Too Expensive");
                    }
                    else
                    {
                        currentBallance -= 59.99;
                        Console.WriteLine($"Bought {input}");
                    }
                }
                else if (input == "RoverWatch")
                {
                    if (currentBallance - 29.99 < 0)
                    {
                        Console.WriteLine("Too Expensive");
                    }
                    else
                    {
                        currentBallance -= 29.99;
                        Console.WriteLine($"Bought {input}");
                    }
                }
                else if (input == "RoverWatch Origins Edition")
                {
                    if (currentBallance - 39.99 < 0)
                    {
                        Console.WriteLine("Too Expensive");
                    }
                    else
                    {
                        currentBallance -= 39.99;
                        Console.WriteLine($"Bought {input}");
                    }
                }
                else
                {
                    Console.WriteLine($"Not Found");
                }
                if (currentBallance == 0) {
                    Console.WriteLine($"Out of money!");
                    return;
                }
            }
            Console.WriteLine($"Total spent: ${(totalSum - currentBallance):f2}. Remaining: ${(currentBallance):f2}");
        }
    }
}
