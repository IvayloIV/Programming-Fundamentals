using System;

namespace _07.From_Terabytes_to_Bits
{
    class Program
    {
        static void Main(string[] args)
        {
            var teraBytes = decimal.Parse(Console.ReadLine());
            decimal byteS = 8796093022208;
            Console.WriteLine($"{(teraBytes * byteS):f0}");
        }
    }
}
