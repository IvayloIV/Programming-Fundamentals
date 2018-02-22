using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Take_Skip_Rope
{
    class Program
    {
        static void Main(string[] args)
        {
            var str = Console.ReadLine();
            var nums = new List<int>();
            var letter = "";
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] >= 48 && str[i] <= 57)
                {
                    nums.Add(int.Parse(str[i].ToString()));
                }
                else
                {
                    letter += str[i];
                }
            }
            var skipped = 0;
            var result = "";
            for (int i = 0; i < nums.Count(); i++)
            {
                if (i % 2 == 0)
                {
                    result += new string(letter.Skip(skipped).Take(nums[i]).ToArray());
                }
                skipped += nums[i];
                if (skipped > letter.Length - 1) break;
            }
            Console.WriteLine(result);
        }
    }
}
