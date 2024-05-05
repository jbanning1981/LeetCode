

namespace LeetCode.Submissions.Easy
{
/*
Given two strings needle and haystack, return the index of the first occurrence of needle in haystack, or -1 if needle is not part of haystack.

 

Example 1:

Input: haystack = "sadbutsad", needle = "sad"
Output: 0
Explanation: "sad" occurs at index 0 and 6.
The first occurrence is at index 0, so we return 0.

Example 2:

Input: haystack = "leetcode", needle = "leeto"
Output: -1
Explanation: "leeto" did not occur in "leetcode", so we return -1.

 

Constraints:

    1 <= haystack.length, needle.length <= 104
    haystack and needle consist of only lowercase English characters.



*/

    public class FirstOccuranceService
    {
        public int StrStr(string haystack, string needle) {
            
            if(needle.Length == 0)
            {
                return 0;
            }
                
            if(haystack.Length == 0 || haystack.Length < needle.Length)
            {
                return -1;
            }
                

            for(int hayCounter = 0; hayCounter < haystack.Length; hayCounter++)
            {
                if(haystack[hayCounter] == needle[0])
                {
                    if(haystack.Length - hayCounter < needle.Length)
                    {
                        return -1;
                    }
                        
                    bool isPossibleMatch = true;
                    for(int needleCounter = 1; needleCounter < needle.Length; needleCounter++)
                    {
                        if(haystack[hayCounter+needleCounter] != needle[needleCounter])
                        {
                            isPossibleMatch = false;
                            break;
                        }
                    }


                    if(isPossibleMatch) {
                        return hayCounter;
                    }
                }
            }
            
            return -1;

        }
    }
}