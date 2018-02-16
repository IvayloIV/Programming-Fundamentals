using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Rabbit_Hole
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).ToList();
            var power = long.Parse(Console.ReadLine());
            int index = 0;
            while (power >= 0)
            {           
                var tokens = arr[index].Split('|').ToArray();
                if (tokens[0] == "RabbitHole")
                {
                    Console.WriteLine("You have 5 years to save Kennedy!");
                    return;
                }
                else if (tokens[0] == "Left")
                {
                    power -= long.Parse(tokens[1]);
                    index = Math.Abs(index - int.Parse(tokens[1])) % arr.Count;
                }
                else if (tokens[0] == "Right")
                {
                    power -= long.Parse(tokens[1]);
                    index = Math.Abs(index + int.Parse(tokens[1])) % arr.Count;
                }
                else if (tokens[0] == "Bomb")
                {
                    power -= long.Parse(tokens[1]);
                    arr.RemoveAt(index);
                    index = 0;
                    if (power <= 0)
                    {
                        Console.WriteLine("You are dead due to bomb explosion!");
                        return;
                    }
                }
                if (arr[arr.Count() - 1] != "RabbitHole")
                {
                    arr.RemoveAt(arr.Count() - 1);
                }
                arr.Add($"Bomb|{power}");
            }
            Console.WriteLine($"You are tired. You can't continue the mission.");
        }
    }
}
