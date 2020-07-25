using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace single_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 2, 2, 1 };
            Console.WriteLine(SingleNumber(nums));
            Console.ReadLine();
        }

        public static int SingleNumber(int[] nums)
        {
            return nums.GroupBy(i => i).Where(g => g.Count() == 1).Select(g => g.First()).First();
        }
    }
}
