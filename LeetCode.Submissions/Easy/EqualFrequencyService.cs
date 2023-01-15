using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Submissions.Easy
{
    public class EqualFrequencyService
    {
        public bool EqualFrequency(string word)
        {
            if (word.Length == 2)
            {
                return true;
            }

            var letterCount = new Dictionary<char, int>();
            foreach (char letter in word)
            {
                if (!letterCount.Any(kvp => kvp.Key == letter))
                {
                    letterCount.Add(letter, 1);
                    continue;
                }

                letterCount[letter]++;
            }

            var min = letterCount.Min(kvp => kvp.Value);
            var max = letterCount.Max(kvp => kvp.Value);
            var maxMatchCount = letterCount.Count(kvp => kvp.Value == max);
            var minMatchCount = letterCount.Count(kvp => kvp.Value == min);

            return letterCount.Count() == 1 ||
                    (letterCount.Count() == 2 && min == 1) ||
                    (min == 1 && max == 1) ||
                    (min == (max - 1) && maxMatchCount == 1) ||
                    (min == 1 && minMatchCount == 1 && letterCount.All(kvp => kvp.Value == 1 || kvp.Value == max));
        }
    }
}
