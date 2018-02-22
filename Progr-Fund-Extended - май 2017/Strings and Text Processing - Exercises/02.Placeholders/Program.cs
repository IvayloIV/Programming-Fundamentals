using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Placeholders
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                var input = Console.ReadLine();
                if (input == "end")
                {
                    break;
                }
                var inputTokens = input.Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                var text = inputTokens[0];
                var placeholders = inputTokens[1].Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                for (int i = 0; i < placeholders.Length; i++)
                {
                    text = text.Replace("{" + $"{i}" + "}", placeholders[i]);
                }
                Console.WriteLine(text);
            }
        }
    }
}
