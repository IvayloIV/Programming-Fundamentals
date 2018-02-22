using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.JSON_Parse
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Trim('[', ']').Trim('}').Split(new string[] { "},{" }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            foreach (var item in input)
            {
                var tokensInput = item.Split(new string[] { ":", "," }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                var name = tokensInput[1].Trim('\"');
                var age = tokensInput[3];
                var gradesTokens = item.Split(new string[] { "grades:[", ", ", "]" }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                var grades = new List<string>();
                for (int i = 1; i < gradesTokens.Length; i++)
                {
                    grades.Add(gradesTokens[i]);
                }
                Console.Write($"{name} : {age} -> ");
                if (grades.Count() == 0)
                {
                    Console.WriteLine($"None");
                }
                else
                {
                    Console.WriteLine(string.Join(", ", grades));
                }
            }
        }
    }
}
