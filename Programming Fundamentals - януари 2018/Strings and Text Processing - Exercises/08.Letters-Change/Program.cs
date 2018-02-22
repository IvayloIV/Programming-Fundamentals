using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Letters_Change
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine().Split(new string[] { " ", "\t", "\n" }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            var sum = 0d;
            foreach (var word in words)
            {
                var leftLetter = char.Parse(word.Substring(0, 1));
                var nums = double.Parse(word.Substring(1, word.Length - 2));
                var rightLetter = char.Parse(word.Substring(word.Length - 1, 1));
                if (leftLetter >= 65 && leftLetter <= 90)
                {
                    nums /= (leftLetter - 64);
                }
                else
                {
                    nums *= (leftLetter - 96);
                }
                if (rightLetter >= 65 && rightLetter <= 90)
                {
                    nums -= (rightLetter - 64);
                }
                else
                {
                    nums += (rightLetter - 96);
                }
                sum += nums;
            }
            Console.WriteLine($"{sum:f2}");
        }
    }
}
