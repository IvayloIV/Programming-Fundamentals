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
            var arrLenght = int.Parse(Console.ReadLine());
            var position = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            var book = new List<string>();

            for (int i = 0; i < arrLenght; i++)
            {
                if (position.Contains(i))
                {
                    book.Add("1");
                }
                else
                {
                    book.Add("0");
                }
            }

            while (true)
            {
                var input = Console.ReadLine();

                if (input == "end")
                {
                    break;
                }

                var currentInput = input.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                var ladyIndex = int.Parse(currentInput[0]);
                var direction = currentInput[1];
                var flyLenght = int.Parse(currentInput[2]);

                if (ladyIndex < 0 || ladyIndex > book.Count() - 1)
                {
                    continue;
                }

                if (book[ladyIndex] == "0")
                {
                    continue;
                }

                if ((direction == "right" && flyLenght > 0) || (direction == "left" && flyLenght < 0))
                {
                    var currentFly = Math.Abs(flyLenght);

                    book[ladyIndex] = "0";
                    while (true)
                    {
                        ladyIndex += currentFly;
                        if (ladyIndex > book.Count() - 1)
                        {
                            break;
                        }

                        if (book[ladyIndex] == "0")
                        {
                            book[ladyIndex] = "1";
                            break;
                        }
                    }
                }
                else if ((direction == "left" && flyLenght > 0) || (direction == "right" && flyLenght < 0))
                {
                    var currentFly = Math.Abs(flyLenght);

                    book[ladyIndex] = "0";
                    while (true)
                    {
                        ladyIndex -= currentFly;
                        if (ladyIndex < 0)
                        {
                            break;
                        }

                        if (book[ladyIndex] == "0")
                        {
                            book[ladyIndex] = "1";
                            break;
                        }
                    }
                }
            }
            Console.WriteLine(string.Join(" ", book));
        }
    }
}
