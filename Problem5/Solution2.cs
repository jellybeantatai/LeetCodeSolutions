using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem5
{
    class Solution2
    {
        public string LongestPalindrome(string s)
        {
            string longestPalindrome = "";
            List<char> palindromeList = new List<char>();

            if (s.Length == 1 || s.Length == 0)
            {
                return s;
            }

            for (int i = 0; i < s.Length; i++)
            {
                int repeatedUntilIndex = ConsecuetiveRepeatedCharacters(s,i,palindromeList);
                palindromeList = CheckPalindromeOnBorders(s, i, repeatedUntilIndex, palindromeList);
                if (longestPalindrome.Length < palindromeList.Count())
                    longestPalindrome = new String(palindromeList.ToArray());
                palindromeList.Clear();
            }

            return longestPalindrome;
        }

        public int ConsecuetiveRepeatedCharacters(string s, int i, List<char> palindromeList)
        {
            if (!palindromeList.Any())
            {
                palindromeList.Add(s[i]);
            }
            if (i<s.Length-1 && s[i] == s[i + 1])
            {
                palindromeList.Add(s[i + 1]);
                return ConsecuetiveRepeatedCharacters(s,i+1,palindromeList);
            }
            else
            {
                return i;
            }
        }

        public List<char> CheckPalindromeOnBorders(string s, int firstIndex, int lastIndex, List<char> palindromeList)
        {

            if (firstIndex > 0 && lastIndex < s.Length - 1 && s[firstIndex - 1] == s[lastIndex + 1])
            {
                palindromeList.Insert(0, s[firstIndex - 1]);
                palindromeList.Add(s[lastIndex + 1]);
                return CheckPalindromeOnBorders(s, firstIndex - 1, lastIndex + 1, palindromeList);
            }
            else
            {
                return palindromeList;
            }
        }
    }
}
