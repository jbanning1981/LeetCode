using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Submissions.Easy
{
    /*
        Write a function to find the longest common prefix string amongst an array of strings.

        If there is no common prefix, return an empty string "".

        Example 1:

            Input: strs = ["flower","flow","flight"]
            Output: "fl"

        Example 2:

            Input: strs = ["dog","racecar","car"]
            Output: ""
            Explanation: There is no common prefix among the input strings.

        Constraints:

            1 <= strs.length <= 200
            0 <= strs[i].length <= 200
            strs[i] consists of only lowercase English letters.
    */
    public class PrefixService
    {
        private const int MaxLength = 200;
        public string LongestCommonPrefix(string[] textToCheck)
        {
            if(textToCheck.Length == 1) 
            { 
                return textToCheck[0];
            }


            var minLength = GetMinLength(textToCheck);

            if(minLength == 0)
            {
                return "";
            }
            var prefixBuilder = new StringBuilder();
            string longestPrefix = string.Empty;
            bool isMatch = true;
            for (int counter = 0; counter < minLength; counter++)
            {
                var compareLetter = textToCheck[0][counter];

                foreach(var text in textToCheck)
                {
                    isMatch &= compareLetter == text[counter];
                }

                if(isMatch)
                {
                    prefixBuilder.Append(compareLetter);
                }
                else
                {
                    break;
                }
            }

            if(prefixBuilder.Length > longestPrefix.Length) 
            { 
                longestPrefix = prefixBuilder.ToString();
            }

            return longestPrefix;
        }

        private int GetMinLength(string[] textToCheck) 
        { 
            int maxLength = MaxLength;

            foreach(string s in textToCheck) 
            { 
                maxLength = Math.Min(maxLength, s.Length);
            }

            return maxLength;
        }

    }
}
