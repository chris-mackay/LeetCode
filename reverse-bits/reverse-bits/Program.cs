using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace reverse_bits
{
    class Program
    {
        static void Main(string[] args)
        {
            string b = "00000010100101000001111010011100";
            int i = Convert.ToInt32(b, 2);
            uint u = Convert.ToUInt32(i);

            // 43261596
            Console.WriteLine(ReverseBits(u).ToString());
            Console.ReadLine();
        }

        public static uint ReverseBits(uint n)
        {
            // Need to deal with leading zeros.

            string b = UIntToBinaryString(n);
            char[] a = b.ToCharArray();
            Array.Reverse(a);

            StringBuilder sb = new StringBuilder();
            foreach (char c in a) sb.Append(c);

            string s = sb.ToString();

            int i = Convert.ToInt32(s, 2);
            uint u = Convert.ToUInt32(i);

            // 964176192
            return u;

        }

        public static string UIntToBinaryString(uint number)
        {
            const uint mask = 1;
            var binary = string.Empty;
            while (number > 0)
            {
                // Logical AND the number and prepend it to the result string
                binary = (number & mask) + binary;
                number = number >> 1;
            }

            return binary;
        }
    }
}
