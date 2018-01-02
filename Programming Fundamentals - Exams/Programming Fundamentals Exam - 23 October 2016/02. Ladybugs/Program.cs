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
            StartProgram();
        }

        private static void StartProgram()
        {
            var arrayLenght = int.Parse(Console.ReadLine());
            var indexsBirds = Console.ReadLine()
                .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var book = new List<int>();
            book = PutBirds(arrayLenght, indexsBirds, book);
            book = MakesAllCalculations(book);
            Console.WriteLine(string.Join(" ", book));
        }

        private static List<int> MakesAllCalculations(List<int> book)
        {
            while (true)
            {
                var input = Console.ReadLine();

                if (input == "end")
                {
                    break;
                }

                var validInput = input.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                var index = int.Parse(validInput[0]);
                var direction = validInput[1];
                var flyLenght = int.Parse(validInput[2]);

                if (index < 0 || index > book.Count() - 1)
                {
                    continue;
                }

                if (book[index] == 0)
                {
                    continue;
                }
                book = ChecksDirectionsAndMakeCal(flyLenght, book, index, direction);
            }
            return book;
        }

        private static List<int> ChecksDirectionsAndMakeCal(int flyLenght, List<int> book, int index, string direction)
        {
            var birdGo = "";
            if ((direction == "right" && flyLenght > 0) || (direction == "left" && flyLenght < 0))
            {
                birdGo = "right";
                book = BirdFly(flyLenght, book, index, birdGo);

            }
            else if ((direction == "right" && flyLenght < 0) || (direction == "left" && flyLenght > 0))
            {
                birdGo = "left";
                book = BirdFly(flyLenght, book, index, birdGo);
            }
            return book;
        }

        private static List<int> BirdFly(int flyLenght, List<int> book, int index, string birdGo)
        {
            var currentFly = Math.Abs(flyLenght);
            book[index] = 0;
            while (true)
            {
                if (birdGo == "right")
                {
                    index += currentFly;
                }
                else if (birdGo == "left")
                {
                    index -= currentFly;
                }
                if (birdGo == "right")
                {
                    if (index > book.Count() - 1)
                    {
                        return book;
                    }
                }
                else if (birdGo == "left")
                {
                    if (index < 0)
                    {
                        return book;
                    }
                }
                if (book[index] == 0)
                {
                    var newBook = book.Take(index).ToList();
                    newBook.Add(1);
                    newBook.AddRange(book.Skip(index + 1).ToList());
                    book = newBook;
                    return book;
                }
            }
        }

        private static List<int> PutBirds(int arrayLenght, int[] indexsBirds, List<int> book)
        {
            for (int i = 0; i < arrayLenght; i++)
            {
                if (indexsBirds.Contains(i))
                {
                    book.Add(1);
                }
                else
                {
                    book.Add(0);
                }
            }
            return book;
        }
    }
}
