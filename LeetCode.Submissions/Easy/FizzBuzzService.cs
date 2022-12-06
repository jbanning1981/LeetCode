using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Submissions.Easy
{
    public class FizzBuzzService
    {
        /// <summary>
        /// Runtime - 243 ms Beats 47.22% 
        /// Memory - 47.3 MB Beats 31.37%
        /// </summary>
        /// <param name="arraySize"></param>
        /// <returns></returns>
        public IList<string> FizzBuzzV1(int arraySize)
        {
            string[] output = new string[arraySize];

            StringBuilder answer = new();
            for(int counter = 1; counter <= arraySize; counter++)
            {
                if(counter % 3 == 0)
                {
                    answer.Append("Fizz");
                }
                
                if(counter % 5 == 0)
                {
                    answer.Append("Buzz");
                }

                if(answer.Length == 0)
                {
                    answer.Append($"{counter}");
                }

                output[counter - 1] = answer.ToString();
                answer.Clear();
            }

            return output;
        }

        /// <summary>
        /// Runtime - 262 ms Beats 17.43%
        /// Memory - 47.3 MB Beats 31.37%
        /// </summary>
        /// <param name="arraySize"></param>
        /// <returns></returns>
        public IList<string> FizzBuzzV2(int arraySize)
        {
            string[] output = new string[arraySize];

            for (int counter = 1; counter <= arraySize; counter++)
            {
                if (counter % 3 == 0 && counter % 5 ==0)
                {
                    output[counter - 1] = "FizzBuzz";
                    continue;
                }

                if (counter % 5 == 0)
                {
                    output[counter - 1] = "Buzz";
                    continue;
                }

                if (counter % 3 == 0)
                {
                    output[counter - 1] = "Fizz";
                    continue;
                }

                output[counter - 1] = $"{counter}";
            }

            return output;
        }

        /// <summary>
        /// Runtime - 238 ms Beats 55.54%
        /// Memory - 47.1 MB Beats 45.54%
        /// </summary>
        /// <param name="arraySize"></param>
        /// <returns></returns>
        public IList<string> FizzBuzzV3(int arraySize)
        {
            string[] output = new string[arraySize];

            for (int counter = 1; counter <= arraySize; counter++)
            {
                if (counter % 3 != 0 && counter % 5 != 0)
                {
                    output[counter - 1] = $"{counter}";
                    continue;
                }

                if (counter % 3 == 0)
                {
                    output[counter - 1] = "Fizz";
                }

                if (counter % 5 == 0)
                {
                    output[counter - 1] += "Buzz";
                }
            }

            return output;
        }

        /// <summary>
        /// Runtime - 172 ms Beats 79.57%
        /// Memory - 53.8 MB Beats 17.50%
        /// </summary>
        /// <param name="arraySize"></param>
        /// <returns></returns>
        public IList<string> FizzBuzzV4(int arraySize)
        {
            string[] output = new string[arraySize];

            for (int counter = 1; counter <= arraySize; counter++)
            {
                if (counter == 1 || counter == 2 || (counter % 3 != 0 && counter % 5 != 0))
                {
                    output[counter - 1] = $"{counter}";
                    continue;
                }

                if (counter % 3 == 0 && counter % 5 != 0)
                {
                    output[counter - 1] = "Fizz";
                    continue;
                }

                if (counter % 3 != 0 && counter % 5 == 0)
                {
                    output[counter - 1] = "Buzz";
                    continue;
                }

                output[counter - 1] = "FizzBuzz";
            }

            return output;
        }


        /// <summary>
        /// Runtime - 242 ms Beats 49.4%
        /// Memory - 47.3 MB Beats 31.37%
        /// </summary>
        /// <param name="arraySize"></param>
        /// <returns></returns>
        public IList<string> FizzBuzzV5(int arraySize)
        {
            List<string> output = new();

            for (int counter = 1; counter <= arraySize; counter++)
            {

                switch(counter)
                {
                    case int num when num < 3 :
                        output.Add(counter.ToString());
                        break;
                    case int num when num % 3 != 0 && num % 5 != 0:
                        output.Add(counter.ToString());
                        break;
                    case int num when num % 3 == 0 && num % 5 != 0:
                        output.Add("Fizz");
                        break;
                    case int num when num % 3 != 0 && num % 5 == 0:
                        output.Add("Buzz");
                        break;
                    default:
                        output.Add("FizzBuzz");
                        break;
                }
            }

            return output;
        }

        /// <summary>
        /// Runtime - 243 ms Beats 47.22%
        /// Memory - 47.1 MB Beats 62.20%
        /// </summary>
        /// <param name="arraySize"></param>
        /// <returns></returns>
        public IList<string> FizzBuzzV6(int arraySize)
        {
            List<string> output = new();

            for (int counter = 1; counter <= arraySize; counter++)
            {

                switch (counter)
                {
                    case 1:
                        output.Add(counter.ToString());
                        break;
                    case 2:
                        output.Add(counter.ToString());
                        break;
                    default:
                        if (counter % 3 != 0 && counter % 5 != 0)
                        {
                            output.Add(counter.ToString());
                            break;
                        }

                        if (counter % 3 == 0 && counter % 5 != 0) 
                        {
                            output.Add("Fizz");
                            break;
                        }

                        if (counter % 3 != 0 && counter % 5 == 0)
                        {
                            output.Add("Buzz");
                            break;
                        }


                        output.Add("FizzBuzz");
                        break;
                }
            }

            return output;
        }


    }
}
