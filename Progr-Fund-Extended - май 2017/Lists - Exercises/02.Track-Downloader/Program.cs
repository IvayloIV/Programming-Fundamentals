using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Track_Downloader
{
    class Program
    {
        static void Main(string[] args)
        {
            var bannedWords = Console.ReadLine().Split().ToList();
            var goodSentance = new List<string>();
            while (true)
            {
                var input = Console.ReadLine();
                if (input == "end")
                {
                    break;
                }
                if (bannedWords.Any(a => input.IndexOf(a) != -1))
                {
                    continue;
                }
                goodSentance.Add(input);
            }
            foreach (var item in goodSentance.OrderBy(a => a))
            {
                Console.WriteLine(item);
            }
        }
    }
}
