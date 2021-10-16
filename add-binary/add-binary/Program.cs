using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace add_binary
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "10100000100100110110010000010101111011011001101110111111111101000000101111001110001111100001101";
            string b = "110101001011101110001111100110001010100001101011101010000011011011001011101111001100000011011110011";

            Console.WriteLine(AddBinary(a, b));
        }

        public static string AddBinary(string a, string b)
        {
            bool aIsValid = false;
            bool bIsValid = false;
            int bin = 0;

            if (1 <= a.Length && b.Length <= Math.Pow(10, 4))
            {

                // Check each char in the string to make sure
                // it only contains 1's and 0's
                foreach (char c in a)
                {
                    int i = Convert.ToInt32(c.ToString());
                    if(i < 0 || i > 1)
                    {
                        aIsValid = false;
                        break;
                    }
                    else
                    {
                        aIsValid = true;
                    }
                }

                // Check each char in the string to make sure
                // it only contains 1's and 0's
                foreach (char  c in b)
                {
                    int i = Convert.ToInt32(c.ToString());
                    if (i < 0 || i > 1)
                    {
                        bIsValid = false;
                        break;
                    }
                    else
                    {
                        bIsValid = true;
                    }
                }

                // If both a and b only contain 1's and 0's
                // then add the binary
                if (aIsValid && bIsValid)
                {
                    int ai = Convert.ToInt32(a.ToString(), 2);
                    int bi = Convert.ToInt32(b.ToString(), 2);

                    bin = ai + bi;
                    
                }
            }
            return Convert.ToString(bin, 2);
        }
    }
}
