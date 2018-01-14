using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Snowwhite
{
    class Program
    {
        class Draft
        {
            public string Name { get; set; }
            public string Color { get; set; }
            public long Physics { get; set; }
        }

        static void Main(string[] args)
        {
            var book = new List<Draft>();

            while (true)
            {
                var input = Console.ReadLine();

                if (input == "Once upon a time")
                {
                    break;
                }

                var splitInput = input.Split(new[] { " <:> " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                var name = splitInput[0];
                var color = splitInput[1];
                var physics = long.Parse(splitInput[2]);

                if (book.All(a => a.Name != name))
                {
                    var newObj = new Draft
                    {
                        Name = name,
                        Color = color,
                        Physics = physics
                    };
                    book.Add(newObj);
                }
                else
                {
                    if (book.Where(a => a.Name == name).All(a => a.Color != color))
                    {
                        var newObj = new Draft
                        {
                            Name = name,
                            Color = color,
                            Physics = physics
                        };
                        book.Add(newObj);
                    }
                    else
                    {
                        foreach (var item in book.Where(a => a.Name == name && a.Color == color))
                        {
                            if (item.Physics < physics)
                            {
                                item.Physics = physics;
                            }
                        }
                    }
                }
                
            }

            PrintResult(book);
        }

        private static void PrintResult(List<Draft> book)
        {
            foreach (var item in book.OrderByDescending(a => a.Physics).ThenByDescending(a => a.Color))
            {
                Console.WriteLine($"({item.Color}) {item.Name} <-> {item.Physics}");
            }
        }
    }
}
