using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Japanese_Roulette
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var startIndex = arr.IndexOf(1);
            var participants = Console.ReadLine().Split(' ').ToList();
            var isBombExpos = false;
            var count = 0;
            foreach (var currentPart in participants)
            {
                var partTokens = currentPart.Split(',').ToList();
                var power = int.Parse(partTokens[0]);
                var direction = partTokens[1];
                if (direction == "Left")
                {
                    for (int i = 0; i < power; i++)
                    {
                        startIndex--;
                        if (startIndex < 0)
                        {
                            startIndex = arr.Count() - 1;
                        }
                    }
                }
                else if (direction == "Right")
                {
                    for (int i = 0; i < power; i++)
                    {
                        startIndex++;
                        if (startIndex > arr.Count() - 1)
                        {
                            startIndex = 0;
                        }
                    }
                }
                if (startIndex == 2)
                {
                    isBombExpos = true;
                    break;
                }
                startIndex++;
                if (startIndex > arr.Count() - 1)
                {
                    startIndex = 0;
                }
                count++;
            }
            if (isBombExpos)
            {
                Console.WriteLine($"Game over! Player {count} is dead.");
            }
            else
            {
                Console.WriteLine($"Everybody got lucky!");
            }
        }
    }
}
