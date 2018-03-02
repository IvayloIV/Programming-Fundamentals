using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Most_Frequent_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var allLines = File.ReadAllLines("input.txt");
            var output = new List<int>();
            foreach (var line in allLines)
            {
                var numbers = line.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                var mostRepeatedNum = 0;
                var maxCount = 0;
                for (int i = 0; i < numbers.Length - 1; i++)
                {
                    var currentCount = 1;
                    var currentNum = numbers[i];
                    for (int q = i + 1;q < numbers.Length; q++)
                    {
                        if (currentNum == numbers[q])
                        {
                            currentCount++;
                        }
                    }
                    if (currentCount > maxCount)
                    {
                        maxCount = currentCount;
                        mostRepeatedNum = currentNum;
                    }
                }
                output.Add(mostRepeatedNum);
            }
            File.WriteAllText("output.txt", string.Join("\n", output));
        }
    }
}
