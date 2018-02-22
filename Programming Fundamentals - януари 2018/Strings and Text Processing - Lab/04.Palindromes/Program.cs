using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Palindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new List<string>();
            var words = Console.ReadLine().Split(new string[] { " ", ",", ".", "?", "!" }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            foreach (var word in words)
            {
                var isPolidrom = true;
                for (int i = 0; i < word.Length / 2; i++)
                {
                    if (word[i] != word[word.Length - 1 - i])
                    {
                        isPolidrom = false;
                        break;
                    }
                }
                if (isPolidrom) builder.Add(word);
            }
            if (builder.Count() == 0)
            {
                return;
            }
            Console.WriteLine(string.Join(", ", builder.Distinct().OrderBy(a => a)));
        }
    }
}
