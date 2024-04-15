using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Submissions.Easy
{
    public class RemoveSortedDuplicateService
    {
        public int RemoveDuplicates(int[] nums)
        {
            if ((nums?.Length ?? 0) <= 1)
            {
                return nums?.Length ?? 0;
            }
            int uniqueCounter = 0;
            int insertIndex = 0;
            bool isDuplicate = false;

            Debugger.Log(-1, "", Environment.NewLine);
            Debugger.Log(-1, "", string.Join(",", nums.Select(x => x.ToString())));
            Debugger.Log(-1, "", Environment.NewLine);
            for (int counter = 1; counter < nums.Length; counter++)
            {
                if (nums[counter-1] == nums[counter])
                {
                    if (!isDuplicate)
                    {
                        isDuplicate = true;
                        insertIndex = uniqueCounter + 1;
                    }
                    Debugger.Log(-1, "", $"{(counter + 1)} - {string.Join(",", nums.Select(x => x.ToString()))} {Environment.NewLine}");
                }
                else
                {
                    uniqueCounter++;
                    if (isDuplicate)
                    {
                        nums[insertIndex] = nums[counter];
                        counter = insertIndex;
                        isDuplicate = false;
                    }

                    if (counter == nums.Length - 2)
                    {
                        if (nums[counter - 1] == nums[counter] && nums[counter] != nums[counter + 1])
                        {
                            nums[counter] = nums[counter + 1];
                            uniqueCounter++;
                        }
                    }
                }

                if (counter == nums.Length - 1)
                { 
                    uniqueCounter++;
                }
                Debugger.Log(-1, "", $"{(counter + 1)} - {string.Join(",", nums.Select(x => x.ToString()))} {Environment.NewLine}");
            }
            Debugger.Log(-1, "", string.Join(",", nums.Select(x => x.ToString())));
            return uniqueCounter;
        }


        public int RemoveDuplicatesV1(int[] nums)
        {
            if ((nums?.Length ?? 0) <= 1)
            {
                return nums?.Length ?? 0;
            }
            int uniqueCounter = 0;
            int insertIndex = 0;
            bool isDuplicate = false;

            Debugger.Log(-1, "", Environment.NewLine);
            Debugger.Log(-1, "", string.Join(",", nums.Select(x => x.ToString())));
            Debugger.Log(-1, "", Environment.NewLine);
            for (int counter = 0; counter < nums.Length - 1; counter++)
            {
                if(counter == 2)
                {
                    Debugger.Break();
                }


                if (nums[counter] == nums[counter + 1])
                {
                    if(!isDuplicate)
                    {
                        isDuplicate = true;
                        insertIndex = uniqueCounter + 1;
                    }
                    Debugger.Log(-1, "", $"{(counter + 1)} - {string.Join(",", nums.Select(x => x.ToString()))} {Environment.NewLine}");
                }
                else 
                {
                    uniqueCounter++;
                    if (isDuplicate)
                    {
                        nums[insertIndex] = nums[counter + 1];
                        isDuplicate = false;
                    }
                }



                if (counter == nums.Length -2)
                {
                    uniqueCounter++;
                }
                Debugger.Log(-1, "", $"{(counter+1)} - {string.Join(",", nums.Select(x => x.ToString()))} {Environment.NewLine}");
            }
            Debugger.Log(-1, "", string.Join(",", nums.Select(x => x.ToString())));
            return uniqueCounter;
        }
}
}
