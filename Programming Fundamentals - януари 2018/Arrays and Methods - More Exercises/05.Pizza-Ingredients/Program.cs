using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Pizza_Ingredients
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            var neededLenght = int.Parse(Console.ReadLine());
            var newArr = new string[10];

            var count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Length == neededLenght)
                {
                    newArr[count] = arr[i];
                    Console.WriteLine($"Adding {arr[i]}.");
                    count++;
                    if (count == 10)
                    {
                        break;
                    }
                }
            }
            Console.WriteLine($"Made pizza with total of {count} ingredients.");
            Console.WriteLine($"The ingredients are: {string.Join(", ", newArr.Where(a => a != null).ToArray())}.");
        }
    }
}
