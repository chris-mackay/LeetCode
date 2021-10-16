using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Runtime.Remoting;

namespace divide_two_integers
{
    class Program
    {
        static void Main(string[] args)
        {
            //int =   -2147483648 -> 2147483647
            //long =  -9223372036854775808 -> 9223372036854775807

            int dividend = -2147483648;
            int divisor = -1;
            Console.WriteLine(Divide(dividend, divisor));
            Console.ReadLine();
        }

        public static int Divide(int dividend, int divisor)
        {
            int n = 0;

            return n;
        }
    }
}
