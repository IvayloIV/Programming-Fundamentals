using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Pyramidic
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var listElements = new List<string>();
            var resultArr = new List<string>();
            for (int i = 0; i < n; i++)
            {
                listElements.Add(Console.ReadLine());
            }
            for (int i = 0; i < listElements.Count(); i++)
            {
                var currentRow = listElements[i];
                for (int q = 0; q < currentRow.Length; q++)
                {
                    var currentChar = currentRow[q];
                    var text = currentChar + "\n";
                    var lengthSeartch = 3;
                    for (int t = i + 1; t < listElements.Count(); t++)
                    {
                        var currentFindingText = new string(currentChar, lengthSeartch);
                        if (listElements[t].Contains(currentFindingText))
                        {
                            text += currentFindingText + "\n";
                        }
                        else
                        {
                            break;
                        }
                        lengthSeartch += 2;
                    }
                    resultArr.Add(text);
                }
            }
            Console.Write(resultArr.OrderByDescending(a => a.Length).First());
        }
    }
}
