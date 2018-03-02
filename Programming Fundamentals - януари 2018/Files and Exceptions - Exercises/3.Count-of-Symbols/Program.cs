using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Count_of_Symbols
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = File.ReadAllText("input.txt");
            var book = new Dictionary<char, int>();
            for (int i = 0; i < text.Length; i++)
            {
                if (!book.ContainsKey(text[i]))
                {
                    book[text[i]] = 0;
                }
                book[text[i]]++;
            }
            File.WriteAllLines("output.txt", book.OrderByDescending(a => a.Value).Where(a => a.Key != ' ').Select(a => $"{a.Key} -> {a.Value}"));
        }
    }
}
