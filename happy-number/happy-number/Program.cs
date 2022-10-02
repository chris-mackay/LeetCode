using System;
using System.Collections.Generic;

namespace happy_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 19;

            Console.WriteLine(n + " " + IsHappy(n).ToString());
            Console.ReadLine();
            
        }
        public static bool IsHappy(int n)
        {
            int sum;

            if (n >= 1 && n <= (int)Math.Pow(2, 31) - 1)
            {
                do
                {
                    sum = 0;
                    string chars = n.ToString();
                    List<int> nums = new List<int>();

                    foreach (char c in chars)
                        nums.Add(int.Parse(c.ToString()));

                    List<int> sums = new List<int>();

                    foreach (int i in nums)
                        sums.Add((int)Math.Pow(i, 2));

                    foreach (int s in sums)
                    {
                        sum += s;
                    }

                    if (sum == 1)
                    {
                        return true;
                    }
                    else
                    {
                        n = sum;
                    }

                } while (sum != 1);
            }

            return false;
        }
    }
}
