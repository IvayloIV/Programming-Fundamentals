using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.String_Commander
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();
            while (true)
            {
                var input = Console.ReadLine();
                if (input == "end") break;
                var inputTokens = input.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                if (inputTokens[0] == "Left")
                {
                    text = RotateLeft(text, int.Parse(inputTokens[1]));
                }
                else if (inputTokens[0] == "Right")
                {
                    text = RotateRight(text, int.Parse(inputTokens[1]));
                }
                else if (inputTokens[0] == "Insert")
                {
                    text = text.Insert(int.Parse(inputTokens[1]), inputTokens[2]);
                }
                else if (inputTokens[0] == "Delete")
                {
                    text = DeleteText(text, int.Parse(inputTokens[1]), int.Parse(inputTokens[2]));
                }
            }
            Console.WriteLine(text);
        }

        private static string DeleteText(string text, int startIndex, int endIndex)
        {
            var result = String.Empty;
            for (int i = 0; i < text.Length; i++)
            {
                if (i < startIndex || i > endIndex)
                {
                    result += text[i];
                }
            }
            return result;
        }

        private static string RotateRight(string text, int v)
        {
            for (int i = 0; i < v % text.Length; i++)
            {
                var lastElement = text[text.Length - 1];
                text = text.Remove(text.Length - 1, 1);
                text = lastElement + text;
            }
            return text;
        }

        private static string RotateLeft(string text, int v)
        {
            for (int i = 0; i < v % text.Length; i++)
            {
                var firstElement = text[0];
                text = text.Remove(0, 1);
                text += firstElement;
            }
            return text;
        }
    }
}
