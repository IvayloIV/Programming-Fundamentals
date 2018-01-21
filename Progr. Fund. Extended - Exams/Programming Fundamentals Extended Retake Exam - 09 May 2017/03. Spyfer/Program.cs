using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Spyfer
{
    class Program
    {
        static void Main(string[] args)
        {
            var arrInt = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            for (int i = 0; i < arrInt.Count(); i++)
            {
                if (i == 0 && arrInt.Count() > 1)
                {
                    if (arrInt[i] == arrInt[i + 1])
                    {
                        arrInt.RemoveAt(i + 1);
                        i = 0;
                    }
                }
                else if (i == arrInt.Count() - 1 && arrInt.Count() > 1)
                {
                    if (arrInt[i] == arrInt[i - 1])
                    {
                        arrInt.RemoveAt(i - 1);
                        i = 0;
                    }
                }
                else {
                    if (arrInt[i] == arrInt[i - 1] + arrInt[i + 1] && arrInt.Count() > 2) {
                        arrInt.RemoveAt(i + 1);
                        arrInt.RemoveAt(i - 1);
                        i = 0;
                    }
                }
            }
            Console.WriteLine(string.Join(" ", arrInt));
        }
    }
}
