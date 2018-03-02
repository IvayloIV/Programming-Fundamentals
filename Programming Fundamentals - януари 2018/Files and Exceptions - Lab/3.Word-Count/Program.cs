using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Word_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            var allWords = File.ReadAllText("words.txt").Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(a => a.Trim()).ToList();
            var text = File.ReadAllText("Input.txt").ToLower();
            var book = new Dictionary<string, int>();
            foreach (var word in allWords)
            {
                var nextIndex = 0;
                var count = 0;
                while (true)
                {
                    var currentIndex = text.IndexOf(word, nextIndex);
                    if (currentIndex == -1) break;
                    nextIndex = currentIndex + 1;
                    if (currentIndex > 0)
                    {
                        if (char.IsLetter(text[currentIndex - 1]))
                        {
                            continue;
                        }
                    }
                    if (currentIndex + word.Length <= text.Length - 1)
                    {
                        if (char.IsLetter(text[currentIndex + word.Length]))
                        {
                            continue;
                        }
                    }
                    count++;
                }
                book[word] = count;
            }
            var totalText = "";
            foreach (var item in book.OrderByDescending(a => a.Value))
            {
                totalText += $"{item.Key}-{item.Value}\n";
            }
            File.WriteAllText("Output.txt", totalText);
        }
    }
}
