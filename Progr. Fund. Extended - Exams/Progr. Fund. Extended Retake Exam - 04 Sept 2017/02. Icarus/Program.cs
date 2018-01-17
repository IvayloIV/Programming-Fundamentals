using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Icarus
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            var currentPosition = int.Parse(Console.ReadLine());

            var power = 1;
            while (true)
            {
                var input = Console.ReadLine();

                if (input == "Supernova")
                {
                    break;
                }

                var splitInput = input.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).ToList();
                var direction = splitInput[0];
                var steps = int.Parse(splitInput[1]);

                if (direction == "left")
                {
                    while (steps > 0)
                    {
                        currentPosition--;
                        if (currentPosition < 0)
                        {
                            currentPosition = arr.Count() - 1;
                            power++;
                        }
                        arr[currentPosition] -= power;
                        steps--;
                    }
                }
                else if (direction == "right")
                {
                    while (steps > 0)
                    {
                        currentPosition++;
                        if (currentPosition > arr.Count() - 1)
                        {
                            currentPosition = 0;
                            power++;
                        }
                        arr[currentPosition] -= power;
                        steps--;
                    }
                }
            }
            Console.WriteLine(string.Join(" ", arr));
        }
    }
}
