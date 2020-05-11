using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace count_primes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 10;
            Console.WriteLine(CountPrimes(n).ToString());
            Console.Read();
        }

        public static int CountPrimes(int n)
        {
            List<int> primes = new List<int>();

            for (int i = n - 1; i > 1; i--)
            {
                List<int> divisors = new List<int>();

                // Calculate number of divisors
                for (int j = n; j > 1; j--)
                {
                    double d = (double)i / (double)j;

                    if ((d % 1) == 0)
                        divisors.Add((int)d);
                }

                if (divisors.Count == 1 && divisors[0] == 1)
                    primes.Add(i);
            }

            return primes.Count;
        }
    }
}
