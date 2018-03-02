using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Merge_Files
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr1 = File.ReadAllLines("FileOne.txt");
            var arr2 = File.ReadAllLines("FileTwo.txt");
            var outputArr = new List<string>();
            for (int i = 0; i < Math.Max(arr1.Length, arr2.Length); i++)
            {
                if (i <= arr1.Length - 1)
                {
                    outputArr.Add(arr1[i]);
                }
                if (i <= arr2.Length - 1)
                {
                    outputArr.Add(arr2[i]);
                }
            }
            File.WriteAllLines("Output.txt", outputArr);
        }
    }
}
