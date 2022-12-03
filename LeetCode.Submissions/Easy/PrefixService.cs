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

        /// <summary>
        /// Version One
        /// Runtime - 185 ms Beats 12.47%
        /// Memory - 38.6 MB Beats 59.52%
        /// </summary>
        /// <param name="textToCheck"></param>
        /// <returns>The longest prefix in the array of strings</returns>
        public string LongestCommonPrefixVersionOne(string[] textToCheck)
        {
            if (textToCheck.Length == 1)
            {
                return textToCheck[0];
            }


            var minLength = GetMinLength(textToCheck);

            if (minLength == 0)
            {
                return "";
            }
            var prefixBuilder = new StringBuilder();
            string longestPrefix = string.Empty;
            bool isMatch = true;
            for (int counter = 0; counter < minLength; counter++)
            {
                var compareLetter = textToCheck[0][counter];

                foreach (var text in textToCheck)
                {
                    isMatch &= compareLetter == text[counter];
                }

                if (isMatch)
                {
                    prefixBuilder.Append(compareLetter);
                }
                else
                {
                    break;
                }
            }

            if (prefixBuilder.Length > longestPrefix.Length)
            {
                longestPrefix = prefixBuilder.ToString();
            }

            return longestPrefix;
        }


        /// <summary>
        /// Version Two            
        /// Runtime - 100 ms Beats 94.13 %
        /// Memory - 40 MB Beats 19.16 %
        /// </summary>
        /// <param name="textToCheck"></param>
        /// <returns>The longest prefix in the array of strings</returns>
        public string LongestCommonPrefixVersionTwo(string[] textToCheck)
        {

            var arrayLength = textToCheck.Length;
            if (arrayLength == 1) 
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

                for(int arrayCounter = 1; arrayCounter < arrayLength; arrayCounter++)
                {
                    isMatch &= compareLetter == textToCheck[arrayCounter][counter];
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
                return prefixBuilder.ToString();
            }

            return longestPrefix;
        }

        /// <summary>
        /// Version Two            
        /// Runtime- 157 ms Beats 58.50 %
        /// Memory - 38.5 MB Beats 66.81 %
        /// </summary>
        /// <param name="textToCheck"></param>
        /// <returns>The longest prefix in the array of strings</returns>
        public string LongestCommonPrefixVersionThree(string[] textToCheck)
        {
            var arrayLength = textToCheck.Length;
            if (arrayLength == 1)
            {
                return textToCheck[0];
            }


            var minLength = GetMinLength(textToCheck);

            if (minLength == 0)
            {
                return "";
            }
            var prefixBuilder = new StringBuilder("");
            bool isMatch = true;
            for (int counter = 0; counter < minLength; counter++)
            {
                var compareLetter = textToCheck[0][counter];

                for (int arrayCounter = 1; arrayCounter < arrayLength; arrayCounter++)
                {
                    isMatch &= compareLetter == textToCheck[arrayCounter][counter];
                }

                if (isMatch)
                {
                    prefixBuilder.Append(compareLetter);
                }
                else
                {
                    break;
                }
            }

            return prefixBuilder.ToString();
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
