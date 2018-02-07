using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Split_by_Word_Casing
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine()
                .Split(new string[] { ",", ";", ":", ".", "!", "(", ")", "\"", "\'", "\\", "/", "[", "]", " " }, 
                StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            var upperArr = new List<string>();
            var lowerArr = new List<string>();
            var mixed = new List<string>();

            for (int i = 0; i < arr.Length; i++)
            {
                var element = arr[i];
                var isMixed = false;
                for (int q = 0; q < arr[i].Length; q++)
                {
                    if ((element[q] < 65 || element[q] > 90))
                    {
                        if ((element[q] < 97 || element[q] > 122))
                        {
                            isMixed = true;
                            break;
                        }
                    }
                }
                if (isMixed)
                {
                    mixed.Add(element);
                    continue;
                }
                if (arr[i] == arr[i].ToUpper())
                {
                    upperArr.Add(arr[i]);
                }
                else if (arr[i] == arr[i].ToLower())
                {
                    lowerArr.Add(arr[i]);
                }
                else
                {
                    mixed.Add(arr[i]);
                }
            }
            Console.WriteLine($"Lower-case: {string.Join(", ", lowerArr)}");
            Console.WriteLine($"Mixed-case: {string.Join(", ", mixed)}");
            Console.WriteLine($"Upper-case: {string.Join(", ", upperArr)}");
        }
    }
}
