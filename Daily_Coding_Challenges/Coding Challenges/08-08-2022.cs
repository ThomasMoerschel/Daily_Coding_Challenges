/*Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.

You may assume that each input would have exactly one solution, and you may not use the same element twice.

You can return the answer in any order.

EXAMPLE:
Input: nums = [2, 7, 11, 15], target = 9
Output:[0,1]
Explanation: Because nums[0] +nums[1] == 9, we return [0, 1].*/


using System;
using System.Collections.Generic;
using System.Text;

namespace Coding_Challenges
{
    public class TwoSumSolution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            int solA = 0;
            int solB = 0;
            bool solFound = false;
            for (int x = 0; x < nums.Length; x++)
            {
                for (int y = 1; y < nums.Length; y++)
                {
                    if (x != y && nums[x] + nums[y] == target)
                    {
                        solA = x;
                        solB = y;
                        solFound = true;
                    }
                }
                if (solFound == true)
                {
                    break;
                }

            }
            int[] array = new int[] { solA, solB };
            return array;
        }
    }
}
