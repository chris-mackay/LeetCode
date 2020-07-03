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
            string a = "1010";
            string b = "1011";

            Console.WriteLine(AddBinary(a, b));
        }

        public static string AddBinary(string a, string b)
        {
            int ai = Convert.ToInt32(a, 2);
            int bi = Convert.ToInt32(b, 2);

            int bin = ai + bi;
            return Convert.ToString(bin, 2);
        }
    }
}
