using System;
using System.Text;
using System.Numerics;

namespace plus_one
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] digits = { 7,2,8,5,0,9,1,2,9,5,3,6,6,7,3,2,8,4,3,7,9,5,7,7,4,7,4,9,4,7,0,1,1,1,7,4,0,0,6 };
            int[] r = PlusOne(digits);

            foreach (int i in r)
                Console.Write(i);
        }
        
        public static int[] PlusOne(int[] digits) 
        {
            StringBuilder sb = new StringBuilder();

            foreach (int i in digits)
                sb.Append(i.ToString());

            BigInteger n = BigInteger.Parse(sb.ToString());
            n += 1;

            char[] a = n.ToString().ToCharArray();
            int[] r = Array.ConvertAll(a, c => (int)Char.GetNumericValue(c));

            return r;
        }
    }
}
