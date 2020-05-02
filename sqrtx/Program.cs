using System;

namespace sqrtx
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MySqrt(8).ToString());
        }

        public static int MySqrt(int x)
        {
            return Convert.ToInt32(Math.Truncate(Math.Sqrt(x)));
        }
    }
}
