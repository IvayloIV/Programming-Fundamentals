using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Capitalize_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                var input = Console.ReadLine();
                if (input == "end") break;
                var inputTokens = input.Split(new char[] { ' ', '.', ',', ':', ';', '?', '!', '-', '_' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                var arr = new List<string>();
                foreach (var item in inputTokens)
                {
                    var firstLetter = item[0].ToString().ToUpper();
                    var rightElement = new string(item.Skip(1).ToArray()).ToLower();
                    arr.Add(firstLetter + rightElement);
                }
                Console.WriteLine(string.Join(", ", arr));
            }
        }
    }
}
