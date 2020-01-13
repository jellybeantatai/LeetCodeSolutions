using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem5
{
    public class Program
    {
        static void Main(string[] args)
        {
            string s = "aabbaa";
            Solution2 sol = new Solution2();
            string result = sol.LongestPalindrome(s);
            Console.WriteLine(result);
        }
    }
}
