using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Char_Rotation
{
    class Program
    {
        static void Main(string[] args)
        {
            var chars = Console.ReadLine().ToCharArray();
            var ints = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            var result = "";
            for (int i = 0; i < ints.Length; i++)
            {
                if (ints[i] % 2 == 0)
                {
                    result += (char)(chars[i] - ints[i]);
                }
                else
                {
                    result += (char)(ints[i] + chars[i]);
                }
            }
            Console.WriteLine(result);
        }
    }
}
