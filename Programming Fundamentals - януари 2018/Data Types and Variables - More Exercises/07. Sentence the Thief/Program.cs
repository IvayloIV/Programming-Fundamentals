using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Sentence_the_Thief
{
    class Program
    {
        static void Main(string[] args)
        {
            var type = Console.ReadLine();
            var n = int.Parse(Console.ReadLine());

            long currentMin = 0;
            long currentMax = 0;

            if (type == "sbyte")
            {
                currentMin = sbyte.MinValue;
                currentMax = sbyte.MaxValue;
            }
            else if (type == "int")
            {
                currentMin = int.MinValue;
                currentMax = int.MaxValue;
            }
            else if (type == "long")
            {
                currentMin = long.MinValue;
                currentMax = long.MaxValue;
            }

            for (int i = 0; i < n; i++)
            {
                var currentNum = long.Parse(Console.ReadLine());
                if (currentNum <= currentMax && currentNum > currentMin)
                {
                    currentMin = currentNum;
                }
            }
            var sentence = 0d;
            if (currentMin > sbyte.MaxValue)
            {
                sentence = Math.Ceiling(Math.Abs(currentMin / 127D));
            }
            else
            {
                sentence = Math.Ceiling(Math.Abs(currentMin / -128D));
            }
            
            Console.Write($"Prisoner with id {currentMin} is sentenced to {sentence} year");
            if (sentence > 1)
            {
                Console.WriteLine("s");
            }
            else {
                Console.WriteLine();
            }
        }
    }
}
