using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondTask
{
    class Program
    {
        class DNK
        {
            public int NumberCount { get; set; }
            public string TotalBestString { get; set; }
            public int BestLength { get; set; }
            public int Sum { get; set; }
            public int StartIndex { get; set; }
            public DNK(int numberCount, string bestSequnce, int bestLength, int sum, int startIndex)
            {
                NumberCount = numberCount;
                TotalBestString = bestSequnce;
                BestLength = bestLength;
                Sum = sum;
                StartIndex = startIndex;
            }
        }
        static void Main(string[] args)
        {
            var lengthOfSequnce = int.Parse(Console.ReadLine());
            var book = new List<DNK>();
            var count = 1;
            while (true)
            {
                var input = Console.ReadLine();
                if (input == "Clone them!")
                {
                    break;
                }
                var totalBestStartIndex = 0;
                var totalBestSequnceLength = 0;
                var currentTokens = input.Split(new[] { '!' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                var currentSum = currentTokens.Sum();
                var currentStartIndex = 0;
                var bestSequnceLength = 0;
                var isStartNow = true;
                for (int i = 0; i < currentTokens.Length; i++)
                {
                    if (currentTokens[i] == 1)
                    {
                        bestSequnceLength++;
                        if (isStartNow)
                        {
                            currentStartIndex = i;
                            isStartNow = false;
                        }
                    }
                    else
                    {
                        bestSequnceLength = 0;
                        isStartNow = true;
                        currentStartIndex = -1;
                    }
                    if (totalBestSequnceLength < bestSequnceLength)
                    {
                        totalBestSequnceLength = bestSequnceLength;
                        totalBestStartIndex = currentStartIndex;
                    }
                }
                book.Add(new DNK(count, string.Join(" ", currentTokens), totalBestSequnceLength, currentSum, totalBestStartIndex));
                count++;
            }
            foreach (var item in book.OrderByDescending(a => a.BestLength).ThenBy(a => a.StartIndex).ThenByDescending(a => a.Sum))
            {
                Console.WriteLine($"Best DNA sample {item.NumberCount} with sum: {item.Sum}.");
                Console.WriteLine(item.TotalBestString);
                return;
            }
        }
    }
}
