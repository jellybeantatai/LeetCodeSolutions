using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem5
{
    class Solution1
    {
        public string LongestPalindrome(string s)
        {
            int palindromeLength = 0;
            List<char> palindromeList = new List<char>();
            string finalPalindrome = "";
            bool allCharsAreSame = false;

            if (s.Length == 1 || s.Length == 0)
            {
                return s;
            }

            //else if (s.Length == 2)
            //{
            //    if (s[0] == s[1])
            //        return s;
            //}
            //else if(s.Length == 3 && s[0]==s[1] && s[0] == s[2])
            //{
            //    return s;
            //}

            for (int j=0; j < s.Length-1; j++)
            {
                if (s[j] == s[j + 1])
                    allCharsAreSame = true;
                else
                {
                    allCharsAreSame = false;
                    break;
                }
            }

            if(allCharsAreSame == true)
            {
                return s;
            }

            for (int i = 0; i < s.Length - 1; i++)
            {
                if (i < s.Length - 2 && s[i] == s[i + 1] && s[i] == s[i+2])
                {
                    palindromeList.Add(s[i]);
                    palindromeList.Add(s[i + 1]);
                    palindromeList.Add(s[i + 2]);
                    palindromeList = CheckPalindromeOnBorders(s, i, i + 2, palindromeList);
                }
                else if (s[i] == s[i + 1])
                {
                    palindromeList.Add(s[i]);
                    palindromeList.Add(s[i + 1]);
                    palindromeList = CheckPalindromeOnBorders(s, i, i + 1, palindromeList);
                }
                else if (i < s.Length - 2 && s[i] == s[i + 2])
                {
                    palindromeList.Add(s[i]);
                    palindromeList.Add(s[i + 1]);
                    palindromeList.Add(s[i + 2]);
                    palindromeList = CheckPalindromeOnBorders(s, i, i + 2, palindromeList);
                }

                if(palindromeLength < palindromeList.Count)
                {
                    palindromeLength = palindromeList.Count;
                    finalPalindrome = new String(palindromeList.ToArray());
                }
                palindromeList.Clear();
            }
            if (finalPalindrome == "")
                finalPalindrome = s[0].ToString();
            return finalPalindrome;
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
