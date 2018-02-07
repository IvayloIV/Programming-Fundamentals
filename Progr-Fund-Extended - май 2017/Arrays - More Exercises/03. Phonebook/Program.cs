using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            var names = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            while (true)
            {
                var input = Console.ReadLine();
                if (input == "done")
                {
                    break;
                }
                for (int i = 0; i < names.Length; i++)
                {
                    if (names[i] == input)
                    {
                        Console.WriteLine($"{input} -> {numbers[i]}");
                        break;
                    }
                }
            }
        }
    }
}
