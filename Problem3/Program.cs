﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputString = "abba";
            int result;

            Solution1 sol = new Solution1();
            result = sol.LengthOfLongestSubstring(inputString);

            Console.WriteLine(result);
        }

    }
}
