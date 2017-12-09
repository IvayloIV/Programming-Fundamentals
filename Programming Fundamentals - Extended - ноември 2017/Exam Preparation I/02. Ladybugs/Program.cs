using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Ladybugs
{
    class Program
    {
        static void Main(string[] args)
        {
            var arrayLenght = int.Parse(Console.ReadLine());
            var arr = new List<int>();
            var position = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            for (int i = 0; i < arrayLenght; i++)
            {
                if (position.Contains(i))
                {
                    arr.Add(1);
                }
                else
                {
                    arr.Add(0);
                }
            }

            while (true)
            {
                var input = Console.ReadLine();

                if (input == "end")
                {
                    break;
                }

                var currentInput = input.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                var ladyIndex = int.Parse(currentInput[0]);
                var direction = currentInput[1];
                var flyLenght = int.Parse(currentInput[2]);

                if (ladyIndex < 0 || ladyIndex > arr.Count - 1)
                {
                    continue;
                }

                if ((direction == "right" && flyLenght > 0) || (direction == "left" && flyLenght < 0))
                {
                    flyLenght = Math.Abs(flyLenght);
                    if (arr[ladyIndex] == 0)
                    {
                        continue;
                    }
                    else
                    {
                        arr[ladyIndex] = 0;
                    }
                    while (true)
                    {
                        ladyIndex += flyLenght;
                        if (ladyIndex > arr.Count - 1)
                        {
                            break;
                        }
                        if (arr[ladyIndex] == 1)
                        {
                            continue;
                        }
                        else
                        {
                            arr[ladyIndex] = 1;
                            break;
                        }
                    }
                }
                else if ((direction == "right" && flyLenght < 0) || (direction == "left" && flyLenght > 0))
                {
                    flyLenght = Math.Abs(flyLenght);
                    if (arr[ladyIndex] == 0)
                    {
                        continue;
                    }
                    else
                    {
                        arr[ladyIndex] = 0;
                    }
                    while (true)
                    {
                        ladyIndex -= flyLenght;
                        if (ladyIndex < 0)
                        {
                            break;
                        }
                        if (arr[ladyIndex] == 1)
                        {
                            continue;
                        }
                        else
                        {
                            arr[ladyIndex] = 1;
                            break;
                        }
                    }
                }
            }
            Console.WriteLine(string.Join(" ", arr));
        }
    }
}
