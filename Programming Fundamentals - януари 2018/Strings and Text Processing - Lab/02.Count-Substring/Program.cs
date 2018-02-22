using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Count_Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine().ToLower();
            var findText = Console.ReadLine().ToLower();
            var count = 0;
            var index = text.IndexOf(findText);
            while (index != -1)
            {
                index = text.IndexOf(findText, index + 1);
                count++;
            }
            Console.WriteLine(count);
        }
    }
}
