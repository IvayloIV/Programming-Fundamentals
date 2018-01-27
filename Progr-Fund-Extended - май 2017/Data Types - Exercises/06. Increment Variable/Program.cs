using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Increment_Variable
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            if (n <= 255) {
                Console.WriteLine(n);
                return;
            }
            var overflow = 0;
            while (n > 255) {
                n -= 256;
                overflow++;
            }
            Console.WriteLine(n);
            Console.WriteLine($"Overflowed {overflow} times");
        }
    }
}
