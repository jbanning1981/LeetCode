using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Submissions.Medium
{
    public static class ReverseInteger
    {
        public static int ReverseViaString(int x)
        {
            if(x == 0)
            {
                return 0;
            }

            var numberStringArray = x.ToString().Where(c => char.IsDigit(c)).Select(c => c).ToArray();

            StringBuilder sb = new StringBuilder();

            for(int counter = numberStringArray.Length -1; counter >= 0; counter--)
            {
                if(numberStringArray[counter] == '0' && counter == numberStringArray.Length - 1)
                {
                    continue;
                }

                sb.Append(numberStringArray[counter]);
            }

            int result = 0;
            string reversedString = sb.ToString();
            if(!int.TryParse(reversedString, out result))
            {
                return 0;
            }

            return x > 0 ? result : result * -1;

        }
    }
}
