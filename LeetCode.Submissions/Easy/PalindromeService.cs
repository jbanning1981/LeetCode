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




            int minPower = 1;
            int numberLength = (int)(Math.Floor(Math.Log10(numberToCheck))+1);

            if(numberLength == 2)
            {
                var xx = numberToCheck / 10;
                var y = numberToCheck - 10;
                return xx == y;
            }


            while(minPower < numberLength)
            {
                var minCompareDigit = GetCompareDigit(numberToCheck, minPower);
                var maxCompareDigit = GetCompareDigit(numberToCheck,numberLength);
                if (minCompareDigit != maxCompareDigit)
                {
                    return false;
                }

                minPower++;
                numberLength--;
            }

            return true;
        }

        private static double GetCompareDigit(int numberToCheck, int iterations)
        {
            var numberToParse = (double)numberToCheck;
            for (int counter = 0; counter < iterations; counter++) 
            {
                var remainder = numberToParse % Math.Pow(10, iterations);

                if(remainder < 10)
                {
                    return remainder;
                }
                numberToParse = remainder;
            }

            throw new Exception("failed");
        }

        //private static double
    }
}
