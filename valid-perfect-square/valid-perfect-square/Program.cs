using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace valid_perfect_square
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 14;
            Console.WriteLine(IsPerfectSquare(num));
            Console.ReadLine();
        }

        static bool IsPerfectSquare(int num)
        {
            bool flag = false;

            if (num >= 1 && num <= 2E31 - 1)
                for (int i = 2; i <= 9; i++)
                    if (num % i == 0) flag = true;

            return flag;
        }
    }
}
