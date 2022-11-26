using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Submissions.Easy
{
    public class PalindromeService
    {
        public static bool IsPalindromeStringBased(int x)
        {
            if (x >= 0 && x < 10)
            {
                return true;
            }


            var intString = x.ToString();
            int length = intString.Length;
            int counter = 0;
            int compareIndex = length - 1;

            while (counter < compareIndex)
            {

                if (intString[counter] != intString[compareIndex])
                {
                    return false;
                }

                counter++;
                compareIndex--;
            }

            return true;
        }

        public static bool IsPalindromeIntegerBased(int numberToCheck)
        {
            if(numberToCheck < 0)
            {
                return false;
            }

            if (numberToCheck >= 0 && numberToCheck < 10)
            {
                return true;
            }

            int reversedNum = 0;
            int numToReverse = numberToCheck;
            while (numToReverse != 0)
            {
                var numToAdd = numToReverse % 10;
                reversedNum = reversedNum*10 + numToAdd;
                numToReverse /= 10;
            }
            return reversedNum == numberToCheck;
        }
    }
}
