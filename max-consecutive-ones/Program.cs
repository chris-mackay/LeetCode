using System;
using System.Collections.Generic;
using System.Linq;

namespace maxconsecutiveones
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int[] a = { 1, 1, 0, 1, 1, 1 };
            Console.WriteLine(FindMaxConsecutiveOnes(a).ToString());
        }

        public static int FindMaxConsecutiveOnes(int[] nums)
        {
            int c = 0;
            List<int> l = new List<int>();

            for (int i = 0; i <= nums.Length - 1; i++)
            {
                int n = nums[i];

                if (n == 1)
                {
                    c++;
                    if (i == nums.Length - 1)
                        l.Add(c);
                }
                else if (n == 0)
                {
                    l.Add(c);
                    c = 0;
                }
            }
           
            return l.Max();
          
        }
    }
}
