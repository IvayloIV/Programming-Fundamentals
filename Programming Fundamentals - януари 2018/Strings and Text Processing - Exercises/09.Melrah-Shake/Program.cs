using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Melrah_Shake
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();
            var key = Console.ReadLine();
            var totalText = "";
            while (true)
            {
                totalText = text;
                var firstIndex = text.IndexOf(key);
                var secondIndex = text.LastIndexOf(key);
                if (firstIndex == secondIndex || firstIndex == -1 || secondIndex == -1 || key.Length == 0)
                {
                    break;
                }
                text = RemoveIndexFromText(firstIndex, text, key);
                secondIndex = text.LastIndexOf(key);
                if (secondIndex == -1) break;
                text = RemoveIndexFromText(secondIndex, text, key);
                var momentKey = key.ToCharArray().ToList();
                momentKey.RemoveAt(momentKey.Count() / 2);
                key = string.Join("", momentKey);
                Console.WriteLine("Shaked it.");
            }
            Console.WriteLine("No shake.");
            Console.WriteLine(totalText);
        }

        private static string RemoveIndexFromText(int firstIndex, string text, string key)
        {
            var leftPart = text.Take(firstIndex).ToList();
            var rightPart = text.Skip(firstIndex + key.Length).ToList();
            return new string(leftPart.Concat(rightPart).ToArray());
        }
    }
}
