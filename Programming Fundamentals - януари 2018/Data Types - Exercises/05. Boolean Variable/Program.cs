﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Boolean_Variable
{
    class Program
    {
        static void Main(string[] args)
        {
            var isTrue = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine(isTrue == true ? "Yes" : "No");
        }
    }
}
