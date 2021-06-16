using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace contains_duplicate
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 1 };
            var query = nums.GroupBy(x => x).Where(g => g.Count() > 1).Select(y => y.Key).ToList();
            bool flag = false;

            if (query.Count > 0) flag = true; else flag = false;

            Console.WriteLine(flag);
            Console.ReadLine();
        }
    }
}
