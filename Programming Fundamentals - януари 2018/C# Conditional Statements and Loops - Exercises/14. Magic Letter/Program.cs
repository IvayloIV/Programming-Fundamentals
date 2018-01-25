using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Magic_Letter
{
    class Program
    {
        static void Main(string[] args)
        {
            var startChar = char.Parse(Console.ReadLine());
            var endChar = char.Parse(Console.ReadLine());
            var bannedChar = char.Parse(Console.ReadLine());

            var book = new List<string>();
            for (char i = startChar; i <= endChar; i++)
            {
                for (char k = startChar; k <= endChar; k++)
                {
                    for (char h = startChar; h <= endChar; h++)
                    {
                        var current = $"{i}{k}{h}";
                        if (!current.Contains(bannedChar))
                        {
                            book.Add(current);
                        }
                    }
                }
            }
            Console.WriteLine(string.Join(" ", book));
        }
    }
}
