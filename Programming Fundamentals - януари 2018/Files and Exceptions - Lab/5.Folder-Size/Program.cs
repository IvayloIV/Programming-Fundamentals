using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Folder_Size
{
    class Program
    {
        static void Main(string[] args)
        {
            var allFiles = Directory.GetFiles("TestFolder").Select(a => new FileInfo(a)).ToList();
            var allMemory = 0d;
            foreach (var file in allFiles)
            {
                allMemory += file.Length;
            }
            allMemory = allMemory / 1024d / 1024d;
            File.WriteAllText("Output.txt", allMemory.ToString());
        }
    }
}
