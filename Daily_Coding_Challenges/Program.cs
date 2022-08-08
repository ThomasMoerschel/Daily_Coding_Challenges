using System;
using Coding_Challenges;

namespace Daily_Coding_Challenges
{
    class Program
    {
        static void Main(string[] args)
        {

            TwoSumSolution twoSum = new TwoSumSolution();
            int[] twoSumArr = new int[] { 2, 7, 11, 15 };
            twoSum.TwoSum(twoSumArr, 9);


            Console.WriteLine("Hello World!");
        }
    }
}
