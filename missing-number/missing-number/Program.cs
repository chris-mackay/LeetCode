using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace missing_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 3, 0, 1 };
            Console.WriteLine(MissingNumber(a));
            Console.ReadLine();
        }
        private static int MissingNumber(int[] nums)
        {
            Array.Sort(nums);
            int n = 0;

            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (i < nums.Length - 1)
                {
                    n = nums[i + 1];
                    if (n - nums[i] != 1) return n - 1;
                }
            }
            return n;
        }
    }

}
