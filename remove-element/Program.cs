using System;
using System.Collections.Generic;

namespace remove_element
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 0,1,2,2,3,0,4,2 };
            int val = 2;
            Console.WriteLine(RemoveElement(nums, val));
        }

        public static int RemoveElement(int[] nums, int val)
        {
            // This doesn't work on LeetCode for some reason
            
            List<int> l = new List<int>();

            foreach (int n in nums)
                l.Add(n);

            l.RemoveAll(x => x == val);

            return l.Count;
        }
    }
}
