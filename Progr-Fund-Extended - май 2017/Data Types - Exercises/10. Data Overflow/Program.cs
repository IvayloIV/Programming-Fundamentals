using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Data_Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong num1 = ulong.Parse(Console.ReadLine());
            ulong num2 = ulong.Parse(Console.ReadLine());

            var maxNum = Math.Max(num1, num2);
            var minNum = Math.Min(num1, num2);

            var maxType = CurrentType(maxNum);
            var minType = CurrentType(minNum);
            ulong maxValue = 0;

            if (minType == "byte")
            {
                maxValue = byte.MaxValue;
            }
            else if (minType == "ushort")
            {
                maxValue = ushort.MaxValue;
            }
            else if (minType == "uint")
            {
                maxValue = uint.MaxValue;
            }
            else if (minType == "ulong")
            {
                maxValue = ulong.MaxValue;
            }
            Console.WriteLine($"bigger type: {maxType}");
            Console.WriteLine($"smaller type: {minType}");
            Console.WriteLine($"{maxNum} can overflow {minType} {Math.Round((decimal)maxNum / maxValue)} times");
        }

        private static string CurrentType(ulong n)
        {
            if (n >= byte.MinValue && n <= byte.MaxValue)
            {
                return "byte";
            }
            else if (n >= ushort.MinValue && n <= ushort.MaxValue)
            {
                return "ushort";
            }
            else if (n >= uint.MinValue && n <= uint.MaxValue)
            {
                return "uint";
            }
            else
            {
                return "ulong";
            }
        }
    }
}
