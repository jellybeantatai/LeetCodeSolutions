using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3
{
    public class Solution1
    {
        public int LengthOfLongestSubstring(string s)
        {
            //char[] charArray = s.ToCharArray();
            //List<char> subsequentUniqueChars = new List<char>();
            //int maxLengthOfList = 0;

            //for(int i = 0; i < charArray.Length; i++)
            //{
            //    subsequentUniqueChars.Add(charArray[i]);

            //    for(int j=i+1; j < charArray.Length; j++)
            //    {
            //        if (charArray[j] != charArray[i])
            //        {
            //            subsequentUniqueChars.Add(charArray[j]);
            //        }
            //    }
            //}

            if (s.Length <= 1)
                return s.Length;

            var memo = new Dictionary<char, int>();
            var counter = 0;

            for (int i = 0, j = 0; j < s.Length; j++)
            {
                var c = s[j];

                if (memo.ContainsKey(c))
                {
                    i = Math.Max(i, memo[c] + 1);
                    memo[c] = j;
                }
                else
                    memo.Add(c, j);

                counter = Math.Max(counter, j + 1 - i);
            }

            return counter;
        }
    }
}
