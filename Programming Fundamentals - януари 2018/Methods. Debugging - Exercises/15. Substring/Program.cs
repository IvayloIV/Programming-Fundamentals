﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Substring
{
    class Program
    {
        public static void Main()
        {
            string text = Console.ReadLine();
            int jump = int.Parse(Console.ReadLine());

            char search = 'p';
            bool hasMatch = false;

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == search)
                {
                    hasMatch = true;

                    int endIndex = jump + 1;

                    if (endIndex + i > text.Length - 1)
                    {
                        endIndex = text.Length - i;
                    }

                    string matchedString = text.Substring(i, endIndex);
                    Console.WriteLine(matchedString);
                    i += jump;
                }
            }

            if (!hasMatch)
            {
                Console.WriteLine("no");
            }
        }
    }
}
