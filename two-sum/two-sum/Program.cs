using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace two_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 3, 2, 4 };
            int target = 6;

            int[] indices = TwoSum(nums, target);

            foreach (int index in indices) Console.WriteLine(index);

            Console.ReadLine();
        }

        public static int[] TwoSum(int[] nums, int target)
        {
            List<int> indices = new List<int>();

            for (int i = 0; i <= nums.Length - 1; i++)
                for (int j = 0; j <= nums.Length - 1; j++)
                    if (nums[i] + nums[j] == target && i != j)
                    {
                        if (!indices.Contains(i))
                            indices.Add(i);
                        
                        if (!indices.Contains(j))
                            indices.Add(j);
                    }

            return indices.ToArray();
        }
    }
}
