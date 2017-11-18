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
            var arr = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            var startPosition = int.Parse(Console.ReadLine());
            var power = 1;

            while (true)
            {
                var input = Console.ReadLine();

                if (input == "Supernova")
                {
                    break;
                }

                var allInput = input.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                var direction = allInput[0];
                var steps = int.Parse(allInput[1]);

                if (direction == "right")
                {
                    for (int i = 0; i < steps; i++)
                    {
                        startPosition++;
                        if (startPosition > arr.Length - 1)
                        {
                            startPosition = 0;
                            power++;
                            arr[startPosition] -= power;
                        }
                        else
                        {
                            arr[startPosition] -= power;
                        }                       
                    }
                }
                else if (direction == "left")
                {
                    for (int i = 0; i < steps; i++)
                    {
                        startPosition--;
                        if (startPosition < 0)
                        {
                            startPosition = arr.Length - 1;
                            power++;
                            arr[startPosition] -= power;
                        }
                        else
                        {
                            arr[startPosition] -= power;
                        }                       
                    }
                }
            }
            Console.WriteLine(string.Join(" ", arr));
        }
    }
}
