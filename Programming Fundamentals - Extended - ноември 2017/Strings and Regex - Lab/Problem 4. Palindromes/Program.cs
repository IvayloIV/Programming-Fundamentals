using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4.Palindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new char[] { ' ', ',', '.', '?', '!' }).ToArray();
            var polidroms = new List<string>();
            foreach (var item in input)
            {
                var isPolidrom = true;
                for (int i = 0; i < item.Length / 2; i++)
                {
                    if (item[i] != item[item.Length - i - 1])
                    {
                        isPolidrom = false;
                    }
                }
                if (isPolidrom == true)
                {
                    polidroms.Add(item);
                }
            }
            var output = polidroms.OrderBy(a => a).Where(x => x != "").Distinct();
            Console.WriteLine(string.Join(", ", output));
        }
    }
}
