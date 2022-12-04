using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Submissions.Easy
{
    public class ParenthesisService
    {
        /// <summary>
        /// Runtime - 98 ms Beats 77.42%
        /// Memory - 37.2 MB Beats 29.25%
        /// </summary>
        /// <param name="textToValidate"></param>
        /// <returns></returns>
        public bool IsValid(string textToValidate)
        {
            if (string.IsNullOrWhiteSpace(textToValidate) || textToValidate.Length % 2 != 0) return false;

            var bracketMap = new HashSet<(char open, char close)>()
            {
                ('(', ')'),
                ('{', '}'),
                ('[', ']'),
            };


            int pairCounter = 0;
            char[] openBraces = new char[textToValidate.Length / 2];
            for (int counter = 0; counter < textToValidate.Length; counter++)
            {
                if (counter == 0 && bracketMap.Any(key => key.close == textToValidate[0]))
                {
                    return false;
                }

                char c = textToValidate[counter];
                if (bracketMap.Any(key => key.open == textToValidate[counter]))
                {
                    if (pairCounter >= textToValidate.Length / 2)
                    {
                        return false;
                    }

                    openBraces[pairCounter] = textToValidate[counter];
                    pairCounter++;
                    continue;
                }
                else
                {
                    if (pairCounter == 0) 
                    { 
                        return false; 
                    }


                    if (!bracketMap.Any(key => key.open == openBraces[(pairCounter - 1)] && key.close == textToValidate[counter]))
                    {
                        return false;
                    }
                    pairCounter--;
                }



            }


            return pairCounter == 0;
        }
    }
}
