using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Randomize_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine().Split(' ').ToArray();
            var random = new Random();
            for (int i = 0; i < words.Length; i++)
            {
                var currentWord = words[i];
                var randomIndex = random.Next(0, words.Length);
                var randomWord = words[randomIndex];
                words[i] = randomWord;
                words[randomIndex] = currentWord;
            }
            Console.WriteLine(string.Join(Environment.NewLine, words));
        }
    }
}
