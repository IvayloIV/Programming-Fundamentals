using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4.Resurrection
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                decimal bodyLenght = decimal.Parse(Console.ReadLine());
                decimal bodyWight = decimal.Parse(Console.ReadLine());
                decimal lenght1 = decimal.Parse(Console.ReadLine());
                decimal sum = bodyLenght;

                sum *= bodyLenght;

                decimal sum2 = bodyWight + 2 * lenght1;
                Console.WriteLine(sum * sum2);
            }
        }
    }
}
