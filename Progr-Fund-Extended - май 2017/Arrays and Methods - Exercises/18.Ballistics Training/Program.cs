using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.Ballistics_Training
{
    class Program
    {
        static void Main(string[] args)
        {
            var coordinates = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();
            var commands = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            var x = 0d;
            var y = 0d;

            for (int i = 0; i < commands.Length; i += 2)
            {
                var direction = commands[i];
                var steps = double.Parse(commands[i + 1]);
                if (direction == "up")
                {
                    y += steps;
                }
                else if (direction == "down")
                {
                    y -= steps;
                }
                else if (direction == "right")
                {
                    x += steps;
                }
                else if (direction == "left")
                {
                    x -= steps;
                }
            }
            Console.WriteLine($"firing at [{x}, {y}]");
            if (x == coordinates[0] && y == coordinates[1])
            {
                Console.WriteLine($"got 'em!");
            }
            else
            {
                Console.WriteLine($"better luck next time...");
            }
        }
    }
}
